using System;
using System.Linq;
using System.Text.RegularExpressions;


namespace RobertLw.Interest.CubePrimer.Data
{
    public class CubeData
    {
        #region private readonly fields
        private readonly int[] MAP = 
        {
            // 背面层 9 块，每块的上、下、前、后、左、右
            -1, 15, -1, 35, 42, -1,
            -1, 16, -1, 34, -1, -1,
            -1, 17, -1, 33, -1, 53,
            -1, -1, -1, 32, 39, -1,
            -1, -1, -1, 31, -1, -1,
            -1, -1, -1, 30, -1, 50,
             0, -1, -1, 29, 36, -1,
             1, -1, -1, 28, -1, -1,
             2, -1, -1, 27, -1, 47,
             // 中面层 9 块，每块的上、下、前、后、左、右
            -1, 12, -1, -1, 43, -1,
            -1, 13, -1, -1, -1, -1,
            -1, 14, -1, -1, -1, 52,
            -1, -1, -1, -1, 40, -1,
            -1, -1, -1, -1, -1, -1,
            -1, -1, -1, -1, -1, 49,
             3, -1, -1, -1, 37, -1,
             4, -1, -1, -1, -1, -1,
             5, -1, -1, -1, -1, 46,
             // 前面层 9 块，每块的上、下、前、后、左、右
            -1,  9, 24, -1, 44, -1,
            -1, 10, 25, -1, -1, -1,
            -1, 11, 26, -1, -1, 51,
            -1, -1, 21, -1, 41, -1,
            -1, -1, 22, -1, -1, -1,
            -1, -1, 23, -1, -1, 48,
             6, -1, 18, -1, 38, -1,
             7, -1, 19, -1, -1, -1,
             8, -1, 20, -1, -1, 45
        };

        private readonly int[,] CYCLE_QUARTER_XY = 
        {
            // 按 x、y、z 轴转 90 度后，各块位置
            { 2, 5, 8, 1, 4, 7, 0, 3, 6 },
            { 6, 3, 0, 7, 4, 1, 8, 5, 2 },
            { 2, 5, 8, 1, 4, 7, 0, 3, 6 }
        };
        private readonly int[] CYCLE_HALF_XY = 
        {
            // 轴转 180 度后，各块位置（x、y、z 相同）
            8, 7, 6, 5, 4, 3, 2, 1, 0
        };

        private readonly int[,] CYCLE_QUARTER_FACE = 
        {
            // 按 x、y、z 轴转 90 度后，每一块表面位置
            {2, 3, 1, 0, 4, 5},
            {0, 1, 5, 4, 2, 3},
            {4, 5, 2, 3, 1, 0}
        };
        private readonly int[,] CYCLE_HALF_FACE = 
        {
            // 按 x、y、z 轴转 180 度后，每一块表面位置
            {1, 0, 3, 2, 4, 5},
            {0, 1, 3, 2, 5, 4},
            {1, 0, 2, 3, 5, 4}
        };

        private readonly string LEGAL_CHAR = "RLMUDEFBSrludfbxyz";
        private readonly string LEGAL_SUFFIX = "'2";
        private readonly string LEGAL_SEP = " ()";

        #endregion

        #region private fields
        private string initValue;
        private int[, , ,] model;
        private string stepString;

        private string[] steps;
        private string[] stepsRev;
        private int[] stepIndexs;
        private int[] stepGroup;

        private MOVE_DIREC moveFlg;

        #endregion

        #region event fields
        public delegate void ValueChangedEvent(object sender, EventArgs e);
        public event ValueChangedEvent OnValueChanged;

        public delegate void StepChangedEvent(object sender, EventArgs e);
        public event StepChangedEvent OnStepChanged;

        public delegate void MovedEvent(object sender, EventArgs e);
        public event MovedEvent OnMoved;

        public delegate void AtBeginEvent(object sender, EventArgs e);
        public event AtBeginEvent OnAtBegin;

        public delegate void AtEndEvent(object sender, EventArgs e);
        public event AtEndEvent OnAtEnd;

        #endregion

        #region property
        public string Value
        {
            get { return Model2Value(); }
            set
            {
                if ((StepNo == 0 && value != initValue) || (StepNo != 0 && value != Model2Value()))
                {
                    initValue = value;
                    if (!CheckValue(ref initValue))
                        throw new BadCubeValueException("Bad structure string!");

                    InitStruct(initValue);
                }
            }
        }

        public string StepString
        {
            get { return stepString; }
            set
            {
                if (value != stepString)
                {
                    stepString = value;
                    if (!CheckSteps(ref stepString))
                        throw new BadCubeStepException("Bad step string!");

                    InitSteps(stepString);

                    if (OnStepChanged != null)
                        OnStepChanged(this, new EventArgs());
                }
            }
        }

        public int StepNo { get; private set; }

        public int StepsCount
        {
            get { return steps != null ? steps.Length : 0; }
        }

        public string NextStep
        {
            get { return steps != null && StepNo < StepsCount ? steps[StepNo] : ""; }
        }

        public int NextStepStrIdx
        {
            get { return StepNo < StepsCount ? stepIndexs[StepNo] : StepString.Length; }
        }

        public string LastStep
        {
            get { return steps != null && StepNo != 0 ? steps[StepNo - 1] : ""; }
        }

        public int LastStepStrIdx
        {
            get { return StepNo != 0 ? stepIndexs[StepNo - 1] : 0; }
        }

        public string BackStep
        {
            get { return stepsRev != null && StepNo > 0 ? stepsRev[StepsCount - StepNo] : ""; }
        }

        public AXIS MoveAxis { get; private set; }

        public SIDE MoveSide { get; private set; }

        public CLOCKWISE MoveDirection { get; private set; }

        public ANGLE MoveAngle { get; private set; }

        #endregion

        #region constructor methods
        public CubeData(string value = "", string step = "")
        {
            Init();
            if (!string.IsNullOrEmpty(value))
            {
                Value = value;
                if (!string.IsNullOrEmpty(step))
                    StepString = step;
            }
        }

        #endregion

        #region public methods
        public int Face(int x, int y, int z, POSITION p)
        {
            return model[x, y, z, (int)p - 1];
        }

        public bool GoNext()
        {
            if (StepNo == StepsCount)
            {
                if (OnAtEnd != null)
                    OnAtEnd(this, new EventArgs());
                return false;
            }
            if (NextStep.Length == 0) return false;

            moveFlg = MOVE_DIREC.NEXT;
            SetMove(NextStep);

            return true;
        }

        public bool GoBack()
        {
            if (StepNo == 0)
            {
                if (OnAtBegin != null)
                    OnAtBegin(this, new EventArgs());
                return false;
            }
            if (BackStep.Length == 0) return false;

            moveFlg = MOVE_DIREC.BACK;
            SetMove(BackStep);

            return true;
        }

        public void CalcMove()
        {
            CalcModel();

            StepNo += (int)moveFlg;
            InitMove();
        }

        public void Move()
        {
            CalcMove();

            if (OnValueChanged != null)
                OnValueChanged(this, new EventArgs());
            if (OnMoved != null)
                OnMoved(this, new EventArgs());
        }

        public void Reset()
        {
            InitStruct(initValue);
        }

        #endregion

        #region private methods
        private void Init()
        {
            initValue = "";
            model = new int[3, 3, 3, 6];
            stepString = "";

            steps = stepsRev = null;
            stepIndexs = stepGroup = null;

            StepNo = 0;
            InitMove();
        }

        private void InitMove()
        {
            moveFlg = MOVE_DIREC.NONE;

            MoveAxis = 0;
            MoveSide = 0;
            MoveDirection = 0;
            MoveAngle = 0;
        }

        private void InitStruct(string value)
        {
            Value2Model(value);

            if (OnValueChanged != null)
                OnValueChanged(this, new EventArgs());
        }

        private void InitSteps(string step)
        {
            steps = stepsRev = null;
            stepIndexs = stepGroup = null;

            StepNo = 0;
            InitMove();

            if (!string.IsNullOrEmpty(step))
            {
                SetSteps(step);
            }
        }

        private bool CheckValue(ref string value)
        {
            if (string.IsNullOrEmpty(value)) return true;

            if (value.Length < 54)
                value = value.PadRight(54 - value.Length, '7');
            if (value.Length > 54)
                value = value.Substring(0, 54);

            string patten = "[0-7]{54}";
            return Regex.IsMatch(value, patten);
        }

        private bool CheckSteps(ref string step)
        {
            if (string.IsNullOrEmpty(step)) return true;

            if (step.Count(c => c == '(') !=
                step.Count(c => c == ')'))
                return false;

            step = step.Replace("2'", LEGAL_SUFFIX);

            string patten = @"\(?[" + LEGAL_CHAR + "][" + LEGAL_SUFFIX + @"]{0,2}\)?";

            if (!Regex.IsMatch(step, string.Format(@"^\s*({0}\s*)+$", patten)))
                return false;

            Regex rex = new Regex(patten);
            MatchCollection matches = rex.Matches(step);
            step = string.Join(" ", matches.Cast<Match>().Select(itm => itm.Value));
            stepGroup = matches.Cast<Match>()
                               .Select((v, i) => new { idx = i, val = v.Value })
                               .Where(itm => itm.val.Contains("(") || itm.val.Contains(")"))
                               .Select(itm => itm.idx)
                               .ToArray();

            return true;
        }

        private void Value2Model(string value)
        {
            model = new int[3, 3, 3, 6];

            if (!string.IsNullOrEmpty(value))

                for (int x = 0; x < 3; x++)
                    for (int y = 0; y < 3; y++)
                        for (int z = 0; z < 3; z++)
                            for (int f = 0; f < 6; f++)
                            {
                                int i = MAP[z * 54 + y * 18 + x * 6 + f];
                                if (i != -1)
                                {
                                    char c = value[i];
                                    model[x, y, z, f] = (c >= '0' && c < '7') ? c - 48 : 7;
                                }
                            }
        }

        private string Model2Value()
        {
            if (model == null) return "";

            char[] chrs = new char[54];
            for (int i = 0; i < MAP.Length; i++)
            {
                if (MAP[i] == -1)
                    continue;

                int z = i / 54;
                int y = i % 54 / 18;
                int x = i % 54 % 18 / 6;
                int f = i % 6;
                chrs[MAP[i]] = (char)(model[x, y, z, f] + 48);
            }
            return string.Join("", chrs);
        }

        private void SetSteps(string step)
        {
            int n = 0;

            var q = step.Select((v, k) =>
            {
                if (LEGAL_CHAR.Contains(v))
                    n = k;
                if (LEGAL_SEP.Contains(v))
                    return null;
                else
                    return new { idx = n, val = v, flg = LEGAL_CHAR.Contains(v) };
            }
            ).Where(itm => itm != null);

            steps = q.GroupBy(itm => itm.idx)
                     .Select(grp => string.Join("", grp.Select(g => g.val).ToArray()))
                     .ToArray();

            stepIndexs = q.Where(itm => itm.flg)
                          .Select(itm => itm.idx)
                          .ToArray();

            stepsRev = steps.Reverse().Select(itm => ReverseStep(itm)).ToArray();
        }

        private void SetMove(string step)
        {
            // 旋转度数
            if (step[step.Length - 1] == '2')
            {
                MoveAngle = ANGLE.HALF;
                step = step.Substring(0, step.Length - 1);
            }
            else
                MoveAngle = ANGLE.QUARTER;

            // 旋转方向
            if (step[step.Length - 1] == '\'')
            {
                MoveDirection = CLOCKWISE.LEFT;
                step = step.Substring(0, step.Length - 1);
            }
            else
                MoveDirection = CLOCKWISE.RIGHT;
            if (step.ToLower().Equals("l") ||
                step.ToLower().Equals("b") ||
                step.ToLower().Equals("d"))
                MoveDirection = (CLOCKWISE)((int)MoveDirection * -1);

            // 旋转的轴和层面
            switch (step)
            {
                case "R":
                    MoveAxis = AXIS.X;
                    MoveSide = SIDE.THIRD;
                    break;
                case "M":
                    MoveAxis = AXIS.X;
                    MoveSide = SIDE.SECOND;
                    break;
                case "L":
                    MoveAxis = AXIS.X;
                    MoveSide = SIDE.FIRST;
                    break;
                case "U":
                    MoveAxis = AXIS.Y;
                    MoveSide = SIDE.THIRD;
                    break;
                case "E":
                    MoveAxis = AXIS.Y;
                    MoveSide = SIDE.SECOND;
                    break;
                case "D":
                    MoveAxis = AXIS.Y;
                    MoveSide = SIDE.FIRST;
                    break;
                case "F":
                    MoveAxis = AXIS.Z;
                    MoveSide = SIDE.THIRD;
                    break;
                case "S":
                    MoveAxis = AXIS.Z;
                    MoveSide = SIDE.SECOND;
                    break;
                case "B":
                    MoveAxis = AXIS.Z;
                    MoveSide = SIDE.FIRST;
                    break;
                case "r":
                    MoveAxis = AXIS.X;
                    MoveSide = SIDE.THIRD | SIDE.SECOND;
                    break;
                case "l":
                    MoveAxis = AXIS.X;
                    MoveSide = SIDE.FIRST | SIDE.SECOND;
                    break;
                case "u":
                    MoveAxis = AXIS.Y;
                    MoveSide = SIDE.THIRD | SIDE.SECOND;
                    break;
                case "d":
                    MoveAxis = AXIS.Y;
                    MoveSide = SIDE.FIRST | SIDE.SECOND;
                    break;
                case "f":
                    MoveAxis = AXIS.Z;
                    MoveSide = SIDE.THIRD | SIDE.SECOND;
                    break;
                case "b":
                    MoveAxis = AXIS.Z;
                    MoveSide = SIDE.FIRST | SIDE.SECOND;
                    break;
                case "x":
                    MoveAxis = AXIS.X;
                    MoveSide = SIDE.FIRST | SIDE.SECOND | SIDE.THIRD;
                    break;
                case "y":
                    MoveAxis = AXIS.Y;
                    MoveSide = SIDE.FIRST | SIDE.SECOND | SIDE.THIRD;
                    break;
                case "z":
                    MoveAxis = AXIS.Z;
                    MoveSide = SIDE.FIRST | SIDE.SECOND | SIDE.THIRD;
                    break;
            }
        }

        private string ReverseStep(string step)
        {
            if (step.Contains("'"))
                return step.Replace("'", "");

            return step.Insert(1, "'");
        }

        private void CalcModel()
        {
            if (((int)MoveSide & (int)SIDE.FIRST) == (int)SIDE.FIRST)
                CalcSide(SIDE.FIRST);

            if (((int)MoveSide & (int)SIDE.SECOND) == (int)SIDE.SECOND)
                CalcSide(SIDE.SECOND);

            if (((int)MoveSide & (int)SIDE.THIRD) == (int)SIDE.THIRD)
                CalcSide(SIDE.THIRD);
        }

        private void CalcSide(SIDE side)
        {
            int k = 0;
            if (side == SIDE.SECOND)
                k = 1;
            if (side == SIDE.THIRD)
                k = 2;

            int[, ,] sideModel = new int[3, 3, 6];
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                {
                    int oi, oj;
                    CalcBox(i, j, out oi, out oj);
                    for (int f = 0; f < 6; f++)
                    {
                        switch (MoveAxis)
                        {
                            case AXIS.X:
                                sideModel[i, j, f] = model[k, oi, oj, CalcFace(f)];
                                break;
                            case AXIS.Y:
                                sideModel[i, j, f] = model[oi, k, oj, CalcFace(f)];
                                break;
                            case AXIS.Z:
                                sideModel[i, j, f] = model[oi, oj, k, CalcFace(f)];
                                break;
                        }
                    }
                }
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                {
                    for (int f = 0; f < 6; f++)
                    {
                        switch (MoveAxis)
                        {
                            case AXIS.X:
                                model[k, i, j, f] = sideModel[i, j, f];
                                break;
                            case AXIS.Y:
                                model[i, k, j, f] = sideModel[i, j, f];
                                break;
                            case AXIS.Z:
                                model[i, j, k, f] = sideModel[i, j, f];
                                break;
                        }
                    }
                }
        }

        private void CalcBox(int i, int j, out int oi, out int oj)
        {
            int n = j * 3 + i;

            if (MoveAngle == ANGLE.HALF)
                n = CYCLE_HALF_XY[n];
            else
            {
                n = CYCLE_QUARTER_XY[(int)MoveAxis - 1, n];
                if (MoveDirection == CLOCKWISE.LEFT)
                    n = CYCLE_HALF_XY[n];
            }

            oi = n % 3;
            oj = n / 3;
        }

        private int CalcFace(int f)
        {
            if (MoveAngle == ANGLE.HALF)
                return CYCLE_HALF_FACE[(int)MoveAxis - 1, f];

            f = CYCLE_QUARTER_FACE[(int)MoveAxis - 1, f];
            if (MoveDirection == CLOCKWISE.LEFT)
                return CYCLE_HALF_FACE[(int)MoveAxis - 1, f];

            return f;
        }

        #endregion

    }

    #region extend exceptioin
    public class BadCubeValueException : ApplicationException
    {
        public BadCubeValueException(string message) : base(message) { }
    }

    public class BadCubeStepException : ApplicationException
    {
        public BadCubeStepException(string message) : base(message) { }
    }

    #endregion

}

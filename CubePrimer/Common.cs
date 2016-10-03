using System;
using System.Drawing;

namespace RobertLw.Interest.CubePrimer
{
    struct Common
    {
        public const string DEF_VALUE = "111111111" +    //top
                                        "222222222" +    //bottom
                                        "333333333" +    //front
                                        "444444444" +    //back
                                        "555555555" +    //left
                                        "666666666";     //right

        public static readonly Color[] DEF_COLOR = new Color[] 
        {
            Color.Black,                                // black
            Color.FromArgb(0xff, 0xcc, 0xcc, 0x0),      // yellow
            Color.FromArgb(0xff, 0xe0, 0xe0, 0xe0),     // white
            Color.FromArgb(0xff, 0xcc, 0x0, 0x0),       // red
            Color.FromArgb(0xff, 0xcc, 0x4c, 0x0),      // orange
            Color.FromArgb(0xff, 0x0, 0x0, 0xcc),       // blue
            Color.FromArgb(0xff, 0x0, 0x99, 0x0),       // green
            Color.Gray                                  // gray
        };

        public static Color[] CurColor = (Color[])DEF_COLOR.Clone();

        public const string COMM_CHAR = "#";
    }

    public enum POSITION
    {
        REVERSE = 0,

        TOP = 1,
        BOTTOM = 2,
        FRONT = 3,
        BACK = 4,
        LEFT = 5,
        RIGHT = 6,

        IGNORE = 7
    }

    public enum AXIS
    {
        X = 1,
        Y = 2,
        Z = 3
    }

    [Flags]
    public enum SIDE
    {
        FIRST = 1,
        SECOND = 2,
        THIRD = 4
    }

    public enum CLOCKWISE
    {
        RIGHT = -1,
        LEFT = 1
    }

    public enum ANGLE
    {
        QUARTER = 90,
        HALF = 180
    }

    public enum MOVE_DIREC
    {
        NONE = 0,
        BACK = -1,
        NEXT = 1
    }

    public static class GlobalValue
    {
        public static float MinFloat = 0.0001F;
    }
}

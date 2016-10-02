using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Windows.Forms;
using System.Collections;

namespace RobertLw.Interest.CubePrimer.Data
{
    [Serializable()]
    public class Shortcut : ISerializable
    {
        #region property
        public string Text { get; set; }

        public string ObjectName { get; set; }
        public string Method { get; set; }

        public Keys Key { get; set; }
        public bool Alt { get; set; }
        public bool Ctrl { get; set; }
        public bool Shift { get; set; }

        public bool IsMenu { get; private set; }

        #endregion

        #region constructor methods
        public Shortcut() { }

        public Shortcut(Shortcut stc)
        {
            Text = stc.Text;
            ObjectName = stc.Text;
            Method = stc.Method;
            Key = stc.Key;
            Alt = stc.Alt;
            Ctrl = stc.Ctrl;
            Shift = stc.Shift;
            IsMenu = stc.IsMenu;
        }

        public Shortcut(string text, Keys key)
        {
            Text = text;
            ObjectName = "";
            Method = "";

            Key = key & ~Keys.Alt & ~Keys.Control & ~Keys.Shift;
            Alt = (key & Keys.Alt) == Keys.Alt;
            Ctrl = (key & Keys.Control) == Keys.Control;
            Shift = (key & Keys.Shift) == Keys.Shift;

            IsMenu = true;
        }

        public Shortcut(string text, string obj, string method,
                        Keys key, bool alt = false, bool ctrl = false, bool shift = false,
                        bool ismenu = false)
        {
            Text = text;
            ObjectName = obj;
            Method = method;
            Key = key;
            Alt = alt;
            Ctrl = ctrl;
            Shift = shift;
            IsMenu = ismenu;
        }

        public Shortcut(SerializationInfo info, StreamingContext ctxt)
        {
            Text = (string)info.GetValue("Text", typeof(string));
            ObjectName = (string)info.GetValue("ControlName", typeof(string));
            Method = (string)info.GetValue("Method", typeof(string));
            Key = (Keys)info.GetValue("Key", typeof(Keys));
            Alt = (bool)info.GetValue("Alt", typeof(bool));
            Ctrl = (bool)info.GetValue("Ctrl", typeof(bool));
            Shift = (bool)info.GetValue("Shift", typeof(bool));
            IsMenu = (bool)info.GetValue("IsMenu", typeof(bool));
        }

        #endregion

        #region public methods
        public void GetObjectData(SerializationInfo info, StreamingContext ctxt)
        {
            info.AddValue("Text", Text);
            info.AddValue("ControlName", ObjectName);
            info.AddValue("Method", Method);
            info.AddValue("Key", Key);
            info.AddValue("Alt", Alt);
            info.AddValue("Ctrl", Ctrl);
            info.AddValue("Shift", Shift);
            info.AddValue("IsMenu", IsMenu);
        }

        public void SetMenu(bool im)
        {
            IsMenu = im;
        }

        #endregion
    }

    [Serializable()]
    public class ShortcutsSaver : ISerializable, IEnumerable
    {
        #region private fields
        private readonly List<Shortcut> items;

        #endregion

        #region property
        public Shortcut this[string text]
        {
            get
            {
                var stc = items.Where(i => i.Text == text);
                var l = stc.ToList();

                if (l.Count == 0) return null;
                return l[0];
            }
            set
            {
                var stc = items.Where(i => i.Text == text);
                var l = stc.ToList();
                if (l.Count == 0) return;
                // 好像还有问题，无法赋值？
                l[0] = value;
            }
        }

        #endregion

        #region constructor methods
        public ShortcutsSaver()
        {
            items = new List<Shortcut>();
        }

        public ShortcutsSaver(SerializationInfo info, StreamingContext context)
        {
            items = (List<Shortcut>)info.GetValue("List<Shortcut>", typeof(List<Shortcut>));
        }

        #endregion

        #region public methods
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("List<Shortcut>", items);
        }

        public bool ContainsKey(Keys key, bool alt, bool ctrl, bool shift)
        {
            if (key == Keys.None) return false;

            return items.Any(i =>
                i.Key == key &&
                i.Alt == alt &&
                i.Ctrl == ctrl &&
                i.Shift == shift);
        }

        public bool ContainsText(string text)
        {
            return items.Any(i => i.Text == text);
        }

        public bool GetMethod(Keys key, 
                              bool alt, bool ctrl, bool shift, 
                              out string obj, out string method)
        {
            var stc = items.Where(i =>
                i.Key == key &&
                i.Alt == alt &&
                i.Ctrl == ctrl &&
                i.Shift == shift);

            var l = stc.ToList();
            if (l.Count == 0)
            {
                obj = "";
                method = "";
                return false;
            }

            obj = l[0].ObjectName;
            method = l[0].Method;
            return true;
        }

        public void AddMenu(string text, Keys key)
        {
            items.Add(new Shortcut(text, key));
        }

        public void AddKey(string text, string obj, string method)
        {
            items.Add(new Shortcut(text, obj, method, Keys.None));
        }

        public void Add(Shortcut item)
        {
            if (ContainsKey(item.Key, item.Alt, item.Ctrl, item.Shift))
                throw new ArgumentException("已添加了具有相同键的项。");

            if (ContainsText(item.Text))
                this[item.Text] = item;
            else
                items.Add(item);
        }

        public void Add(string text,
                        string obj, string method,
                        Keys key = Keys.None, bool alt = false, bool ctrl = false, bool shift = false,
                        bool ismenu = false)
        {
            if (ContainsKey(key, alt, ctrl, shift))
                throw new ArgumentException("已添加了具有相同键的项。");

            Shortcut stc = new Shortcut(text, obj, method, key, alt, ctrl, shift, ismenu);
            if (ContainsText(text))
                this[text] = stc;
            else
                items.Add(stc);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return items.GetEnumerator();
        }

        public IEnumerable<Shortcut> Menus()
        {
            return items.Where(i => i.IsMenu);
        }

        #endregion
    }
}

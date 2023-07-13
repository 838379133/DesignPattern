using System;
using System.Collections.Generic;
using System.Text;

namespace MementoSample
{
    class Chessman  //原发器
    {
        private string mLabel;
        private int mx;
        private int my;

        public string Label
        {
            get { return mLabel; }
            set { mLabel = value; }
        }

        public int X
        {
            get { return mx; }
            set { mx = value; }
        }

        public int Y
        {
            get { return my; }
            set { my = value; }
        }

        public Chessman(string label, int x, int y)
        {
            mLabel = label;
            mx = x;
            my = y;
        }

        //保存状态
        internal ChessmanMemento Save()
        {
            return new ChessmanMemento(this.Label, this.X, this.Y);
        }

        //恢复状态
        internal void Restore(ChessmanMemento memento)
        {
            this.Label = memento.Label;
            this.X = memento.X;
            this.Y = memento.Y;
        }
    }
}

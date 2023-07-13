using System;
using System.Collections.Generic;
using System.Text;

namespace MementoSample
{
    internal class ChessmanMemento //备忘录
    {
        private readonly string mLabel;
        private readonly int mx;
        private readonly int my;

        internal string Label
        {
            get { return mLabel; }
        }

        internal int X
        {
            get { return mx; }
        }

        internal int Y
        {
            get { return my; }
        }
        internal ChessmanMemento(string label, int x, int y)
        {
            mLabel = label;
            mx = x;
            my = y;
        }
    }
}

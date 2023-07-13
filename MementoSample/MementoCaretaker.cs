using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace MementoSample
{
    class MementoCaretaker //负责人
    {
        private readonly ArrayList mMementolist = new ArrayList();
        //private ChessmanMemento mMemento;

        internal ChessmanMemento GetMenmento(int i)
        {
            return (ChessmanMemento)mMementolist[i];
        }

        internal void SetMemento(ChessmanMemento memento)
        {
                mMementolist.Add(memento);
        }
    }
}

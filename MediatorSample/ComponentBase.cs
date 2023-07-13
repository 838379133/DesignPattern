using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorSample
{
    abstract class ComponentBase
    {
        protected MediatorBase mMediator;

        public void SetMediator(MediatorBase mediator)
        {
            mMediator = mediator;
        }

        //转发调用
        public void Changed()
        {
            mMediator.ComponentChanged(this);
        }

        public abstract void Update();
    }
}

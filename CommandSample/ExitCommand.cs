using System;
using System.Collections.Generic;
using System.Text;

namespace CommandSample
{
    class ExitCommand : CommandBase     //具体命令类
    {
        private SystemExitClass mSeObj;   //维持对请求接受者的引用

        public ExitCommand()
        {
            mSeObj = new SystemExitClass();
        }

        //命令执行方法 将调用请求接受者的业务方法
        public override void Execute()
        {
            mSeObj.Exit();
        }
    }
}

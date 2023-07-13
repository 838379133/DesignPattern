using System;
using System.Collections.Generic;
using System.Text;

namespace CommandSample
{
    class HelpCommand : CommandBase //具体命令类
    {
        private readonly DisplayHelpClass mDhObj;    //维持请求接受者的引用

        public HelpCommand()
        {
            mDhObj = new DisplayHelpClass();
        }

        //命令执行方法，将调用请求接受者的业务方法
        public override void Execute()
        {
            mDhObj.Display();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace CommandSample
{
    class FunctionButton    //请求调用者
    {
        private CommandBase mCommand;    //抽象命令对象的引用

        //为功能键注入命令
        public CommandBase Command
        {
            get { return mCommand; }
            set { mCommand = value; }
        }

        //发送请求的方法
        public void Click()
        {
            Console.WriteLine("单击功能键！");
            mCommand.Execute();
        }
    }
}

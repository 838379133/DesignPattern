using System;

namespace CommandSample
{
    class Program
    {
        static void Main(string[] args)
        {
            FunctionButton fb = new FunctionButton();

            CommandBase command;
            command = new ExitCommand();

            fb.Command = command;
            fb.Click();

            Console.Read();
        }
    }
}

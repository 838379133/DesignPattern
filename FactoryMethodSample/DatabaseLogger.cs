using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodSample
{
    class DatabaseLogger : ILogger
    {
        public void WriteLog()
        {
            Console.WriteLine("数据库日志记录.");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodSample
{
    class FileLoggerFactory : ILoggerFactory
    {
        public ILogger CreateLogger()
        {
            //创建文件日志记录器对象
            ILogger logger = new FileLogger();
            return logger;
        }
    }
}

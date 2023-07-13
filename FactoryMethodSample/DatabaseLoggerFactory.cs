using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodSample
{
    class DatabaseLoggerFactory : ILoggerFactory
    {
        public ILogger CreateLogger()
        {
            //连接数据库
            //创建数据库日志记录
            ILogger logger = new DatabaseLogger();
            return logger;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace VisitorSample
{
    abstract class DepartmentBase  //抽象访问者类
    {
        public abstract void Visit(FulltimeEmployee employee);
        public abstract void Visit(ParttimeEmployee employee);
    }
}

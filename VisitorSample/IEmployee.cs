using System;
using System.Collections.Generic;
using System.Text;

namespace VisitorSample
{
    interface IEmployee //抽象元素
    {
        //string Name { get; }
        void Accept(DepartmentBase handler); //接受一个抽象访问者访问
    }
}

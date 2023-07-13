using System;
using System.Collections;
using System.Text;

namespace VisitorSample
{
    class EmployeeList
    {
        //定义一个集合存储员工对象
        private readonly ArrayList list = new ArrayList();

        public void AddEmployee(IEmployee employee)
        {
            list.Add(employee);
        }

        //遍历访问员工集合的每一个对象
        public void Accpet(DepartmentBase handler)
        {
            foreach(Object obj in list)
            {
                ((IEmployee)obj).Accept(handler);
            }
        }
    }
}

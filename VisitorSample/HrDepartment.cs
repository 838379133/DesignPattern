using System;
using System.Collections.Generic;
using System.Text;

namespace VisitorSample
{
    class HrDepartment : DepartmentBase
    {
        //实现人力资源部对全职员工的访问
        public override void Visit(FulltimeEmployee employee)
        {
            int workTime = employee.WorkTIme;
            Console.WriteLine("正式员工{0}的实际工作时间为：{1}小时", employee.Name, workTime);
            if (workTime > 40)
            {
                Console.WriteLine("正式员工{0}的加班时间为：{1}小时", employee.Name, workTime - 40);
            }
            else if (workTime < 40)
            {
                Console.WriteLine("正式员工{0}的请假时间为：{1}小时", employee.Name, 40 - workTime);
            }
        }
        //实现人力资源部对兼职员工的访问
        public override void Visit(ParttimeEmployee employee)
        {
            int workTime = employee.WorkTIme;
            Console.WriteLine("临时员工{0}的实际工作时间为：{1}小时", employee.Name, workTime);
        }
    }
}

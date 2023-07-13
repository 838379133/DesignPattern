using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorSample
{
    class TextBox : ComponentBase
    {
        public override void Update()
        {
            Console.WriteLine("客户信息增加成功后文本框清空");
        }

        public void SetText()
        {
            Console.WriteLine("文本框：小龙女");
        }
    }
}

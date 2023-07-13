using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorSample
{
    class ConcreteMediator : MediatorBase   //具体中介类
    {
        //维持对各个同事对象的引用
        private readonly Button AddButton;
        private readonly List List;
        private readonly TextBox UserTextBox;
        private readonly ComboBox ComboBox;

        public ConcreteMediator(Button addButton, List list, TextBox userTextBox, ComboBox comboBox)
        {
            AddButton = addButton;
            List = list;
            UserTextBox = userTextBox;
            ComboBox = comboBox;
        }

        //封装同事对象之间的交互
        public override void ComponentChanged(ComponentBase c)
        {
            //单击按钮
            if(c == AddButton)
            {
                Console.WriteLine("---单击增加按钮---");
                List.Update();
                ComboBox.Update();
                UserTextBox.Update();
            }
            //从列表框选择客户
            else if(c == List)
            {
                Console.WriteLine("---从列表框选择客户---");
                ComboBox.Select();
                UserTextBox.SetText();
            }
            //从组合框选择客户
            else if(c == ComboBox)
            {
                Console.WriteLine("---从组合框选择客户---");
                ComboBox.Select();
                UserTextBox.SetText();
            }
        }
    }
}

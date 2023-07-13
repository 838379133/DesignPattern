using System;

namespace MediatorSample
{
    class Program
    {
        static void Main(string[] args)
        {
           
            //定义同事对象
            Button addBT = new Button();
            List list = new List();
            ComboBox cb = new ComboBox();
            TextBox userNameTB = new TextBox();

            //定义中介者对象
            ConcreteMediator mediator = new ConcreteMediator(addBT, list, userNameTB, cb);

            addBT.SetMediator(mediator);
            list.SetMediator(mediator);
            cb.SetMediator(mediator);
            userNameTB.SetMediator(mediator);

            //mediator.mAddButton = addBT;
            //mediator.mList = list;
            //mediator.mComboBox = cb;
            //mediator.mUserTextBox = userNameTB;

            addBT.Changed();
            Console.WriteLine("------------------------");
            list.Changed();

            Console.Read();
        }
    }
}

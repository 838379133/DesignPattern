﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethodSample
{
    abstract  class Account
    {
        //基本方法 具体方法
        public bool Validate(string account, string password)
        {
            Console.WriteLine("账户：{0}", account);
            Console.WriteLine("账户：{0}", password);
            //模拟登录
            if (account.Equals("张无忌") && password.Equals("123456"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //抽象方法
        public abstract void CalculateInterest();

        //具体方法
        public void Display()
        {
            Console.WriteLine("显示利息！");
        }

        //模板方法
        public void Handle(string account, string password)
        {
            if(!Validate(account, password))
            {
                Console.WriteLine("账户或密码错误");
                return;
            }
            CalculateInterest();
            Display();
        }

    }
}

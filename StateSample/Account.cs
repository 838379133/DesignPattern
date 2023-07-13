using System;
using System.Collections.Generic;
using System.Text;

namespace StateSample
{
    class Account   //环境类
    {
        private AccountStateBase mState;    //维持对抽象状态对象的引用
        private readonly string mOwner;          //开户名
        private double mBalance = 0;     //账户余额

        public Account(string owner, double init)
        {
            mOwner = owner;
            mBalance = init;
            mState = new NormalState(this);     //设置初始状态
            Console.WriteLine("{0}开户，初始金额为{1}", owner, init);
            Console.WriteLine("------------------");
        }

        public double Balance
        {
            get { return mBalance; }
            set { mBalance = value; }
        }

        public void SetState(AccountStateBase state)
        {
            mState = state;
        }

        public void Deposit(double amount)
        {
            Console.WriteLine("{0}存款{1}", mOwner, amount);
            mState.Deposit(amount);     //调用状态对象的deposit方法
            Console.WriteLine("现在余额为{0}", mBalance);
            Console.WriteLine("现在账户状态为{0}", mState.GetType().ToString());
            Console.WriteLine("--------------");
        }

        public void Withdraw(double amount)
        {
            Console.WriteLine("{0}取款{1}", mOwner, amount);
            mState.Withdraw(amount);     //调用状态对象的deposit方法
            Console.WriteLine("现在余额为{0}", mBalance);
            Console.WriteLine("现在账户状态为{0}", mState.GetType().ToString());
            Console.WriteLine("--------------");
        }

        public void ComputeInterest()
        {
            mState.ComputeInterest();   
        }
    }
}

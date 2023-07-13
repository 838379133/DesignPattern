using System;
using System.Collections.Generic;
using System.Text;

namespace StateSample
{
    class RestrictedState : AccountStateBase
    {
        public RestrictedState(AccountStateBase state)
        {
            this.Acc = state.Acc;
        }

        public override void Deposit(double amount)
        {
            Acc.Balance = Acc.Balance + amount;
            StateCheck();
        }
        public override void Withdraw(double amount)
        {
            Console.WriteLine("账号受限，取款失败");
        }
        public override void ComputeInterest()
        {
            Console.WriteLine("计算利息");
        }

        //状态转换
        public override void StateCheck()
        {
            if (Acc.Balance > 0)
            {
                Acc.SetState(new NormalState(this));
            }
            else if (Acc.Balance > -2000)
            {
                Acc.SetState(new OverdraftState(this));
            }
        }
    }
}

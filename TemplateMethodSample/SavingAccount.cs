using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethodSample
{
    class SavingAccount : Account
    {
        public override void CalculateInterest()
        {
            Console.WriteLine("按定期计算利息");
        }
    }
}

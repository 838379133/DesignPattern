using System;
using System.Collections.Generic;
using System.Text;

namespace CoRSample
{
    class PurchaseRequest    //请求类
    {
        private readonly double mAmount;  //采购金额
        private readonly int mNumber;     //采购单编号
        private readonly string mPurpose; //采购目的

        public PurchaseRequest(double amount, int number, string purpose)
        {
            mAmount = amount;
            mNumber = number;
            mPurpose = purpose;
        }

        public double Amount
        {
            get { return mAmount; }
        }

        public int Number
        {
            get { return mNumber; }
        }

        public string Purpose
        {
            get { return mPurpose; }
        }
    }
}

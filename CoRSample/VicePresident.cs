﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CoRSample
{
    class VicePresident : ApproverBase
    {
        public VicePresident(string name) : base(name)
        {

        }

        //具体请求处理方法
        public override void ProcessRequest(PurchaseRequest request)
        {
            if (request.Amount < 100000)
            {
                Console.WriteLine("副董事长{0}审批采购单：{1},金额：{2}元，采购目的：{3}。", this.mName, request.Number, request.Amount, request.Purpose); //处理请求
            }
            else
            {
                this.mSuccessor.ProcessRequest(request);    //转发请求
            }
        }
    }
}

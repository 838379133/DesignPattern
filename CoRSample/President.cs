using System;
using System.Collections.Generic;
using System.Text;

namespace CoRSample
{
    class President : ApproverBase
    {
        public President(string name) : base(name)
        {

        }

        //具体请求处理方法
        public override void ProcessRequest(PurchaseRequest request)
        {
            if (request.Amount < 500000)
            {
                Console.WriteLine("董事长{0}审批采购单：{1},金额：{2}元，采购目的：{3}。", this.mName, request.Number, request.Amount, request.Purpose);
            }
            else
            {
                this.mSuccessor.ProcessRequest(request);
            }
        }
    }
}

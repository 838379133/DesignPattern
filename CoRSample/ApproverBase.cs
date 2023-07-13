using System;
using System.Collections.Generic;
using System.Text;

namespace CoRSample
{
    abstract class ApproverBase  //抽象处理者
    {
        protected ApproverBase mSuccessor;  //定义后继对象
        protected string mName;             //审批者姓名

        public ApproverBase(string name)
        {
            mName = name;
        }

        //设置后继者
        public void SetSuccessor(ApproverBase successor)
        {
            mSuccessor = successor;
        }

        //抽象请求处理方法
        public abstract void ProcessRequest(PurchaseRequest request);
    }
}

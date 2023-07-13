using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterSample
{
    interface IScoreOperation//目标接口
    {
        int[] Sort(int[] array);            //成绩查询
        int Search(int[] arrat, int key);   //成绩查找
    }
}

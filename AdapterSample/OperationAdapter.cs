using System;
using System.Collections.Generic;
using System.Text;
//适配器
namespace AdapterSample
{
    class OperationAdapter : IScoreOperation
    {
        private QuickSortClass sortObj;         //定义适配者
        private BinarySearchClass searchObj;
        
        public OperationAdapter()
        {
            sortObj = new QuickSortClass();
            searchObj = new BinarySearchClass();
        }

        public int[] Sort(int[] array)
        {
            return sortObj.QuickSort(array);  //调用适配者类的排序方法
        }

        public int Search(int[] array, int key)
        {
            //调用适配者类的查找方法
            return searchObj.BinarySearch(array, key);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace IteratorSample
{
    class ProductIterator : IAbstractIterator
    {
        //private readonly ProductList mProductList;
        private readonly List<object> mProducts;
        private int mCursor1;            //定义一个游标，用于记录正向遍历的位置
        private int mCursor2;            //定义一个游标，用于记录逆向遍历的位置

        public ProductIterator(ProductList list)
        {
            //mProductList = list;
            mProducts = list.GetObjects();
            mCursor1 = 0;
            mCursor2 = mProducts.Count - 1;
        }

        public void Next()
        {
            if(mCursor1 < mProducts.Count)
            {
                mCursor1++;
            }
        }

        public bool IsLast()
        {
            return (mCursor1 == mProducts.Count);
        }

        public void Previous()
        {
            if(mCursor2 > -1)
            {
                mCursor2--;
            }
        }

        public bool IsFirst()
        {
            return (mCursor2 == -1);
        }

        public object GetNextItem()
        {
            return mProducts[mCursor1];
        }

        public object GetPreviousItem()
        {
            return mProducts[mCursor2];
        }
    }
}

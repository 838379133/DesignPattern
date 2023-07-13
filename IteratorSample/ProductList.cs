using System;
using System.Collections.Generic;
using System.Text;

namespace IteratorSample
{
    class ProductList : AbstractObjectList
    {
        public ProductList(List <object> products) : base(products)
        {

        }

        //实现创建迭代器对象的具体工厂方法
        public override IAbstractIterator CreateIterator()
        {
            return new ProductIterator(this);
        }
    }
}

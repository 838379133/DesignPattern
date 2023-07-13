using System;
using System.Collections.Generic;
using System.Text;

namespace IteratorSample    
{
    abstract class AbstractObjectList    //抽象聚合类
    {
        protected List <object> mObjects = new List <object>();

        public AbstractObjectList(List<object> objects)
        {
            mObjects = objects;
        }

        public void AddObjects(object obj)
        {
            mObjects.Add(obj);
        }

        public void RemoveObject(object obj)
        {
            mObjects.Remove(obj);
        }

        public List<object> GetObjects()
        {
            return mObjects;
        }

        //声明创建迭代器对象的抽象工厂方法
        public abstract IAbstractIterator CreateIterator();

    }
}

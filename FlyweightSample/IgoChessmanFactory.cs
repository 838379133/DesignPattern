using System;
using System.Collections;
using System.Text;

namespace FlyweightSample
{
    class IgoChessmanFactory
    {
        private static readonly IgoChessmanFactory mInstance = new IgoChessmanFactory();
        private readonly Hashtable mHt;  //使用Hashtable来存储享元对象,充当享元池

        private IgoChessmanFactory()
        {
            mHt = new Hashtable();
            IgochessmanBase black, white;
            black = new BlackIgoChessman();
            mHt.Add("b", black);
            white = new WhiteIgoChessman();
            mHt.Add("w", white);
        }


        //返回享元工厂类的唯一实例
        public static IgoChessmanFactory GetmInstance()
        {
            return mInstance;
        }

        //通过key获取存储在Hashtable中的享元对象
        public IgochessmanBase GetIgochessman(string color)
        {
            return (IgochessmanBase)mHt[color];
        }
    }
}

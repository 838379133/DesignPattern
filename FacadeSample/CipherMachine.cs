﻿using System;
using System.Collections.Generic;
using System.Text;

namespace FacadeSample
{
    class CipherMachine //子系统类，数据加密
    {
        public string Encrypt(string plainText)
        {
            Console.Write("数据加密，将明文转换为密文：");
            string es = "";
            char[] chars = plainText.ToCharArray();
            foreach(char ch in chars)
            {
                string c = (ch % 7).ToString();
                es += c;
            }
            Console.WriteLine(es);
            return es;
        }
    }
}

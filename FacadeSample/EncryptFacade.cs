using System;
using System.Collections.Generic;
using System.Text;

namespace FacadeSample
{
    class EncryptFacade //外观类
    {
        //维持对其他对象的引用 
        private readonly FileReader reader;
        private readonly CipherMachine cipher;
        private readonly FileWriter writer;

        public EncryptFacade()
        {
            reader = new FileReader();
            cipher = new CipherMachine();
            writer = new FileWriter();
        }
        //调用iqta对象的业务方法
        public void FileEncrypt(string fileNameSrc, string fileNameDes)
        {
            string plainStr = reader.Read(fileNameSrc);
            string encryptStr = cipher.Encrypt(plainStr);
            writer.Write(encryptStr, fileNameDes);
        }
    }
}

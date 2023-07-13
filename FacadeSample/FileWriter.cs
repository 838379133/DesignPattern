using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace FacadeSample
{
    class FileWriter //子系统类，文件保存
    {
        public void Write(string encryptStr, string fileNameDes)
        {
            Console.WriteLine("保存密文，写入文件。");
            try
            {
                FileStream fs = new FileStream(fileNameDes, FileMode.Create);
                byte[] str = Encoding.Default.GetBytes(encryptStr);
                fs.Write(str, 0, str.Length);
                fs.Flush();
                fs.Close();
            }
            catch(FileNotFoundException e)
            {
                Console.WriteLine("文件不存在！");
            } 
            catch(IOException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("文件操作错误！");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace FacadeSample
{
    class FileReader //子系统类,文件读取
    {
        public string Read(string fileNameSrc)
        {
            Console.Write("读取文件，获取明文：");
            StringBuilder sb = new StringBuilder();
            try
            {
                FileStream fs = new FileStream(fileNameSrc, FileMode.Open);
                int data;
                while((data  = fs.ReadByte())!= -1)
                {
                    sb = sb.Append((char)data);
                }
                fs.Close();
                Console.WriteLine(sb.ToString());
            }
            catch(FileNotFoundException e)
            {
                Console.WriteLine("文件不存在！");
            }
            catch (IOException)
            {
                Console.WriteLine("文件操作错误！");
            }
            return sb.ToString();
        }
    }
}

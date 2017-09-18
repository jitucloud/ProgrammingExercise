using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateAFile
{
    class Program
    {

        public static void Main()
        {
            string textpath = @"D:\Jitu\dotnet\TechnicaTest\CreateAFile\test.txt";
            using (FileStream fs = File.Create(textpath))
            {
                Byte[] info = new UTF8Encoding(true).GetBytes("File is Created");
                fs.Write(info, 0, info.Length);
            }
            using (StreamReader sr = File.OpenText(textpath))
            {
                string s = "";
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }
            Console.Read();
        }
    }
}

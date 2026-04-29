//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace CSharp
//{
//    internal class Exception_FileNotFound
//    {
//        static void Main(string[] args)
//        {
//            try
//            {
//                //WE declare file in current execution runtime environment : D:\C#_Files\CSharp\CSharp\bin\Debug\resume  
//                string content = File.ReadAllText("resume.txt");
//                Console.WriteLine(content);
//            }
//            catch(FileNotFoundException e)
//            {
//                Console.WriteLine(e.Message);
//            }
//        }
//    }
//}

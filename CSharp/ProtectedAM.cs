//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace CSharp
//{
//    class MyClass
//    {
//        protected int a ; 
//        public void Method1()
//        {
//            Console.WriteLine("Method1 value is : "+a);
//        }
//    }

//    class NewMyclass:MyClass
//    {
//          public NewMyclass()
//        {
//            a = 10;
//        }
        
//        public void Method2()
//        {

//            Console.WriteLine("Method2 valuse is : "+a); 

//        }
//    } 
//    internal class ProtectedAM
//    {
//        static void Main(string[] args)
//        {
//            NewMyclass cls1= new NewMyclass();
//            cls1.Method1();
//            cls1.Method2();    
//        }
//    }
//}

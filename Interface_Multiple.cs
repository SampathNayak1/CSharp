// using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace CSharp
//{
//    interface IphoneBasic
//    {
//        void Calling();
//        void SendMessage();
//        void Receving();
//        void EndCall(); 
//    }
//    class IphoneSE : IphoneBasic
//    {
//        public void Calling() => Console.WriteLine("IPhoneSE is calling");
//        public void SendMessage() => Console.WriteLine("IPhoneSE id Sending Message");
//        public void Receving() => Console.WriteLine("IPhoneSE is Sending");

//        public void EndCall() => Console.WriteLine("IPhone is Ending the call");
//    }

//    interface IphoneAdavance
//    {
//        void FaceID();
//        void VideoCalling();
//        void AirDrop();
//    }
//    class IPhone16 : IphoneBasic, IphoneAdavance
//    {
//        public void Calling() => Console.WriteLine("IPhone16 is calling");
//        public void SendMessage() => Console.WriteLine("IPhone16 is Sending Message");
//        public void Receving() => Console.WriteLine("IPhone16 is Sending"); 
//        public void EndCall() => Console.WriteLine("IPhone16 is Ending the call");
//        public void FaceID() => Console.WriteLine("IPhone16 is doing FaceID  ");
//        public void VideoCalling() => Console.WriteLine("IPhone16 is doing VideoCalling  ");
//        public void AirDrop() => Console.WriteLine("IPhone16 is doing AirDrop  ");

//    }

//    internal class Interface_Multiple
//    {
//        static void Main(string[] args)
//        {
      
//            IphoneBasic obj=new IphoneSE();
//            obj.Calling();
//            obj.SendMessage();
//            obj.Receving();
//            obj.EndCall();
//            obj = new IPhone16();
//            obj.Calling();
//            obj.SendMessage();
//            obj.Receving();
//            obj.EndCall();

//            IphoneAdavance obj2 = new IPhone16();
//            obj2.FaceID();
//            obj2.AirDrop();
//            obj2.VideoCalling();

//        }
//    }
//}

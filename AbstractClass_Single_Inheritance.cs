//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace CSharp
//{
//    abstract class Vechicle
//    {
//        private string vechiclename;
//        public Vechicle(string vechiclename)
//        {
//            this.vechiclename = vechiclename;
//            Console.WriteLine("Vechile is called");
//        } 
//        public void VechileDisplay()
//        {
//            Console.WriteLine($"Vechilename is : {vechiclename}");
//        }
//        public abstract void VachicleType();
//    }

//    abstract class VechileModel : Vechicle
//    {
//        public string modelname;
//        public VechileModel(string vechiclename, string modelname):base(vechiclename)
//        {
//            this.modelname = modelname;
//            Console.WriteLine("Model is called");

//        }
//        public void ModelDisplay()
//        {
//            Console.WriteLine($"Model Name is : {modelname}");
//        }
//        public abstract void ModelType();
//    }
    
//    class VechicleData : VechileModel
//    {
//        public int vechiclenum;
//        public VechicleData(string vechiclename,string modelname, int vechiclenum):base(vechiclename,modelname)
//        {
//            this.vechiclenum = vechiclenum;
//            Console.WriteLine("Vechile Number is called");

//        }
//        public void DispalyVehiclenum()
//        {
//            Console.WriteLine($"Vechicle number is :  {vechiclenum}");
//        }
//        public override void VachicleType()
//        {
//            Console.WriteLine("Cars");   
//        }
//        public override void ModelType()
//        {
//             Console.WriteLine("Electric");
//        }
//    }

//    internal class AbstractClass_Single_Inheritance
//    {
//        static void Main(string[] args)
//        {
//            VechicleData vd=new VechicleData("Audi","A8",9999);
//            vd.VachicleType();
//            vd.ModelType();
//            vd.VechileDisplay();
//            vd.ModelDisplay();
//            vd.DispalyVehiclenum();
            
//        }
//    }
//}

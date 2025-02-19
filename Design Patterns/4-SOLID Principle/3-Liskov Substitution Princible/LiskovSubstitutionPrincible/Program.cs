using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitutionPrincible
{
    //wrong

    public abstract class Cloud
    {
        public abstract void MachineLearning();
        public abstract void Translate();
    }

    public class AWS : Cloud
    {
        public override void MachineLearning()
        {
            Console.WriteLine("using machine learning...");
        }

        public override void Translate()
        {
            Console.WriteLine("translating...");
        }
    }

    public class Google : Cloud
    {
        public override void MachineLearning()
        {
            Console.WriteLine("using machine learning...");
        }

        public override void Translate()
        {
            Console.WriteLine("translating...");
        }
    }

    public class Azure : Cloud
    {
        public override void MachineLearning()
        {
            Console.WriteLine("using machine learning...");
        }

        public override void Translate()
        {
            throw new NotImplementedException();
        }
    }

    //correct 

    public interface ICloudForML
    {
        void MachineLearning();
    }

    public interface ICloudForTranslate
    {
        void Translate();
    }

    public class AWS2 : ICloudForML, ICloudForTranslate
    {
        public  void MachineLearning()
        {
            Console.WriteLine("using machine learning...");
        }

        public  void Translate()
        {
            Console.WriteLine("translating...");
        }
    }

    public class Google2 : ICloudForML, ICloudForTranslate
    {
        public void MachineLearning()
        {
            Console.WriteLine("using machine learning...");
        }

        public void Translate()
        {
            Console.WriteLine("translating...");
        }
    }

    public class Azure2 : ICloudForML
    {
        public void MachineLearning()
        {
            Console.WriteLine("using machine learning...");
        }
    }

}

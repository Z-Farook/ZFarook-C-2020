using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Classes
{
    internal static class ExtensionMethodsClass
    {
        public static void TheExtensionMethPowerOf(this int h) => Console.WriteLine(
            $"{h} to the power of 2 is: {Math.Pow(h, 2)}"
            );
    }

    public class ClassForFinalizer
    {
        readonly Stopwatch sw;

        public ClassForFinalizer()
        {
            sw = Stopwatch.StartNew();
            Console.WriteLine("Instantiated object");
        }

        public void ShowDuration()
        {
            Console.WriteLine("This instance of {0} has been in existence for {1}",
                              this, sw.Elapsed);
        }

        ~ClassForFinalizer()
        {
            Console.WriteLine("Finalizing object");
            sw.Stop();
            Console.WriteLine("This instance of {0} has been in existence for {1}",
                              this, sw.Elapsed);
        }
    }

    public class IdInfo
    {
        public int IdNumber;

        public IdInfo(int IdNumber)
        {
            this.IdNumber = IdNumber;
        }
    }

    public class PersonForClone
    {
        public int Age;
        public string Name;
        public IdInfo IdInfo;

        public PersonForClone ShallowCopy()
        {
            return (PersonForClone)this.MemberwiseClone();
        }

        public PersonForClone DeepCopy()
        {
            PersonForClone other = (PersonForClone)this.MemberwiseClone();
            other.IdInfo = new IdInfo(IdInfo.IdNumber);
            other.Name = String.Copy(Name);
            return other;
        }
    }
}

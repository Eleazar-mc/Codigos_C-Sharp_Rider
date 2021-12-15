using System;

namespace Polimorfismo4
{
    class BaseClass
    {  
        public virtual void Method1()
        {
            Console.WriteLine("Base - Method1");
        }
        public virtual void Method2()  
        {  
            Console.WriteLine("Base - Method2");  
        }
    }  
  
    class DerivedClass : BaseClass
    {  
        public override void Method1()  
        {  
            Console.WriteLine("Derived - Method1");  
        }
        public new void Method2()  
        {  
            Console.WriteLine("Derived - Method2");
        }  
    }  
    class Program
    {
        static void Main()
        {
            BaseClass bc = new BaseClass();
            DerivedClass dc = new DerivedClass();
            BaseClass bcdc = new DerivedClass();
  
            bc.Method1();
            bc.Method2();
            dc.Method1();
            dc.Method2();
            bcdc.Method1();
            bcdc.Method2();
        }
    }
}
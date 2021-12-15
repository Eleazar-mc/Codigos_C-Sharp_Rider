using System;

namespace Polimorfismo3
{
    class BaseClass  
    {  
        public void Method1()  
        {  
            Console.WriteLine("Base - Method1");  
        }  
    }  
  
    class DerivedClass : BaseClass  
    {  
        public void Method2()  
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
            dc.Method1();
            dc.Method2();
            bcdc.Method1();
            ((DerivedClass)bcdc).Method2();
        }
    }
}
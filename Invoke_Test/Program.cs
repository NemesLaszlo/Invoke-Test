using System;
using System.Collections.Generic;
using System.Reflection;
using Invoke_Test2;

namespace Invoke_Test
{
  

 

    public partial class Testing
    {
        public void Test()
        {

            //var valami = AppDomain.CurrentDomain.GetAssemblies()[15];
            
            List<testobj> testlist = new List<testobj>();
            testlist.Add(new testobj("elso"));
            testlist.Add(new testobj("masodik"));
            //var d = Activator.CreateInstance(typeof(TestInvokeClass),true) as TestInvokeClass;
           

            foreach (var item in testlist)
            {
                
                var args = new object[] { item };
                if(args != null)
                {
                   //d.GetType().GetMethod("Writesomething", BindingFlags.NonPublic | BindingFlags.Instance).Invoke(d,args);
                   typeof(TestInvokeClass).GetMethod("Writesomething", BindingFlags.NonPublic | BindingFlags.Instance).Invoke(new Invoke_Test2.TestInvokeClass(), args);
                }
                
                
                
                
            }
        }
}


    class Program
    {


        static void Main(string[] args)
        {
            Testing test = new Testing();
            test.Test();
            Console.ReadKey();
            
        }
    }
}

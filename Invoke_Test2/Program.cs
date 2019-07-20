using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invoke_Test2
{
    public class testobj
    {
        public string name { get; set; }
        public testobj(string name)
        {
            this.name = name;
        }
    }
    internal abstract class Testclass
    {

    }

    class TestInvokeClass : Testclass
    {
        private void Writesomething(testobj obj)
        {
            if (obj.name.Equals("elso"))
            {
                Console.WriteLine("Működik");
            }
        }
    }

    class Program
    {
        static void Main(string[] args) { }
    }
}

using System;
using System.Threading.Tasks;
using ClassLibrary1;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var id = Guid.NewGuid();
            
            Console.WriteLine($"Main: {id.ToByteArray().ToString()}");
            var myObject = new Class1();
            
            var myClass = myObject.MyMethod(id, Guid.NewGuid(), Guid.Empty, "something", "something2", 0, new {}).Result;
//            Console.WriteLine("Hello World!");
        }
    }
}
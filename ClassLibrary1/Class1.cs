using System;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Class1
    {
        public async Task<bool> MyMethod(Guid someId, Guid anotherId, Guid oneMoreID, string something, string whatever, int num = 0, dynamic foo = default(dynamic))
        {
            Console.WriteLine($"MyMethod: {PrintByteArray(someId.ToByteArray())}"); 
            Console.WriteLine($"MyMethod Second Guid: {anotherId.ToString()}");
            
            return (await this.MyOtherMethod(someId, anotherId, oneMoreID, something, whatever, num, foo) == 1);
        }

        public Task<int> MyOtherMethod(Guid thatId, Guid anotherId, Guid oneMoreId, string something, string whatever, int num, dynamic foo = default(dynamic))
        {
            Console.WriteLine($"MyOtherMethod: {PrintByteArray(thatId.ToByteArray())}");
            Console.WriteLine($"MyOtherMethod Second Guid: {anotherId.ToString()}");

            return Task.FromResult(1);
        }

        private static string PrintByteArray(byte[] ba)
        {
            var sb = new StringBuilder(ba.Length * 2);
            foreach (var b in ba)
            {
                sb.AppendFormat("{0:x2}", b);
            }

            return sb.ToString();
        }
    }
}
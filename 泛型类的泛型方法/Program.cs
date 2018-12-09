using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 泛型类的泛型方法
{
    class Program
    {
        static void Main(string[] args)
        {
            TestFangFa<string> t1 = new TestFangFa<string>();
            t1.Bigger("hans","good");

            TestFangFa<int> t2 = new TestFangFa<int>();
            t2.Bigger(123,888);

            Console.ReadLine();
        }
    }

    public class TestFangFa<T> where T:IComparable
    {
        public void Bigger(T a ,T b)
        {
            Console.WriteLine($"A是  {a}");
            Console.WriteLine($"B是  {b}");
            Console.WriteLine();
        }
    }
}

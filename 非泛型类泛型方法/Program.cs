using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 非泛型类泛型方法
{
    /// <summary>
    /// 非泛型类的泛型方法
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Big b1 = new Big();
            b1.Biggest(3, 2);


            Big b2 = new Big();
            b2.Biggest("hello","hans");

            Console.ReadLine();
        }
    }
    public class Big
    {
        public void Biggest<T>(T a,T b) where T:IComparable   //where  后面的是 泛型约束。 指的是传进来的类型 必须实现了 IComparable接口
        {
            if (a.CompareTo(b) > 0)     ///两个T 类型的比较时,用到
            {
                Console.WriteLine($"最大值是{a}");
            }
            else
                Console.WriteLine($"最大值是{b}");
        }
    }
}

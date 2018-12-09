using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 泛型委托
{
    class Program
    {
        //1.定义委托类型   2个参数，无返回值
        public delegate void Mydelegate<T>( T  a, T b);
        static void Main(string[] args)
        {
            //3.实例化一个委托
            Mydelegate<int> m1 = new Mydelegate<int>(Fangfa);
            m1(10,100);

            Console.ReadLine();
        }


        //2定义方法
        static void Fangfa<T>(T a,T b)
        {
            T temp = a;
            a = b;
            b = temp;

            Console.WriteLine($"交换后的a :{a}");
            Console.WriteLine($"交换后的b : {b}");
        }
    }
}

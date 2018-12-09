using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 泛型方法2个参数
{
    class Program
    {
        static void Main(string[] args)
        {
            Test t1 = new Test();
            t1.Hello("杨先生 年龄",12);
            Console.ReadLine();
        }
    }

    public class Test
    {
        public void Hello<T ,U  >(T a,U b)
        {
            Console.WriteLine(a);
            Console.WriteLine(b);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 泛型接口2
{
    class Program
    {
        static void Main(string[] args)
        {
            //AAA a1 = new AAA();
            //a1.SayHello("比尔盖茨");
            //string result = a1.SayHi();
            //Console.WriteLine($"你说啥,{result}");
         


            BBB<string> b1 = new BBB<string>();
            b1.SayHello("乔布斯");
            Console.ReadLine();
        }
    }


    //先定义一个接口
    public  interface IFace<T>
    {
        T SayHi();
        void SayHello(T msg);
    }

    //普通类实现 泛型接口
    public class AAA : IFace<string>
    {
        public void SayHello(string msg)
        {
            Console.WriteLine($"Hello,{msg}");
        }

        public string SayHi()
        {
            return "hi hi hi ";
        }
    }

    //泛型类实现 泛型方法，更加灵魂
    public class BBB<T> : IFace<T>
    {
        public void SayHello(T msg)
        {
            Console.WriteLine($"Hello {msg}");
        }

        public T SayHi()
        {
            throw new NotImplementedException();
        }
    }
}

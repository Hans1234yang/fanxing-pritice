using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 泛型csdn1
{
    class Program
    {
        static void Main(string[] args)
        {
            AAA a1 = new AAA();
            a1.Show("微软牛逼");

            BBB<string> b1 = new BBB<string>();
            b1.Show("美团，滴滴也不错");
            Console.ReadLine();
        }
    }
    //定义泛型接口
    interface Inter<T>
    {
        void Show(T t);
    }

    //在类中实现泛型接口的两个方法
    //(1) 直接在 类后面加泛型
    //(2) 在类实现 接口方法中 给出具体类型

    public class AAA : Inter<string>
    {
        public void Show(string t)
        {
            Console.WriteLine($"显示 {t}");
        }
    }

    public class BBB<T> : Inter<T>
    {
        public void Show(T t)
        {
            Console.WriteLine($"显示{t}");
        }
    }
}

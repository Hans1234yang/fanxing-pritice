using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 泛型7
{
    class Program
    {
        static void Main(string[] args)
        {
            TypeA<int>.filed = "一";
            TypeA<string>.filed = "二";
            TypeA<Guid>.filed = "三";

            NoGeneric.filed = "非泛型类静态字段一";
            NoGeneric.filed = "非泛型类静态字段二";
            NoGeneric.filed = "非泛型类静态字段三";

            NoGeneric.OutFiled();
            TypeA<int>.output();
            TypeA<string>.output();
            TypeA<Guid>.output();

           Console.ReadLine();
        }
    }

    //泛型类   每个封闭类型，都有一个 静态字段
    public static class TypeA<T>
    {
        public static string filed;
        public static void output()
        {
            Console.WriteLine(filed+":"+typeof(T).Name);
        }
    }

    //非泛型类
    public static class NoGeneric
    {
        public static string filed;
        public static void OutFiled()
        {
            Console.WriteLine(filed);
        }
    }


}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 泛型6
{
    class Program
    {


        static void Main(string[] args)
         {
            object o = null;

            //Dictionary 是个开放类型 2个参数，开放类型
            Type t = typeof(Dictionary<,>);

            // 失败
            o = CreateInstance(t);

            //也是DictionaryStringKey开放类型，只有一个类型参数
            t = typeof(DictionaryStringKey<>);

            //失败
            o = CreateInstance(t);

            //封闭类型 
            t = typeof(DictionaryStringKey<int>);

            o = CreateInstance(t);
            Console.WriteLine("对象类型="+o.GetType());
            Console.ReadLine();

        }

        //创建类型
        private static object CreateInstance(Type t)
        {
            object o = null;
            try
            {
                //指定类型t 的默认构造函数 来创建该 类型的实例
                o = Activator.CreateInstance(t);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return o;
        }
    }

    //声明开房泛型类型
    public sealed class DictionaryStringKey<T>  :Dictionary<string,T>
            {
            }
}

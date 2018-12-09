using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 泛型5
{
    class Program
    {
      

        static void Main(string[] args)
        {
            Console.WriteLine(Compare<int>.CompareGeneric(3,4));
            Console.WriteLine(Compare<string>.CompareGeneric("abc","a"));
            Console.ReadLine();
        }
    }
    public class  Compare
    {
        //返回两个整数中数据大的那一项
        public static int CompareInt(int int1,int int2)
        {
            if(int1.CompareTo(int2)>0)
            {
                return int1;
            }
            return int2;
        }

        //返回字符串中,大的一项 
        public  static string CompareString(string s1,string s2)
        {
            if(s1.CompareTo(s2)>0)
            {
                return s1;
            }
            return s2;
        }
    }

    public class Compare<T> where T : IComparable   //Icomparable 是值类型的通用比较接口
    {
        //T 是返回 类型 和参数的类型 

        public static T CompareGeneric(T t1 ,T t2)
        {
            if(t1.CompareTo(t2)>0)
            {
                return t1;
            }
            return t2;
        }
    }

}

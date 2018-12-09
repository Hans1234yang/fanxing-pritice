using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 泛型接口
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonManager man = new PersonManager();
            Person p1 = new Person("Hans");
            man.PrintName(p1);

            Person p2 = new Person("杨先生");

            man.SwaPerson(ref p1, ref p2);
            man.PrintName(p1);
            man.PrintName(p2);
            Console.ReadLine();
        }
    }

    interface IPerson<T>
    {
        void PrintName(T t);
    }
   

    class PersonManager : IPerson<Person>
    {
        public void PrintName(Person t)
        {
            Console.WriteLine($"我的名字是{t.name}");
        }

        //交换两个人的姓名。 泛型方法的目的是 参数和返回类型
        public void SwaPerson<T>(ref T p1,ref T p2)
        {
            T temp = default(T);
            temp = p1;
            p1 = p2;
            p2 = temp;
        }

    }

    public class Person
    {
        public string name;
        public Person(string _name)
        {
            name = _name;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 泛型类
{
    class Program
    {
        static void Main(string[] args)
        {
            Message<string> m1 = new Message<string>
            {
                name="hans",
                hobby="象棋"
            };
            m1.Show();
            Console.ReadLine();
        }
    }

    public class Message<T>
    {
        public T name { get; set; }
        public T hobby { get; set; }

        public void Show()
        {
            Console.WriteLine($"{this.name},{this.hobby}");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_world
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program();
        }

        public Program()
        {
            Console.WriteLine("Hello world...");
            DoSomething("YEY");
            Console.ReadKey();
        }

        public int DoSomething(string text)
        {
            int value = 0;

            if (text != null)
                value = text.GetHashCode();

            return value;
        }
    }
}

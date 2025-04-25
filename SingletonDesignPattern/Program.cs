using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SingletonDesignPattern
{
    

    class Program
    {
        static void Main(string[] args)
        {
            Parallel.Invoke(First, Second);
        }

        private static void Second()
        {
            Console.WriteLine("Second thread started.");
            Singleton singleton2 = Singleton.Instance;
            singleton2.SomeMethod("Second");
        }

        private static void First()
        {
            Singleton singleton1 = Singleton.Instance;
            Console.WriteLine("First thread started.");
            singleton1.SomeMethod("First");
        }
    }
}

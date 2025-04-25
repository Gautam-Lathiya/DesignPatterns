using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDesignPattern
{
    public sealed class Singleton
    {
        public static readonly Lazy<Singleton> instance = new Lazy<Singleton>(() => new Singleton());
        // Private constructor to prevent instantiation from outside
        private Singleton()
        {
            Console.WriteLine("Singleton instance created.");
        }
        // Public method to provide access to the instance
        public static Singleton Instance
        {
            get
            {
                return instance.Value;
            }
        }
        public void SomeMethod(string msg)
        {
            Console.WriteLine("Message : " + msg);
        }
    }
}

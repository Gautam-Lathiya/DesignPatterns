using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;

namespace SingletonDesignPattern
{
    class SingletonUsingUnity
    {
        public void Display()
        {
            Console.WriteLine("Singleton using Unity");
        }
    }

    class UnitySingletonTest
    {
        static void Main(string[] args)
        {
            // Create a Unity container
            var container = new Unity.UnityContainer();

            // Register the singleton type
            container.RegisterSingleton<SingletonUsingUnity>();

            // Resolve the singleton instance
            var singletonInstance1 = container.Resolve<SingletonUsingUnity>();
            var singletonInstance2 = container.Resolve<SingletonUsingUnity>();

            // Check if both instances are the same
            Console.WriteLine(object.ReferenceEquals(singletonInstance1, singletonInstance2)); // True

            // Call the display method
            singletonInstance1.Display();
        }
    }
}

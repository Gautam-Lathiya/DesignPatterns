using MediatorDesignPattern.Colleagues;
using MediatorDesignPattern.Mediators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IMediator facebookMediator = new Mediator();

            //Create instances of Colleague i.e. Creating users
            IUser Ram = new User("Ram");
            IUser Dave = new User("Dave");
            IUser Smith = new User("Smith");
            IUser Rajesh = new User("Rajesh");
            IUser Sam = new User("Sam");
            IUser Pam = new User("Pam");
            IUser Anurag = new User("Anurag");
            IUser John = new User("John");

            //Registering the users with the Mediator i.e. Facebook Group
            facebookMediator.RegisterUser(Ram);
            facebookMediator.RegisterUser(Dave);
            facebookMediator.RegisterUser(Smith);
            facebookMediator.RegisterUser(Rajesh);
            facebookMediator.RegisterUser(Sam);
            facebookMediator.RegisterUser(Pam);
            facebookMediator.RegisterUser(Anurag);
            facebookMediator.RegisterUser(John);

            //One of the users Sending one Message in the Facebook Group
            Dave.Send("dotnettutorials.net - this website is very good to learn Design Pattern");

            Console.WriteLine();

            //Another user Sending another Message in the Facebook Group
            Rajesh.Send("What is Design Patterns? Please explain ");

            Console.Read();
        }
    }
}

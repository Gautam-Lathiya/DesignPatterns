using MediatorDesignPattern.Mediators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorDesignPattern.Colleagues
{
    // Colleague
    // This is going to be an abstract class that defines a property that holds a reference to a mediator.    
    public abstract class IUser
    {
        //This Property holds the name of the user
        protected string Name;
        //This Property is going to set and get the Mediator Instance
        //This Property value is going to be set when we register a user with the Mediator
        public IMediator Mediator { get; set; }

        //Initializing the name using Constructor
        public IUser(string name)
        {
            this.Name = name;
        }
        //The following Methods are going to be Implemented by the Concrete Colleague
        public abstract void Send(string message);
        public abstract void Receive(string message);
    }
}

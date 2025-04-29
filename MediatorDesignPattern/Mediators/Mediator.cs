using MediatorDesignPattern.Colleagues;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorDesignPattern.Mediators
{
    // Concrete Mediator
    // This is going to be a class implementing the communication operations of the Mediator Interface.
    public class Mediator : IMediator
    {
        //The following variable is going to hold the list of objects to whom we want to communicate
        private List<IUser> usersList = new List<IUser>();
        //The following method simply registers the IUser with Mediator
        public void RegisterUser(IUser user)
        {
            //Adding the User
            usersList.Add(user);
            //Registering the User with Mediator
            user.Mediator = this;
        }
        //The following method is going to send the message in the group i.e. to the group IUsers
        public void SendMessage(string message, IUser user)
        {
            foreach (IUser u in usersList)
            {
                //Message should not be received by the IUser sending it
                if (u != user)
                {
                    u.Receive(message);
                }
            }
        }
    }
}

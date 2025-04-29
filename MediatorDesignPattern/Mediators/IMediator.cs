using MediatorDesignPattern.Colleagues;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorDesignPattern.Mediators
{
    public interface IMediator
    {
        //This Method is used to send the Message who are registered with the Facebook Group
        void SendMessage(string msg, IUser user);
        //This method is used to register a user with the Facebook Group
        void RegisterUser(IUser user);
    }
}

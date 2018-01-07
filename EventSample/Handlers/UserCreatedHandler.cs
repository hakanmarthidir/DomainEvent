using EventSample.Events;
using EventSample.SharedKernel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventSample.Handlers
{
    public class UserCreatedHandler : IHandle<UserCreated>
    {
        public void Handle(UserCreated args)
        {
            Console.WriteLine("UserCreatedHandler...");
        }
    }
}

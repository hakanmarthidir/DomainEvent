using EventSample.Domain;
using EventSample.SharedKernel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventSample.Events
{
    public class UserCreated : IDomainEvent
    {
        public User NewUser { get; set; }
        public DateTime DateOccurred { get; private set; }

        public UserCreated(User newUser, DateTime dateCreated)
        {
            this.NewUser = newUser;
            this.DateOccurred = dateCreated;
            Console.WriteLine("UserCreated Event!");
        }

        public UserCreated(User appointment) : this(appointment, DateTime.Now)
        {
        }
    }
}

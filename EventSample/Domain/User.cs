using EventSample.Events;
using EventSample.SharedKernel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventSample.Domain
{
    public class User : IEntity
    {
        public Guid Id { get; private set; }
        public string EmailAddress { get; private set; }
        public string Password { get; set; }

        protected User() : this(Guid.NewGuid())
        {
        }

        public User(Guid id)
        {
            this.Id = id;
        }

        public static User Create(string emailAddress, string password)
        {
            Console.WriteLine("Domain...");
            var user = new User();
            user.EmailAddress = emailAddress;
            user.Password = password;
            DomainEvents.Raise<UserCreated>(new UserCreated(user));
            return user;
        }       

    }
}

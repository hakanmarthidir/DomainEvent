using EventSample.Domain;
using EventSample.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventSample.Application
{
    public class UserService : IUserService
    {
        private IRepository<User> _userRepository;
        public UserService(IRepository<User> userRepository)
        {
            _userRepository = userRepository;
        }

        public void UserCreate(string email, string password)
        {
            Console.WriteLine("UserService UserCreate!");
            var newUser = User.Create(email,password);
            _userRepository.Save(newUser);
        }
    }
}

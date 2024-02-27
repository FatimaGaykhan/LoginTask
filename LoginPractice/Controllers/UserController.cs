using LoginPractice.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginPractice.Controllers
{
    internal class UserController
    {
        public readonly UserService userService;
        public UserController()
        {
                userService = new UserService();
        }

        public void GetAll()
        {
            var result = userService.GetAll();

            foreach (var item in result)
            {
                Console.WriteLine(item.id + " " + item.fullName+" "+item.email);
            }
        }

        public void GetUserById()
        {
            var users=userService.GetAll();
            int id = int.Parse(Console.ReadLine());
            var result = userService.GetUserById(users, id);
            foreach (var item in result)
            {
                Console.WriteLine(item.id+" "+item.fullName);
            }

        }
    }
}

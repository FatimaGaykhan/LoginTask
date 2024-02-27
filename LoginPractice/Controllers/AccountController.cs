using LoginPractice.Models;
using LoginPractice.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginPractice.Controllers
{
    internal class AccountController:User
    {
        public readonly AccountService accountService;
        public readonly UserService userService;
        public AccountController()
        {
                accountService= new AccountService();
                userService= new UserService();
        }

        public void Login()
        {
            User[] users =userService.GetAll();
            Console.WriteLine("Please Enter Email:");
            string email=Console.ReadLine();
            Console.WriteLine("Please Enter Password:");
            string password =Console.ReadLine();
            var result = accountService.Login(users, email, password);
            Console.WriteLine(  result);
        }
    }
}

using LoginPractice.Helpers;
using LoginPractice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginPractice.Services
{
    internal class AccountService:UserService
    {
        ResponseMessage responseMessage=new ResponseMessage();
        public string Login(User[] users,string email,string password)
        {
            bool result=Array.Exists(users,m=>m.email==email&&m.password==password);
            //string result= users.Where(m => m.email == email && m.password == password).ToString();

            if (result==true)
            {
                return responseMessage.success ;
            }
            else
            {
                return responseMessage.wrong;
            }
        }

    }
}

using LoginPractice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginPractice.Services
{
    internal class UserService:User
    {
        public User[] GetAll()
        {
            UserService user1 = new()
            {
                id = 1,
                fullName = "Fatima Gaykhanova",
                age = 22,
                email = "fatimaeg@code.edu.az",
                password = "Fatima123"

            };
            UserService user2 = new()
            {
                id = 2,
                fullName = "Sadigkhan Gaykhanov",
                age = 26,
                email = "sadigkhaneg@code.edu.az",
                password = "Sadigkhan123"

            };
            UserService user3 = new()
            {
                id = 3,
                fullName = " User Userov",
                age = 35,
                email = "usereg@code.edu.az",
                password = "User123"

            };
            UserService user4 = new()
            {
                id = 4,
                fullName = "Gunel Valiyeva",
                age = 22,
                email = "gunelev@code.edu.az",
                password = "Gunel123"

            };


            User[] users = { user1, user2, user3, user4};
            return users;
        }

        public User[] GetUserById(User[] users, int id)
        {
            return users.Where(m=>m.id==id).ToArray();

        }
    }
}

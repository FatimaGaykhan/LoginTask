using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginPractice.Models
{
    internal class User:BaseEntity
    {
        public string fullName;
        public int age;
        public string email;
        public string password;
    }
}

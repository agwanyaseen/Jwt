using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TechnorexNotes.Shared
{
    public class User
    {
        public string UserName { get; set; }

        public string UserPassword { get; set; }
    }

    public class UserDetails
    {
        private readonly string username;
        private readonly string userpassword;
        public UserDetails(string username, string userpassowrd)
        {
            this.username = username;
            this.userpassword = userpassowrd;
        }

        public string ValidateUser()
        {
            List<User> users = new List<User>
            {
                new User()
                {
                    UserName = "yaseen",
                    UserPassword ="123"
                },
                new User()
                {
                    UserName="nisara",
                    UserPassword="123"
                }
            };

            var user = users.FirstOrDefault(x => x.UserName == this.username &&
                                    x.UserPassword == this.userpassword);
            if(user == null)
            {
                return null;
            }

            return JwtTokenGenerator.GenerateToken(user);
        }
    }
}

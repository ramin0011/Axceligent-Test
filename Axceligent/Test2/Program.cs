using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2
{
    class Program
    {
        private static void Main(string[] args)
        {
            while (true)
            {
                var user = new User();
                Console.WriteLine("please enter the username, or q to exit");
                var userName = Console.ReadLine();
                if (userName == "q")
                {
                    break;
                }

                user.Add(userName);
                Console.WriteLine($"number of addedUser {user.GetUsersCount()}");
            }
        }

    }

    public class User
    {
        private static List<User> usernames=new List<User>();
        public User()
        {
            
        }
        private string UserName { get; set; }
        private User(string username)
        {
            this.UserName = username;
        }
        public void Add(string userName)
        {
            usernames.Add(new User(userName));
        }
        public int GetUsersCount()
        {
            return usernames.Count;
        }
    }
}

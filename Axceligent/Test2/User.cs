using System.Collections.Generic;

namespace Test2
{
    public class User
    {
        private static List<User> _users=new List<User>();
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
            _users.Add(new User(userName));
        }
        public int GetUsersCount()
        {
            return _users.Count;
        }
    }
}
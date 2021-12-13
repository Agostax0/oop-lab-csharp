using System;

namespace Collections
{
    public class User : IUser
    {
        public User(string fullName, string username, uint? age)
        {
            if(fullName == null)
            {
                throw new ArgumentNullException("age");
            }
            Age=age;
            FullName=fullName;
            Username=username;
        }
        
        public uint? Age { get; }
        
        public string FullName { get; }
        
        public string Username { get; }

        public bool IsAgeDefined => Age == null ? throw new ArgumentNullException("age") : return true;
        
        // TODO implement missing methods (try to autonomously figure out which are the necessary methods)
    }
}

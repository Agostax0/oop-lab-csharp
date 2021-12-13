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

        public bool IsAgeDefined => Age!=null;

        // TODO implement missing methods (try to autonomously figure out which are the necessary methods)
        public bool Equals(User user)
        {
            if (user is null)
            {
                throw new ArgumentNullException(nameof(user));
            }

            return this.Age == user.Age &&
                   this.Username == user.Username &&
                   this.FullName == user.FullName;
        }

        public override bool Equals(object obj)
        {
            if(ReferenceEquals(obj,null)) return false;
            if(ReferenceEquals(obj,this)) return true;
            if(obj.GetType() != this.GetType()) return false;
            return Equals((User)obj);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Username,FullName,Age);
        }
        public override string ToString()
        {
            return "{" + this.FullName + "} " + "{" + this.Username + "}" + " {" + this.Age + "} ";
        }
    }

}

using System;
using System.Collections.Generic;

namespace Collections
{
    public class SocialNetworkUser<TUser> : User, ISocialNetworkUser<TUser>
        where TUser : IUser
    {
        private Dictionary<string,List<TUser>> _followed = new Dictionary<string,List<TUser>>();
        
        public SocialNetworkUser(string fullName, string username, uint? age) : base(fullName, username, age)
        {

            
            //throw new NotImplementedException("TODO is there anything to do here?");

        }



        public bool AddFollowedUser(string group,TUser user)
        {
            if (_followed.ContainsKey(group) && this._followed[group].Contains(user))
            {
                    return false;
            }
            else 
            {
                if (!(_followed.ContainsKey(group)))
                {
                    _followed[group] = new List<TUser>();
                    _followed[group].Add(user); 
                }
                return true;
            }

        }

        public IList<TUser> FollowedUsers
        {
            
            get
            {
                var followers = new List<TUser>();
                foreach(var group in _followed.Values)
                {
                    foreach(var user in group)
                    {
                        followers.Add(user);
                    }
                }
                return followers;
            }
        }

        public ICollection<TUser> GetFollowedUsersInGroup(string group)
        {
            if (_followed.ContainsKey(group))
            {
                return _followed[group];
            }
            return new List<TUser>();    //throw new NotImplementedException("TODO construct and return a collection containing of all users followed by the current users, in group");
        }
    }
}

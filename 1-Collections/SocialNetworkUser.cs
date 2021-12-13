using System;
using System.Collections.Generic;

namespace Collections
{
    public class SocialNetworkUser<TUser> : User, ISocialNetworkUser<TUser>
        where TUser : IUser
    {
        Dictionary<string,TUser> followed = Dictionary<string,TUser>();
        
        public SocialNetworkUser(string fullName, string username, uint? age) : base(fullName, username, age)
        {

            
            //throw new NotImplementedException("TODO is there anything to do here?");

        }


        public bool AddFollowedUser(string group,TUser user) => followed.TryAdd(group,user);

        public IList<TUser> FollowedUsers
        {
            
            get
            {
                List<TUser> followers = new List<TUser>(followed.Values);
                //throw new NotImplementedException("TODO construct and return the list of all users followed by the current users, in all groups");
            }
        }

        public ICollection<TUser> GetFollowedUsersInGroup(string group)
        {
            return new CollectionExtensions = followed.key;
            //throw new NotImplementedException("TODO construct and return a collection containing of all users followed by the current users, in group");
        }
    }
}

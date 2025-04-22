using LocalDbPractice.DAL;
using LocalDbPractice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalDbPractice.BL
{
    public class UserBL
    {
        public List<User> GetActiveUsersList(DatabaseEntities de)
        {
            return new UserDAL().GetActiveUsersList(de);
        }

        public User GetUserById(int id, DatabaseEntities de)
        {
            return new UserDAL().GetUserById(id, de);
        }
        
        public User GetUserByLogin(string email, string password, DatabaseEntities de)
        {
            return new UserDAL().GetUserByLogin(email, password, de);
        }
        
        public User GetUserByEmail(string email, DatabaseEntities de)
        {
            return new UserDAL().GetUserByEmail(email, de);
        }

        public bool AddUser(User user, DatabaseEntities de)
        {
            if (string.IsNullOrEmpty(user.Name) || string.IsNullOrEmpty(user.Email) || string.IsNullOrEmpty(user.Password))
            {
                return false;
            }
            else
            {
                return new UserDAL().AddUser(user, de);
            }
        }

        public bool UpdateUser(User user, DatabaseEntities de)
        {
            if (string.IsNullOrEmpty(user.Name) || string.IsNullOrEmpty(user.Email) || string.IsNullOrEmpty(user.Password))
            {
                return false;
            }
            else
            {
                return new UserDAL().UpdateUser(user, de);
            }
        }

        public bool DeactivateUser(int id, DatabaseEntities de)
        {
            return new UserDAL().DeactivateUser(id, de);
        }

        public bool DeleteUser(int id, DatabaseEntities de)
        {
            return new UserDAL().DeleteUser(id, de);
        }
        
        public bool ValidateUser(string email, int id, DatabaseEntities de)
        {
            return new UserDAL().ValidateUser(email, id, de);
        }

    }
}

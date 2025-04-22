using LocalDbPractice.Models;
using System.Collections.Generic;
using System.Linq;

namespace LocalDbPractice.DAL
{
    public class UserDAL
    {
        public List<User> GetActiveUsersList(DatabaseEntities de)
        {
            return de.Users.Where(x => x.IsActive == 1).ToList();
        }

        public User GetUserByLogin(string email, string password, DatabaseEntities de)
        {
            return de.Users.FirstOrDefault(x => x.IsActive == 1 && x.Email.ToLower() == email.Trim().ToLower() &&
            x.Password == password.Trim());
        }

        public User GetUserById(int id, DatabaseEntities de)
        {
            return de.Users.Where(x => x.Id == id).FirstOrDefault(x => x.IsActive == 1);
        }
        
        public User GetUserByEmail(string email, DatabaseEntities de)
        {
            return de.Users.FirstOrDefault(x => x.IsActive == 1 && x.Email.ToLower() == email.Trim().ToLower());
        }

        public bool AddUser(User user, DatabaseEntities de)
        {
            try
            {
                de.Users.Add(user);
                de.SaveChanges();

                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool UpdateUser(User user, DatabaseEntities de)
        {
            try
            {
                de.Entry(user).State = System.Data.Entity.EntityState.Modified;
                de.SaveChanges();

                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool DeactivateUser(int id, DatabaseEntities de)
        {
            try
            {
                User u = GetUserById(id, de);
                u.IsActive = 0;

                return UpdateUser(u, de);
            }
            catch
            {
                return false;
            }
        }

        public bool DeleteUser(int id, DatabaseEntities de)
        {
            try
            {
                de.Users.Remove(de.Users.Where(x => x.Id == id).FirstOrDefault());
                de.SaveChanges();

                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool ValidateUser(string email, int id, DatabaseEntities de)
        {
            int userCount = 0;
            if(id != -1)
            {
                userCount = de.Users.Count(x => x.IsActive == 1 && x.Id != id && x.Email.ToLower() == email.Trim().ToLower());
            }
            else
            {
                userCount = de.Users.Count(x => x.IsActive == 1 && x.Email.ToLower() == email.Trim().ToLower());
            }

            return userCount == 0;
        }

    }
}

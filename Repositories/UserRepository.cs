using BusinessObjects.Models;
using DataAccessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class UserRepository : IUserRepository
    {

        public User CheckLogin(string username, string password) => UserDAO.Instance.CheckLogin(username, password);

        public List<User> GetUsers()
        => UserDAO.Instance.GetUsers();

        //If including a sub entity
        //public List<subUser> GetsubUsers()
        //=> UserDAO.Instance.GetsubUsers();

        public User GetUserById(int id)
        => UserDAO.Instance.GetUserById(id);

        public void DeleteUser(User o)
        => UserDAO.Instance.DeleteUser(o);

        public void UpdateUser(User o)
        => UserDAO.Instance.UpdateUser(o);

        public void SaveUser(User o)
        => UserDAO.Instance.SaveUser(o);
    }
}

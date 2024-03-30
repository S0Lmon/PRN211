using BusinessObjects.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface IUserRepository
    {

        User CheckLogin(string username, string password);

        List<User> GetUsers();

        //If including a sub entity
        //List<subUser> GetsubUsers();

        User GetUserById(int id);

        void DeleteUser(User o);

        void UpdateUser(User o);

        void SaveUser(User o);
    }
}

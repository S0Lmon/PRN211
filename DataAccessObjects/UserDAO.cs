using BusinessObjects.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObjects
{
    public class UserDAO
    {

        private static User currentUser = null;
        private static UserDAO instance = null;
        private static object lockObject = new object();
        public UserDAO() { }
        public static UserDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new UserDAO();
                }
                return instance;
            }
        }


        //Use Shift + Alt + . to replace User to another correct object
        public User CheckLogin(string username, string password)
        {
            using var db = new RurestaurantReservationSystemContext();
            currentUser = db.Users.SingleOrDefault(m => m.Username.Equals(username) && m.Password.Equals(password));
            return currentUser;
        }


        //Use Shift + Alt + . to replace User and RurestaurantReservationSystemContext to another correct object

        //GetAll
        public List<User> GetUsers()
        {
            using var db = new RurestaurantReservationSystemContext();
            //If including a sub entity
            //return db. Users.Include(f=>f.Supplier).ToList();
            //If not including a sub entity 
            return db.Users.ToList();
        }

        //If including a sub entity
        //public List<subUser> GetsubUsers(){
        //    using var db = new RurestaurantReservationSystemContext();
        //    return db.subUsers.ToList();
        //}

        //GetById
        public User GetUserById(int? id)
        {
            var temp = GetUsers().SingleOrDefault(m => m.UserId == id);
            return temp;
        }


        //Create and Save
        public void SaveUser(User o)
        {
            using var db = new RurestaurantReservationSystemContext();
            db.Users.Add(o);
            db.SaveChanges();
        }

        //Update
        public void UpdateUser(User o)
        {
            using var db = new RurestaurantReservationSystemContext();
            db.Users.Update(o);
            db.SaveChanges();
        }

        public void DeleteUser(User o)
        {
            using var db = new RurestaurantReservationSystemContext();
            var o1 = db.Users.SingleOrDefault(m => m.UserId == o.UserId);
            db.Users.Remove(o1);
            db.SaveChanges();
        }

    }
}

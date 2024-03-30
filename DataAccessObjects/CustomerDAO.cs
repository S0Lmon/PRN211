using BusinessObjects.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObjects
{
    public class CustomerDAO
    {


        private static CustomerDAO instance = null;
        private static object lockObject = new object();
        public CustomerDAO() { }
        public static CustomerDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new CustomerDAO();
                }
                return instance;
            }
        }


        //Use Shift + Alt + . to replace Customer and RurestaurantReservationSystemContext to another correct object

        //GetAll
        public List<Customer> GetCustomers()
        {
            using var db = new RurestaurantReservationSystemContext();
            //If including a sub entity
            //return db. Customers.Include(f=>f.Supplier).ToList();
            //If not including a sub entity 
            return db.Customers.ToList();
        }

        //If including a sub entity
        //public List<subCustomer> GetsubCustomers(){
        //    using var db = new RurestaurantReservationSystemContext();
        //    return db.subCustomers.ToList();
        //}

        //GetById
        public Customer GetCustomerById(int? id)
        {
            var temp = GetCustomers().SingleOrDefault(m => m.CustomerId == id);
            return temp;
        }


        //Create and Save
        public void SaveCustomer(Customer o)
        {
            using var db = new RurestaurantReservationSystemContext();
            db.Customers.Add(o);
            db.SaveChanges();
        }

        //Update
        public void UpdateCustomer(Customer o)
        {
            using var db = new RurestaurantReservationSystemContext();
            db.Customers.Update(o);
            db.SaveChanges();
        }

        public void DeleteCustomer(Customer o)
        {
            using var db = new RurestaurantReservationSystemContext();
            var o1 = db.Customers.SingleOrDefault(m => m.CustomerId == o.CustomerId);
            db.Customers.Remove(o1);
            db.SaveChanges();
        }
    }
}

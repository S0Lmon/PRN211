using BusinessObjects.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObjects
{
    public class OrderDetailDAO
    {


        private static OrderDetailDAO instance = null;
        private static object lockObject = new object();
        public OrderDetailDAO() { }
        public static OrderDetailDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new OrderDetailDAO();
                }
                return instance;
            }
        }


        //Use Shift + Alt + . to replace OrderDetail and RurestaurantReservationSystemContext to another correct object

        //GetAll
        public List<OrderDetail> GetOrderDetails()
        {
            using var db = new RurestaurantReservationSystemContext();
            //If including a sub entity
            //return db. OrderDetails.Include(f=>f.Supplier).ToList();
            //If not including a sub entity 
            return db.OrderDetails.ToList();
        }

        //If including a sub entity
        //public List<subOrderDetail> GetsubOrderDetails(){
        //    using var db = new RurestaurantReservationSystemContext();
        //    return db.subOrderDetails.ToList();
        //}

 


        //Create and Save
        public void SaveOrderDetail(OrderDetail o)
        {
            using var db = new RurestaurantReservationSystemContext();
            db.OrderDetails.Add(o);
            db.SaveChanges();
        }

        //Update
        public void UpdateOrderDetail(OrderDetail o)
        {
            using var db = new RurestaurantReservationSystemContext();
            db.OrderDetails.Update(o);
            db.SaveChanges();
        }


    }
}

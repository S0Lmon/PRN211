using BusinessObjects.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObjects
{
    public class OrderDAO
    {


        private static OrderDAO instance = null;
        private static object lockObject = new object();
        public OrderDAO() { }
        public static OrderDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new OrderDAO();
                }
                return instance;
            }
        }


        //Use Shift + Alt + . to replace Order and RurestaurantReservationSystemContext to another correct object

        //GetAll
        public List<Order> GetOrders()
        {
            using var db = new RurestaurantReservationSystemContext();
            //If including a sub entity
            //return db. Orders.Include(f=>f.Supplier).ToList();
            //If not including a sub entity 
            return db.Orders.ToList();
        }

        //If including a sub entity
        //public List<subOrder> GetsubOrders(){
        //    using var db = new RurestaurantReservationSystemContext();
        //    return db.subOrders.ToList();
        //}

        //GetById
        public Order GetOrderById(int? id)
        {
            var temp = GetOrders().SingleOrDefault(m => m.OrderId == id);
            return temp;
        }


        //Create and Save
        public void SaveOrder(Order o)
        {
            using var db = new RurestaurantReservationSystemContext();
            db.Orders.Add(o);
            db.SaveChanges();
        }

        //Update
        public void UpdateOrder(Order o)
        {
            using var db = new RurestaurantReservationSystemContext();
            db.Orders.Update(o);
            db.SaveChanges();
        }

        public void DeleteOrder(Order o)
        {
            using var db = new RurestaurantReservationSystemContext();
            var o1 = db.Orders.SingleOrDefault(m => m.OrderId == o.OrderId);
            db.Orders.Remove(o1);
            db.SaveChanges();
        }
    }
}

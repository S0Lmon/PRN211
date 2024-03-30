using BusinessObjects.Models;
using DataAccessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class OrderRepository : IOrderRepository
    {

        //Remeber: 1. Change Repository form private to public
        //         2. Implement Interface

        public List<Order> GetOrders()
        => OrderDAO.Instance.GetOrders();

        //If including a sub entity
        //public List<subOrder> GetsubOrders()
        //=> OrderDAO.Instance.GetsubOrders();

        public Order GetOrderById(int id)
        => OrderDAO.Instance.GetOrderById(id);

        public void DeleteOrder(Order o)
        => OrderDAO.Instance.DeleteOrder(o);

        public void UpdateOrder(Order o)
        => OrderDAO.Instance.UpdateOrder(o);

        public void SaveOrder(Order o)
        => OrderDAO.Instance.SaveOrder(o);
    }
}

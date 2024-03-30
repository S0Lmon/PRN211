using BusinessObjects.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface IOrderRepository
    {

        //Remeber to change interface form private to public

        List<Order> GetOrders();

        //If including a sub entity
        //List<subOrder> GetsubOrders();

        Order GetOrderById(int id);

        void DeleteOrder(Order o);

        void UpdateOrder(Order o);

        void SaveOrder(Order o);
    }
}

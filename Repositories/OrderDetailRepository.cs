using BusinessObjects.Models;
using DataAccessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class OrderDetailRepository : IOrderDetailRepository
    {


        //Remeber: 1. Change Repository form private to public
        //         2. Implement Interface

        public List<OrderDetail> GetOrderDetails()
        => OrderDetailDAO.Instance.GetOrderDetails();

        //If including a sub entity
        //public List<subOrderDetail> GetsubOrderDetails()
        //=> OrderDetailDAO.Instance.GetsubOrderDetails();


        public void UpdateOrderDetail(OrderDetail o)
        => OrderDetailDAO.Instance.UpdateOrderDetail(o);

        public void SaveOrderDetail(OrderDetail o)
        => OrderDetailDAO.Instance.SaveOrderDetail(o);
    }
}

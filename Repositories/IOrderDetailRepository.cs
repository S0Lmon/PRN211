using BusinessObjects.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface IOrderDetailRepository
    {
        //Remeber to change interface form private to public

        List<OrderDetail> GetOrderDetails();

        //If including a sub entity
        //List<subOrderDetail> GetsubOrderDetails();

        void UpdateOrderDetail(OrderDetail o);

        void SaveOrderDetail(OrderDetail o);
    }
}

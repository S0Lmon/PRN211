using BusinessObjects.Models;
using DataAccessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class BillRepository : IBillRepository
    {

        //Remeber: 1. Change Repository form private to public
        //         2. Implement Interface

        public List<Bill> GetBills()
        => BillDAO.Instance.GetBills();

        //If including a sub entity
        //public List<subBill> GetsubBills()
        //=> BillDAO.Instance.GetsubBills();

        public Bill GetBillById(int id)
        => BillDAO.Instance.GetBillById(id);

        public void DeleteBill(Bill o)
        => BillDAO.Instance.DeleteBill(o);

        public void UpdateBill(Bill o)
        => BillDAO.Instance.UpdateBill(o);

        public void SaveBill(Bill o)
        => BillDAO.Instance.SaveBill(o);
    }
}

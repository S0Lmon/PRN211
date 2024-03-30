using BusinessObjects.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface IBillRepository
    {

        //Remeber to change interface form private to public

        List<Bill> GetBills();

        //If including a sub entity
        //List<subBill> GetsubBills();

        Bill GetBillById(int id);

        void DeleteBill(Bill o);

        void UpdateBill(Bill o);

        void SaveBill(Bill o);
    }
}

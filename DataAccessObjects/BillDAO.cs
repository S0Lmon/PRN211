using BusinessObjects.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObjects
{
    public class BillDAO
    {
        private static BillDAO instance = null;
        private static object lockObject = new object();
        public BillDAO() { }
        public static BillDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BillDAO();
                }
                return instance;
            }
        }


        //Use Shift + Alt + . to replace Bill and RurestaurantReservationSystemContext to another correct object

        //GetAll
        public List<Bill> GetBills()
        {
            using var db = new RurestaurantReservationSystemContext();
            //If including a sub entity
            //return db. Bills.Include(f=>f.Supplier).ToList();
            //If not including a sub entity 
            return db.Bills.ToList();
        }

        //If including a sub entity
        //public List<subBill> GetsubBills(){
        //    using var db = new RurestaurantReservationSystemContext();
        //    return db.subBills.ToList();
        //}

        //GetById
        public Bill GetBillById(int? id)
        {
            var temp = GetBills().SingleOrDefault(m => m.BillId == id);
            return temp;
        }


        //Create and Save
        public void SaveBill(Bill o)
        {
            using var db = new RurestaurantReservationSystemContext();
            db.Bills.Add(o);
            db.SaveChanges();
        }

        //Update
        public void UpdateBill(Bill o)
        {
            using var db = new RurestaurantReservationSystemContext();
            db.Bills.Update(o);
            db.SaveChanges();
        }

        public void DeleteBill(Bill o)
        {
            using var db = new RurestaurantReservationSystemContext();
            var o1 = db.Bills.SingleOrDefault(m => m.BillId == o.BillId);
            db.Bills.Remove(o1);
            db.SaveChanges();
        }
    }
}

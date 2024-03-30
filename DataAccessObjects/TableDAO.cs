using BusinessObjects.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObjects
{
    public class TableDAO
    {


        private static TableDAO instance = null;
        private static object lockObject = new object();
        public TableDAO() { }
        public static TableDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new TableDAO();
                }
                return instance;
            }
        }


        //Use Shift + Alt + . to replace Table and RurestaurantReservationSystemContext to another correct object

        //GetAll
        public List<Table> GetTables()
        {
            using var db = new RurestaurantReservationSystemContext();
            //If including a sub entity
            //return db. Tables.Include(f=>f.Supplier).ToList();
            //If not including a sub entity 
            return db.Tables.ToList();
        }

        //If including a sub entity
        //public List<subTable> GetsubTables(){
        //    using var db = new RurestaurantReservationSystemContext();
        //    return db.subTables.ToList();
        //}

        //GetById
        public Table GetTableById(int? id)
        {
            var temp = GetTables().SingleOrDefault(m => m.TableId == id);
            return temp;
        }


        //Create and Save
        public void SaveTable(Table o)
        {
            using var db = new RurestaurantReservationSystemContext();
            db.Tables.Add(o);
            db.SaveChanges();
        }

        //Update
        public void UpdateTable(Table o)
        {
            using var db = new RurestaurantReservationSystemContext();
            db.Tables.Update(o);
            db.SaveChanges();
        }

        public void DeleteTable(Table o)
        {
            using var db = new RurestaurantReservationSystemContext();
            var o1 = db.Tables.SingleOrDefault(m => m.TableId == o.TableId);
            db.Tables.Remove(o1);
            db.SaveChanges();
        }
    }
}

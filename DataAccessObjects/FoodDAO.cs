using BusinessObjects.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObjects
{
    public class FoodDAO
    {


        private static FoodDAO instance = null;
        private static object lockObject = new object();
        public FoodDAO() { }
        public static FoodDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new FoodDAO();
                }
                return instance;
            }
        }


        //Use Shift + Alt + . to replace Food and RurestaurantReservationSystemContext to another correct object

        //GetAll
        public List<Food> GetFoods()
        {
            using var db = new RurestaurantReservationSystemContext();
            //If including a sub entity
            //return db. Foods.Include(f=>f.Supplier).ToList();
            //If not including a sub entity 
            return db.Foods.ToList();
        }

        //If including a sub entity
        //public List<subFood> GetsubFoods(){
        //    using var db = new RurestaurantReservationSystemContext();
        //    return db.subFoods.ToList();
        //}

        //GetById
        public Food GetFoodById(int? id)
        {
            var temp = GetFoods().SingleOrDefault(m => m.FoodId == id);
            return temp;
        }


        //Create and Save
        public void SaveFood(Food o)
        {
            using var db = new RurestaurantReservationSystemContext();
            db.Foods.Add(o);
            db.SaveChanges();
        }

        //Update
        public void UpdateFood(Food o)
        {
            using var db = new RurestaurantReservationSystemContext();
            db.Foods.Update(o);
            db.SaveChanges();
        }

        public void DeleteFood(Food o)
        {
            using var db = new RurestaurantReservationSystemContext();
            var o1 = db.Foods.SingleOrDefault(m => m.FoodId == o.FoodId);
            db.Foods.Remove(o1);
            db.SaveChanges();
        }
    }
}

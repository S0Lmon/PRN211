using BusinessObjects.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObjects
{
    public class CategoryDAO
    {


        private static CategoryDAO instance = null;
        private static object lockObject = new object();
        public CategoryDAO() { }
        public static CategoryDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new CategoryDAO();
                }
                return instance;
            }
        }


        //Use Shift + Alt + . to replace Category and RurestaurantReservationSystemContext to another correct object

        //GetAll
        public List<Category> GetCategories()
        {
            using var db = new RurestaurantReservationSystemContext();
            //If including a sub entity
            //return db. Categories.Include(f=>f.Supplier).ToList();
            //If not including a sub entity 
            return db.Categories.ToList();
        }

        //If including a sub entity
        //public List<subCategory> GetsubCategories(){
        //    using var db = new RurestaurantReservationSystemContext();
        //    return db.subCategories.ToList();
        //}

        //GetById
        public Category GetCategoryById(int? id)
        {
            var temp = GetCategories().SingleOrDefault(m => m.CategoryId == id);
            return temp;
        }


        //Create and Save
        public void SaveCategory(Category o)
        {
            using var db = new RurestaurantReservationSystemContext();
            db.Categories.Add(o);
            db.SaveChanges();
        }

        //Update
        public void UpdateCategory(Category o)
        {
            using var db = new RurestaurantReservationSystemContext();
            db.Categories.Update(o);
            db.SaveChanges();
        }

        public void DeleteCategory(Category o)
        {
            using var db = new RurestaurantReservationSystemContext();
            var o1 = db.Categories.SingleOrDefault(m => m.CategoryId == o.CategoryId);
            db.Categories.Remove(o1);
            db.SaveChanges();
        }
    }
}

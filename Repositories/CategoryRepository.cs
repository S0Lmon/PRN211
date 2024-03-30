using BusinessObjects.Models;
using DataAccessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class CategoryRepository : ICategoryRepository
    {


        //Remeber: 1. Change Repository form private to public
        //         2. Implement Interface

        public List<Category> GetCategories()
        => CategoryDAO.Instance.GetCategories();

        //If including a sub entity
        //public List<subCategory> GetsubCategories()
        //=> CategoryDAO.Instance.GetsubCategories();

        public Category GetCategoryById(int id)
        => CategoryDAO.Instance.GetCategoryById(id);

        public void DeleteCategory(Category o)
        => CategoryDAO.Instance.DeleteCategory(o);

        public void UpdateCategory(Category o)
        => CategoryDAO.Instance.UpdateCategory(o);

        public void SaveCategory(Category o)
        => CategoryDAO.Instance.SaveCategory(o);
    }
}

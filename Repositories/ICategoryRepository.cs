using BusinessObjects.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface ICategoryRepository
    {

        //Remeber to change interface form private to public

        List<Category> GetCategories();

        //If including a sub entity
        //List<subCategory> GetsubCategories();

        Category GetCategoryById(int id);

        void DeleteCategory(Category o);

        void UpdateCategory(Category o);

        void SaveCategory(Category o);
    }
}

using BusinessObjects.Models;
using DataAccessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class FoodRepository : IFoodRepository
    {

        //Remeber: 1. Change Repository form private to public
        //         2. Implement Interface

        public List<Food> GetFoods()
        => FoodDAO.Instance.GetFoods();

        //If including a sub entity
        //public List<subFood> GetsubFoods()
        //=> FoodDAO.Instance.GetsubFoods();

        public Food GetFoodById(int id)
        => FoodDAO.Instance.GetFoodById(id);

        public void DeleteFood(Food o)
        => FoodDAO.Instance.DeleteFood(o);

        public void UpdateFood(Food o)
        => FoodDAO.Instance.UpdateFood(o);

        public void SaveFood(Food o)
        => FoodDAO.Instance.SaveFood(o);
    }
}

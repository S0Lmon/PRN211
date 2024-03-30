using BusinessObjects.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface IFoodRepository
    {

        //Remeber to change interface form private to public

        List<Food> GetFoods();

        //If including a sub entity
        //List<subFood> GetsubFoods();

        Food GetFoodById(int id);

        void DeleteFood(Food o);

        void UpdateFood(Food o);

        void SaveFood(Food o);
    }
}

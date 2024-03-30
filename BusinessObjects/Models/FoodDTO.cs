using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects.Models
{
    public partial class FoodDTO
    {
        public int FoodId { get; set; }
        public string FoodName { get; set; }
        public int quantity { get; set; }

        public override bool Equals(object? obj)
        {
            return obj is FoodDTO dTO &&
                   FoodId == dTO.FoodId;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(FoodId);
        }
    }
}

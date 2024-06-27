using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG6221PART3
{
     public class recipe
    {
        public string RecipeID { get; set; }    
        public string RecipeName { get; set; }
        public string ingedients  { get; set; }
        public string foodGroup { get; set; }
      public string calories { get; set; }
        public string steps { get; set; }

        public override string ToString()
        {
            return $"RecipeID: {RecipeID}\nRecipeName: {RecipeName}\nIngredients: {ingedients}\nFoodGroup: {foodGroup}\nCalories: {calories}\nSteps:{steps}\n";
        }
    }
}

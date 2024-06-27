using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.DirectoryServices;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace PROG6221PART3
{
    /// <summary>
    /// Interaction logic for SearchWindow.xaml
    /// </summary>
    public partial class SearchWindow : Window
    {
        private ObservableCollection<recipe> recipes;
        public SearchWindow()
        {
            InitializeComponent();
        }

        // new constructor  that accepts the recipe collection 
        public SearchWindow(ObservableCollection<recipe> recipeCollection) : this()
        {
            // Initialize the recipe collection
            recipes = recipeCollection;

            // Display the recipes
            txbResult.Text = string.Join("\n\n", recipes.Select(r => r.ToString()));
        }



        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            string searchText = txbSearch.Text.ToLower();

            // find the recipe with the matching id
            var searchRecipe = recipes.FirstOrDefault(r => r.RecipeID.ToLower() == searchText || r.RecipeName.ToLower() == searchText || r.foodGroup.ToLower()== searchText  ||r.calories.ToLower() == searchText);

            if (searchRecipe != null)
            {
                //display recipe details 
                txbResult.Text = searchRecipe.ToString();
            }

            else {
                // clear the details in the text block if on match is found
                txbResult.Text = "No recipe with the matching ID was found";

            }
            txbSearch.Clear();

            


        }

        private void btnShowAll_Click(object sender, RoutedEventArgs e)
        {
            // display all the books 
            txbResult.Text= string.Join("\n\n", recipes.Select(r => r.ToString()));

        }
    }
}

using System.Collections.ObjectModel;
using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PROG6221PART3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ObservableCollection<recipe> recipes=new ObservableCollection<recipe>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void AddRecipe_Click(object sender, RoutedEventArgs e)
        {
            var recipe = new recipe
            {
               
                RecipeName = txbRecipeName.Text,
                ingedients = txbIgredients.Text,
                foodGroup = txbFoodGroup.Text,
                calories  = txbCalories.Text,
                RecipeID = txbRecipeID.Text,
                steps = txbSteps.Text,


            };

            // recipe to collection 
            recipes.Add(recipe);

           

            txbCalories.Clear();
            txbFoodGroup.Clear();
            txbSteps.Clear();
            txbRecipeName.Clear();
            txbRecipeID.Clear();
            txbIgredients.Clear();
            txbRecipeID.Clear();
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            txbCalories.Clear();
            txbFoodGroup.Clear();
            txbSteps.Clear();
            txbRecipeName.Clear();  
            txbRecipeID.Clear();    
            txbIgredients.Clear();
            txbRecipeID.Clear();
            
        }

        private void btnViewRecipres_Click(object sender, RoutedEventArgs e)
        {
             // create and show recipe window 
            SearchWindow viewRecipeWindow =    new SearchWindow(recipes);
            viewRecipeWindow.Show();
        }
    }
}
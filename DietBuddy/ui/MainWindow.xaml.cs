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
using System.Xml.Serialization;

namespace DietBuddy
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private UserInformation user;
        public MainWindow()
        {
            InitializeComponent();
            user = new UserInformation("", 0, 0.0);
        }
        private void GetMeal_Click(object sender, RoutedEventArgs e)
        {
            // Logic to get dish details
            // This is a placeholder for the actual implementation
            MessageBox.Show("Get Dish button clicked!");
        }
        private void AddDish_Click(object sender, RoutedEventArgs e)
        {
            // Logic to add a new dish
            // This is a placeholder for the actual implementation
            MessageBox.Show("Add Dish button clicked!");
        }
        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            // Logic to handle login
            // This is a placeholder for the actual implementation
            if (string.IsNullOrWhiteSpace(username.Text) || string.IsNullOrWhiteSpace(user_age.Text) || string.IsNullOrEmpty(user_weight.Text))
            {
                MessageBox.Show("Input Error.");
                
                return;
            }
            user = new UserInformation(username.Text, int.Parse(user_age.Text), double.Parse(user_weight.Text));
            Page.Visibility = Visibility.Collapsed;
            ChooseDishPage.Visibility = Visibility.Visible;
        }
        private void ChooseDishButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("choosing...");
        }
        
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    };
}
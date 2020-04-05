using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Time_Travel
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        CountryData db = new CountryData(); //My custom world countries database I created
        List<Country> allCountries = new List<Country>();
        List<Country> selectedCountries = new List<Country>();
        List<Country> visitedCountries = new List<Country>();
     
        public MainWindow()
        {
            InitializeComponent();
        }

        //Massive region containing all country lists
        #region Countries List
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
           world_filter_combo.Items.Add("Europe");
           world_filter_combo.Items.Add("Asia");
           world_filter_combo.Items.Add("Africa");
           world_filter_combo.Items.Add("Oceana");
           world_filter_combo.Items.Add("Latin America and Carribean");
           world_filter_combo.Items.Add("North America");
           world_filter_combo.Items.Add("South America");

            //Display the countries
            var country = from c in db.WorldCountry
                        select c.CountryID;

            list_bx_world_countries.ItemsSource = country.ToList();
            sortCountries(); //Sorts the names of the countries.
        }
        #endregion        
        //##########################
        //##########################
        #region ListBoxes

        //Add countries to the bucket list from all countries list
        private void bucket_add_Click(object sender, RoutedEventArgs e)
        {
            Country selectedCountry = list_bx_world_countries.SelectedItem as Country; //Grabbing the selected item

            //Making sure something is selected
            if (selectedCountry != null)
            {
                //Moves country to the other list
                allCountries.Remove(selectedCountry);
                selectedCountries.Add(selectedCountry);
                sortCountries();
                RefreshScreens();
            }

            if (selectedCountry == null)
            {
                MessageBox.Show("Please select an country to add to bucketlist!", "Attention!");
            }
        }



        //Add countries back to the all countries from the bucket
        private void bucket_remove_Click(object sender, RoutedEventArgs e)
        {
            Country selectedCountry = list_bx_world_bucket.SelectedItem as Country; //Grabbing the selected item

            //Making sure something is selected
            if (selectedCountry != null)
            {
                //Moves country to the other list
                selectedCountries.Remove(selectedCountry);
                allCountries.Add(selectedCountry);
                sortCountries();
                RefreshScreens();
            }

            if (selectedCountry == null)
            {
                MessageBox.Show("Please select an country to remove from bucketlist!", "Attention!");
            }
        }

        //Add countrys to the countries you have visited list
        private void bucket_visited_Click(object sender, RoutedEventArgs e)
        {

            Country selectedCountry = list_bx_world_bucket.SelectedItem as Country; //Grabbing the selected item

            //Making sure something is selected
            if (selectedCountry != null)
            {
                //Moves country to the other list
                selectedCountries.Remove(selectedCountry);
                visitedCountries.Add(selectedCountry);
                sortCountries();
                RefreshScreens();
            }

            if (selectedCountry == null)
            {
                MessageBox.Show("Please select a country you have visited!", "Attention!");
            }
        }

        //The method below refreshes the countries and bucket screen
        private void RefreshScreens()
        {
            list_bx_world_countries.ItemsSource = null;
            list_bx_world_countries.ItemsSource = allCountries;

            list_bx_world_bucket.ItemsSource = null;
            list_bx_world_bucket.ItemsSource = selectedCountries;

            list_bx_world_visited.ItemsSource = null;
            list_bx_world_visited.ItemsSource = visitedCountries;
        }
        #endregion

        //##########################
        private void world_filter_combo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
           
        }

        //##########################

        //Region for all of the smaller methods that don't quite fit in another region
        #region Small Methods
        //Sorts the countries method
        private void sortCountries()
        { 
            allCountries.Sort();
        }
        #endregion

        private void countries_search_TextChanged(object sender, TextChangedEventArgs e)
        {
        }
    }
}
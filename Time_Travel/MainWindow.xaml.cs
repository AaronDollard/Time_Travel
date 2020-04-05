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
            world_filter_combo.ItemsSource = Enum.GetNames(typeof(Country.Zone));//populates the combobox with the enum

            
            var country = from c in db.WorldCountry //Display the countries
                          select c.CountryID;

            list_bx_world_countries.ItemsSource = country.ToList(); //sortCountries(); //Sorts the names of the countries.

        }
        #endregion        
        //##########################
        //##########################

        #region ListBoxes
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
        } //Add countries to the bucket list from all countries list


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
        } //Add countries back to the all countries from the bucket


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
        } //Add countries to the countries you have visited list


        private void RefreshScreens() //The method below refreshes the countries and bucket screen
        {
            //list_bx_world_countries.ItemsSource = null;
            //list_bx_world_countries.ItemsSource = allCountries;

            //list_bx_world_bucket.ItemsSource = null;
            //list_bx_world_bucket.ItemsSource = selectedCountries;

            //list_bx_world_visited.ItemsSource = null;
            //list_bx_world_visited.ItemsSource = visitedCountries;
        }
        #endregion

        private void world_filter_combo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var query = from c in db.WorldCountry
                          select c.CountryID;

            string selected = world_filter_combo.SelectedItem.ToString();


            switch (selected)
            {

                case "Europe":
                    query = from p in db.WorldCountry
                            orderby p.CountryZone
                            select p.CountryID;
                    break;

                case "Asia":
                    break;

                case "Africa":
                    break;
                
                            case "Oceana":
                    break;

                            case "Latin America and Carribean":
                    break;

                            case "North America":
                    break;

                            case "South America":
                    break;
        }
            //Update items list
            list_bx_world_countries.ItemsSource = query.ToList();

        }
        
        private void sortCountries() //Sorts the countries method
        { 
            allCountries.Sort();
        }
    }
}
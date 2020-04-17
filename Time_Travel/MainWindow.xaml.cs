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
using System.Data.SqlClient; //for the wildcard search
using Microsoft.VisualBasic; //Used for pop up menu

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
 
        private void Window_Loaded(object sender, RoutedEventArgs e) //Massive region containing all country lists
        {
            world_filter_combo.SelectedIndex = 0; //Sets the default item in the box as "all"
            world_filter_combo.ItemsSource = Enum.GetNames(typeof(Zone));//Populates the combobox
            var country = from c in db.WorldCountry //Display the countries
                          select c.CountryID;

            list_bx_world_countries.ItemsSource = country.ToList(); //sortCountries(); //Sorts the names of the countries.
        }

        #region Filtering Countries and Sorting
        private void RefreshScreens() //The method below refreshes the countries and bucket screen
        {
            //list_bx_world_countries.ItemsSource = null;
            //list_bx_world_countries.ItemsSource = allCountries;

            //list_bx_world_bucket.ItemsSource = null;
            //list_bx_world_bucket.ItemsSource = selectedCountries;

            //list_bx_world_visited.ItemsSource = null;
            //list_bx_world_visited.ItemsSource = visitedCountries;
        }
        private void world_filter_combo_SelectionChanged(object sender, SelectionChangedEventArgs e) //Filter for the combobox zones
        {
            
            var query = from c in db.WorldCountry
                          select c.CountryID;
            
            string selected = world_filter_combo.SelectedItem as string;

            switch (selected)
            {
                case "All":
                    var country = from c in db.WorldCountry
                                  select c.CountryID;
                    break;

                case "Europe":
                    query = from p in db.WorldCountry
                            where p.CountryZone.Equals("Europe")
                            select p.CountryID;
                    break;

                case "Asia":
                    query = from p in db.WorldCountry
                            where p.CountryZone.Equals("Asia")
                            select p.CountryID;
                    break;

                case "Africa":
                    query = from p in db.WorldCountry
                            where p.CountryZone.Equals("Africa")
                            select p.CountryID;
                    break;

                case "Oceania":
                    query = from p in db.WorldCountry
                            where p.CountryZone.Equals("Oceania")
                            select p.CountryID;
                    break;

                case "Latin_America_and_Carribean":
                    query = from p in db.WorldCountry
                            where p.CountryZone.Equals("Latin_America_and_Carribean")
                            select p.CountryID;
                    break;

                case "North_America":
                    query = from p in db.WorldCountry
                            where p.CountryZone.Equals("North_America")
                            select p.CountryID;
                    break;

                case "South_America":
                    query = from p in db.WorldCountry
                            where p.CountryZone.Equals("South_America")
                            select p.CountryID;
                    break;
            }
        
        list_bx_world_countries.ItemsSource = query.ToList(); //Update items list

        }
        private void sortCountries() //Sorts the countries method
        { 
            allCountries.Sort();
        }
        public enum Zone { All, Africa, Asia, Europe, Latin_America_and_Carribean, Oceania, North_America } //Enum for the combobox
        private void countries_search_TextChanged(object sender, TextChangedEventArgs e) //Used for the search bar function to filter countries only in the selected zone. 
        {                                                                                //One if acts as the all selection while the other filters it by zone
            string selectedfilter = world_filter_combo.SelectedItem as string;           
            if (selectedfilter == "All")
            {
                var query = from o in db.WorldCountry
                            where o.CountryID.StartsWith(countries_search.Text)
                            select o.CountryID;
                list_bx_world_countries.ItemsSource = query.ToList();
            }
            else
            {
                var query = from o in db.WorldCountry
                            where o.CountryID.StartsWith(countries_search.Text) && o.CountryZone.Equals(selectedfilter)
                            select o.CountryID;
                list_bx_world_countries.ItemsSource = query.ToList();
            }
            
        }
        #endregion

        #region Buttons & Clicking Events
        private void github_link_Click(object sender, RoutedEventArgs e) //Click to go to my Github
        {
            System.Diagnostics.Process.Start("https://github.com/AaronDollard/Time_Travel");
        }
        private void bucket_edit_Click(object sender, RoutedEventArgs e) //used when clicked on the button to edit the explored tab
        {
            string input = Interaction.InputBox("Enter the name of the country you visited?", "Country", "Country Name", -1, -1);
            txtBlk_notes.Text = input;
        }
        private void bucket_visited_Click(object sender, RoutedEventArgs e)//Adding countries you visited to the second tab
        {
            if (list_bx_world_bucket.SelectedIndex != -1)
            {
                list_bx_world_visited.Items.Add(list_bx_world_bucket.SelectedValue);
                list_bx_world_bucket.Items.Remove(list_bx_world_bucket.SelectedValue);
            }
            
            else
            {
                MessageBox.Show("Please select a country you've visited!", "Attention!");
            }
        }
        private void bucket_add_Click(object sender, RoutedEventArgs e) //Add countries to the bucket list from all countries list
        {
            if (string.IsNullOrEmpty(country_visited_input.Text))
            {
                MessageBox.Show("Please enter a country to add to bucketlist!", "Attention!");
            }
            else
            {
                list_bx_world_bucket.Items.Add(country_visited_input.Text);
                country_visited_input.Clear();
                country_visited_input.Focus();
            }
        }
        private void bucket_remove_Click(object sender, RoutedEventArgs e) //Add countries back to the all countries from the bucket
        {
            if (list_bx_world_bucket.Items.Count > 0)
            {
                list_bx_world_bucket.Items.RemoveAt(list_bx_world_bucket.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Please select an country to remove!", "Attention!");
            }
        }
        #endregion

        /*private void bucket_visited_Click(object sender, RoutedEventArgs e)
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
       } //Add countries to the countries you have visited list*/ //Unused button.
        
    }
}
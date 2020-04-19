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
        List<Country> allCountries = new List<Country>(); //List of countries to reference spelling in the main tab
        List<countryVisited> visited = new List<countryVisited>();
        public int visitedCounter = 0;

        public MainWindow()
        {
            InitializeComponent();
            RefreshScreens();
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
            countryVisited selectedVisited = list_bx_world_visited.SelectedItem as countryVisited;
            var dateAndTime = DateTime.Now; //Getting the date and time
            if (selectedVisited != null)
            {
                if (selectedVisited.countryNotes == "Custom notes on countries you wish visit will be shown here")
                {
                    selectedVisited.countryNotes = null;
                    string input = Interaction.InputBox("Enter notes about your visit to this country?", "Notes", "", -1, -1);
                    string note = "Notes: " + input + "\nDated: " + dateAndTime + "\nTime Visited: " + visitedCounter + "\n\n";
                    selectedVisited.countryNotes = note;
                }

                else
                {
                    string input = Interaction.InputBox("Enter notes about your visit to this country?", "Notes", "", -1, -1);
                    string appendednote = "Notes: " + input + "\nDated: " + dateAndTime + "\nTime Visited: " + visitedCounter + "\n\n";
                    selectedVisited.countryNotes = selectedVisited.countryNotes + appendednote;
                }
            }
            else
            {
                MessageBox.Show("Please add a country you've visited to add notes!", "Attention!");
            }
        }

        #region Date & Time
        private void bucket_visited_Click(object sender, RoutedEventArgs e)//Adding countries you visited to the second tab
        {
            var dateVisited = DateTime.Now; //gets the date for when the button is clicked below

            if (list_bx_world_bucket.SelectedIndex != -1)
            {
                list_bx_world_visited.Items.Add(list_bx_world_bucket.SelectedValue);

                list_bx_travel_history.Items.Add(list_bx_world_bucket.SelectedValue + " - Visited: " + dateVisited.ToString("dd/MM/yyyy"));
                list_bx_world_bucket.Items.Remove(list_bx_world_bucket.SelectedValue);
            }
            
            else
            {
                MessageBox.Show("Please select a country you've visited!", "Attention!");
            }
        }
        #endregion //Working with dates and time

        private void bucket_add_Click(object sender, RoutedEventArgs e) //Add countries to the bucket list from text box input
        {
            string countryName = country_visited_input.Text;
            if (string.IsNullOrEmpty(country_visited_input.Text))
            {
                MessageBox.Show("Please enter a country to add to bucketlist!", "Attention!");
            }
            else
            {
                visitedCounter = +1;
                countryVisited visted = new countryVisited(countryName, "Custom notes on countries you wish visit will be shown here", 0);
                list_bx_world_bucket.Items.Add(visted);
                country_visited_input.Clear();
                country_visited_input.Focus();
            }
        }
        #endregion

        #region Exception handling
        private void bucket_remove_Click(object sender, RoutedEventArgs e) //Add countries back to the all countries from the bucket WITH example of exception handing and prevention
        {
            //Below his try catch prevents the application from crashing. If it is removed and you have items in the bucket list and click remove without selecting something
            //within the bucket list, the application will crash. Comment out the try catch to see the application crash.
            try
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
            catch
            {
                MessageBox.Show("This is an example of exception handling. If you see this the program should have crashed but try/catch block caught it.", "Exception handling!");
            }
        }

        private void list_bx_world_visited_SelectionChanged(object sender, SelectionChangedEventArgs e) //displays the notes for each country visited when selected in the list
        {
            countryVisited selectedVisited = list_bx_world_visited.SelectedItem as countryVisited;

            if (selectedVisited != null)
            {
                txtBlk_notes.Text = selectedVisited.countryNotes;
            }
            else
            {
                MessageBox.Show("Please add a country you've visited to add notes!", "Attention!");
            }
        }

        private void clear_Click(object sender, RoutedEventArgs e) //Clear all content in the boxes
        {
            string input = Interaction.InputBox("Are you sure you wish to delete travel history? Type YES or NO below. This CANNOT be undone", "WARNING", "", -1, -1);

            while (input != "YES" && input != "NO")
            {
                input = Interaction.InputBox("Are you sure you wish to delete travel history? Type YES or NO below. This CANNOT be undone", "WARNING", "", -1, -1);

                if (input == "YES")
                {
                    list_bx_travel_history.Items.Clear();
                    list_bx_world_visited.Items.Clear();
                    MessageBox.Show("Travel history has been cleared", "Attention!");
                }
                else if (input == "NO")
                {
                    MessageBox.Show("Clearing aborted", "Aborted!");
                }
                else
                {
                    MessageBox.Show("Invalid reply. Type YES or NO", "Invalid!");
                }
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
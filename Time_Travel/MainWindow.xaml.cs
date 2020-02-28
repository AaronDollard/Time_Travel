﻿using System;
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
            Country africa1 = new AfricanCountry("Nigeria", Country.Zone.Africa);
            Country africa2 = new AfricanCountry("Ethiopia", Country.Zone.Africa);
            Country africa3 = new AfricanCountry("Egypt", Country.Zone.Africa);
            Country africa4 = new AfricanCountry("Democratic Republic Of Congo", Country.Zone.Africa);
            Country africa5 = new AfricanCountry("Tanzania", Country.Zone.Africa);
            Country africa6 = new AfricanCountry("South Africa", Country.Zone.Africa);
            Country africa7 = new AfricanCountry("Kenya", Country.Zone.Africa);
            Country africa8 = new AfricanCountry("Uganda", Country.Zone.Africa);
            Country africa9 = new AfricanCountry("Algeria", Country.Zone.Africa);
            Country africa10 = new AfricanCountry("Sudan", Country.Zone.Africa);
            Country africa11 = new AfricanCountry("Morocco", Country.Zone.Africa);
            Country africa12 = new AfricanCountry("Angola", Country.Zone.Africa);
            Country africa13 = new AfricanCountry("Mozambique", Country.Zone.Africa);
            Country africa14 = new AfricanCountry("Ghana", Country.Zone.Africa);
            Country africa15 = new AfricanCountry("Madagascar", Country.Zone.Africa);
            Country africa16 = new AfricanCountry("Cameroon", Country.Zone.Africa);
            Country africa17 = new AfricanCountry("Côte d'Ivoire", Country.Zone.Africa);
            Country africa18 = new AfricanCountry("Niger", Country.Zone.Africa);
            Country africa19 = new AfricanCountry("Burkina Faso", Country.Zone.Africa);
            Country africa20 = new AfricanCountry("Mali", Country.Zone.Africa);
            Country africa21 = new AfricanCountry("Malawi", Country.Zone.Africa);
            Country africa22 = new AfricanCountry("Zambia", Country.Zone.Africa);
            Country africa23 = new AfricanCountry("Senegal", Country.Zone.Africa);
            Country africa24 = new AfricanCountry("Chad", Country.Zone.Africa);
            Country africa25 = new AfricanCountry("Somalia", Country.Zone.Africa);
            Country africa26 = new AfricanCountry("Zimbabwe", Country.Zone.Africa);
            Country africa27 = new AfricanCountry("Guinea", Country.Zone.Africa);
            Country africa28 = new AfricanCountry("Rwanda", Country.Zone.Africa);
            Country africa29 = new AfricanCountry("Benin", Country.Zone.Africa);
            Country africa30 = new AfricanCountry("Burundi", Country.Zone.Africa);
            Country africa31 = new AfricanCountry("Tunisia", Country.Zone.Africa);
            Country africa32 = new AfricanCountry("South Sudan", Country.Zone.Africa);
            Country africa33 = new AfricanCountry("Togo", Country.Zone.Africa);
            Country africa34 = new AfricanCountry("Sierra Leone", Country.Zone.Africa);
            Country africa35 = new AfricanCountry("Libya", Country.Zone.Africa);
            Country africa36 = new AfricanCountry("Congo", Country.Zone.Africa);
            Country africa37 = new AfricanCountry("Liberia", Country.Zone.Africa);
            Country africa38 = new AfricanCountry("Central African Republic", Country.Zone.Africa);
            Country africa39 = new AfricanCountry("Mauritania", Country.Zone.Africa);
            Country africa40 = new AfricanCountry("Eritrea", Country.Zone.Africa);
            Country africa41 = new AfricanCountry("Namibia", Country.Zone.Africa);
            Country africa42 = new AfricanCountry("Gambia", Country.Zone.Africa);
            Country africa43 = new AfricanCountry("Botswana", Country.Zone.Africa);
            Country africa44 = new AfricanCountry("Gabon", Country.Zone.Africa);
            Country africa45 = new AfricanCountry("Lesotho", Country.Zone.Africa);
            Country africa46 = new AfricanCountry("Guinea-Bissau", Country.Zone.Africa);
            Country africa47 = new AfricanCountry("Equatorial Guinea", Country.Zone.Africa);
            Country africa48 = new AfricanCountry("Mauritius", Country.Zone.Africa);
            Country africa49 = new AfricanCountry("Eswatini", Country.Zone.Africa);
            Country africa50 = new AfricanCountry("Djibouti", Country.Zone.Africa);
            Country africa51 = new AfricanCountry("Comoros", Country.Zone.Africa);
            Country africa52 = new AfricanCountry("Cabo Verde", Country.Zone.Africa);
            Country africa53 = new AfricanCountry("Sao Tom & Principe", Country.Zone.Africa);
            Country africa54 = new AfricanCountry("Seychelles", Country.Zone.Africa);
            //Asian Region
            Country asia1 = new AsianCountry("China", Country.Zone.Asia);
            Country asia2 = new AsianCountry("India", Country.Zone.Asia);
            Country asia3 = new AsianCountry("Indonesia", Country.Zone.Asia);
            Country asia4 = new AsianCountry("Pakistan", Country.Zone.Asia);
            Country asia5 = new AsianCountry("Bangladesh", Country.Zone.Asia);
            Country asia6 = new AsianCountry("Japan", Country.Zone.Asia);
            Country asia7 = new AsianCountry("Philippines", Country.Zone.Asia);
            Country asia8 = new AsianCountry("Vietnam", Country.Zone.Asia);
            Country asia9 = new AsianCountry("Turkey", Country.Zone.Asia);
            Country asia10 = new AsianCountry("Iran", Country.Zone.Asia);
            Country asia11 = new AsianCountry("Thailand", Country.Zone.Asia);
            Country asia12 = new AsianCountry("Myanmar", Country.Zone.Asia);
            Country asia13 = new AsianCountry("South Korea", Country.Zone.Asia);
            Country asia14 = new AsianCountry("Iraq", Country.Zone.Asia);
            Country asia15 = new AsianCountry("Afghanistan", Country.Zone.Asia);
            Country asia16 = new AsianCountry("Saudi Arabia", Country.Zone.Asia);
            Country asia17 = new AsianCountry("Uzbekistan", Country.Zone.Asia);
            Country asia18 = new AsianCountry("Malaysia", Country.Zone.Asia);
            Country asia19 = new AsianCountry("Yemen", Country.Zone.Asia);
            Country asia20 = new AsianCountry("Nepal", Country.Zone.Asia);
            Country asia21 = new AsianCountry("North Korea", Country.Zone.Asia);
            Country asia22 = new AsianCountry("Sri Lanka", Country.Zone.Asia);
            Country asia23 = new AsianCountry("Kazakhstan", Country.Zone.Asia);
            Country asia24 = new AsianCountry("Syria", Country.Zone.Asia);
            Country asia25 = new AsianCountry("Cambodia", Country.Zone.Asia);
            Country asia26 = new AsianCountry("Jordan", Country.Zone.Asia);
            Country asia27 = new AsianCountry("Azerbaijan", Country.Zone.Asia);
            Country asia28 = new AsianCountry("United Arab Emirates", Country.Zone.Asia);
            Country asia29 = new AsianCountry("Tajikistan", Country.Zone.Asia);
            Country asia30 = new AsianCountry("Israel", Country.Zone.Asia);
            Country asia31 = new AsianCountry("Laos", Country.Zone.Asia);
            Country asia32 = new AsianCountry("Lebanon", Country.Zone.Asia);
            Country asia33 = new AsianCountry("Kyrgyzstan", Country.Zone.Asia);
            Country asia34 = new AsianCountry("Turkmenistan", Country.Zone.Asia);
            Country asia35 = new AsianCountry("Singapore", Country.Zone.Asia);
            Country asia36 = new AsianCountry("Oman", Country.Zone.Asia);
            Country asia37 = new AsianCountry("State of Palestine", Country.Zone.Asia);
            Country asia38 = new AsianCountry("Kuwait", Country.Zone.Asia);
            Country asia39 = new AsianCountry("Georgia", Country.Zone.Asia);
            Country asia40 = new AsianCountry("Mongolia", Country.Zone.Asia);
            Country asia41 = new AsianCountry("Armenia", Country.Zone.Asia);
            Country asia42 = new AsianCountry("Qatar", Country.Zone.Asia);
            Country asia43 = new AsianCountry("Bahrain", Country.Zone.Asia);
            Country asia44 = new AsianCountry("Timor-Leste", Country.Zone.Asia);
            Country asia45 = new AsianCountry("Cyprus", Country.Zone.Asia);
            Country asia46 = new AsianCountry("Bhutan", Country.Zone.Asia);
            Country asia47 = new AsianCountry("Maldives", Country.Zone.Asia);
            Country asia48 = new AsianCountry("Brunei", Country.Zone.Asia);
            //European Region
            Country euro1 = new Country("Russia", Country.Zone.Europe);
            Country euro2 = new EuropeanCountry("Germany", Country.Zone.Europe);
            Country euro3 = new EuropeanCountry("United Kingdom", Country.Zone.Europe);
            Country euro4 = new EuropeanCountry("France", Country.Zone.Europe);
            Country euro5 = new EuropeanCountry("Italy", Country.Zone.Europe);
            Country euro6 = new EuropeanCountry("Spain", Country.Zone.Europe);
            Country euro7 = new EuropeanCountry("Ukraine", Country.Zone.Europe);
            Country euro8 = new EuropeanCountry("Poland", Country.Zone.Europe);
            Country euro9 = new EuropeanCountry("Romania", Country.Zone.Europe);
            Country euro10 = new EuropeanCountry("Netherlands", Country.Zone.Europe);
            Country euro11 = new EuropeanCountry("Belgium", Country.Zone.Europe);
            Country euro12 = new EuropeanCountry("Czech Republic", Country.Zone.Europe);
            Country euro13 = new EuropeanCountry("Greece", Country.Zone.Europe);
            Country euro14 = new EuropeanCountry("Portugal", Country.Zone.Europe);
            Country euro15 = new EuropeanCountry("Sweden", Country.Zone.Europe);
            Country euro16 = new EuropeanCountry("Hungary", Country.Zone.Europe);
            Country euro17 = new EuropeanCountry("Belarus", Country.Zone.Europe);
            Country euro18 = new EuropeanCountry("Austria", Country.Zone.Europe);
            Country euro19 = new EuropeanCountry("Serbia", Country.Zone.Europe);
            Country euro20 = new EuropeanCountry("Switzerland", Country.Zone.Europe);
            Country euro21 = new EuropeanCountry("Bulgaria", Country.Zone.Europe);
            Country euro22 = new EuropeanCountry("Denmark", Country.Zone.Europe);
            Country euro23 = new EuropeanCountry("Finland", Country.Zone.Europe);
            Country euro24 = new EuropeanCountry("Slovakia", Country.Zone.Europe);
            Country euro25 = new EuropeanCountry("Norway", Country.Zone.Europe);
            Country euro26 = new EuropeanCountry("Ireland", Country.Zone.Europe);
            Country euro27 = new EuropeanCountry("Croatia", Country.Zone.Europe);
            Country euro28 = new EuropeanCountry("Moldova", Country.Zone.Europe);
            Country euro29 = new EuropeanCountry("Bosnia and Herzegovina", Country.Zone.Europe);
            Country euro30 = new EuropeanCountry("Albania", Country.Zone.Europe);
            Country euro31 = new EuropeanCountry("Lithuania", Country.Zone.Europe);
            Country euro32 = new EuropeanCountry("North Macedonia", Country.Zone.Europe);
            Country euro33 = new EuropeanCountry("Slovenia", Country.Zone.Europe);
            Country euro34 = new EuropeanCountry("Latvia", Country.Zone.Europe);
            Country euro35 = new EuropeanCountry("Estonia", Country.Zone.Europe);
            Country euro36 = new EuropeanCountry("Montenegro", Country.Zone.Europe);
            Country euro37 = new EuropeanCountry("Luxembourg", Country.Zone.Europe);
            Country euro38 = new EuropeanCountry("Malta", Country.Zone.Europe);
            Country euro39 = new EuropeanCountry("Iceland", Country.Zone.Europe);
            Country euro40 = new EuropeanCountry("Andorra", Country.Zone.Europe);
            Country euro41 = new EuropeanCountry("Monaco", Country.Zone.Europe);
            Country euro42 = new EuropeanCountry("Liechtenstein", Country.Zone.Europe);
            Country euro43 = new EuropeanCountry("San Marino", Country.Zone.Europe);
            Country euro44 = new EuropeanCountry("Holy See", Country.Zone.Europe);
            //Latin American Region
            Country laac1 = new LatinCaribbeanCountry("Brazil", Country.Zone.Latin_America_and_Carribean);
            Country laac2 = new LatinCaribbeanCountry("Mexico", Country.Zone.Latin_America_and_Carribean);
            Country laac3 = new LatinCaribbeanCountry("Colombia", Country.Zone.Latin_America_and_Carribean);
            Country laac4 = new LatinCaribbeanCountry("Argentina", Country.Zone.Latin_America_and_Carribean);
            Country laac5 = new LatinCaribbeanCountry("Peru", Country.Zone.Latin_America_and_Carribean);
            Country laac6 = new LatinCaribbeanCountry("Venezuela", Country.Zone.Latin_America_and_Carribean);
            Country laac7 = new LatinCaribbeanCountry("Chile", Country.Zone.Latin_America_and_Carribean);
            Country laac8 = new LatinCaribbeanCountry("Guatemala", Country.Zone.Latin_America_and_Carribean);
            Country laac9 = new LatinCaribbeanCountry("Ecuador", Country.Zone.Latin_America_and_Carribean);
            Country laac10 = new LatinCaribbeanCountry("Bolivia", Country.Zone.Latin_America_and_Carribean);
            Country laac11 = new LatinCaribbeanCountry("Haiti", Country.Zone.Latin_America_and_Carribean);
            Country laac12 = new LatinCaribbeanCountry("Cuba", Country.Zone.Latin_America_and_Carribean);
            Country laac13 = new LatinCaribbeanCountry("Dominican Republic", Country.Zone.Latin_America_and_Carribean);
            Country laac14 = new LatinCaribbeanCountry("Honduras", Country.Zone.Latin_America_and_Carribean);
            Country laac15 = new LatinCaribbeanCountry("Paraguay", Country.Zone.Latin_America_and_Carribean);
            Country laac16 = new LatinCaribbeanCountry("Nicaragua", Country.Zone.Latin_America_and_Carribean);
            Country laac17 = new LatinCaribbeanCountry("El Salvador", Country.Zone.Latin_America_and_Carribean);
            Country laac18 = new LatinCaribbeanCountry("Costa Rica", Country.Zone.Latin_America_and_Carribean);
            Country laac19 = new LatinCaribbeanCountry("Panama", Country.Zone.Latin_America_and_Carribean);
            Country laac20 = new LatinCaribbeanCountry("Uruguay", Country.Zone.Latin_America_and_Carribean);
            Country laac21 = new LatinCaribbeanCountry("Jamaica", Country.Zone.Latin_America_and_Carribean);
            Country laac22 = new LatinCaribbeanCountry("Trinidad and Tobago", Country.Zone.Latin_America_and_Carribean);
            Country laac23 = new LatinCaribbeanCountry("Guyana", Country.Zone.Latin_America_and_Carribean);
            Country laac24 = new LatinCaribbeanCountry("Suriname", Country.Zone.Latin_America_and_Carribean);
            Country laac25 = new LatinCaribbeanCountry("Belize", Country.Zone.Latin_America_and_Carribean);
            Country laac26 = new LatinCaribbeanCountry("Bahamas", Country.Zone.Latin_America_and_Carribean);
            Country laac27 = new LatinCaribbeanCountry("Barbados", Country.Zone.Latin_America_and_Carribean);
            Country laac28 = new LatinCaribbeanCountry("Saint Lucia", Country.Zone.Latin_America_and_Carribean);
            Country laac29 = new LatinCaribbeanCountry("Grenada", Country.Zone.Latin_America_and_Carribean);
            Country laac30 = new LatinCaribbeanCountry("St. Vincent & Grenadines", Country.Zone.Latin_America_and_Carribean);
            Country laac31 = new LatinCaribbeanCountry("Antigua and Barbuda", Country.Zone.Latin_America_and_Carribean);
            Country laac32 = new LatinCaribbeanCountry("Dominica", Country.Zone.Latin_America_and_Carribean);
            Country laac33 = new LatinCaribbeanCountry("Saint Kitts & Nevis", Country.Zone.Latin_America_and_Carribean);
            //Oceanic Region
            Country oceania1 = new OceanicCountry("Australia", Country.Zone.Oceania);
            Country oceania2 = new OceanicCountry("Papua New Guinea", Country.Zone.Oceania);
            Country oceania3 = new OceanicCountry("New Zealand", Country.Zone.Oceania);
            Country oceania4 = new OceanicCountry("Fiji", Country.Zone.Oceania);
            Country oceania5 = new OceanicCountry("Solomon Islands", Country.Zone.Oceania);
            Country oceania6 = new OceanicCountry("Vanuatu", Country.Zone.Oceania);
            Country oceania7 = new OceanicCountry("Samoa", Country.Zone.Oceania);
            Country oceania8 = new OceanicCountry("Kiribati", Country.Zone.Oceania);
            Country oceania9 = new OceanicCountry("Micronesia", Country.Zone.Oceania);
            Country oceania10 = new OceanicCountry("Tonga", Country.Zone.Oceania);
            Country oceania11 = new OceanicCountry("Marshall Islands", Country.Zone.Oceania);
            Country oceania12 = new OceanicCountry("Palau", Country.Zone.Oceania);
            Country oceania13 = new OceanicCountry("Tuvalu", Country.Zone.Oceania);
            Country oceania14 = new OceanicCountry("Nauru", Country.Zone.Oceania);
            Country northa1 = new NorthAmericanCountry("United States", Country.Zone.North_America);
            Country northa2 = new NorthAmericanCountry("Canada", Country.Zone.North_America);
            allCountries.Add(africa1);
            allCountries.Add(africa2);
            allCountries.Add(africa3);
            allCountries.Add(africa4);
            allCountries.Add(africa5);
            allCountries.Add(africa6);
            allCountries.Add(africa7);
            allCountries.Add(africa8);
            allCountries.Add(africa9);
            allCountries.Add(africa10);
            allCountries.Add(africa11);
            allCountries.Add(africa12);
            allCountries.Add(africa13);
            allCountries.Add(africa14);
            allCountries.Add(africa15);
            allCountries.Add(africa16);
            allCountries.Add(africa17);
            allCountries.Add(africa18);
            allCountries.Add(africa19);
            allCountries.Add(africa20);
            allCountries.Add(africa21);
            allCountries.Add(africa22);
            allCountries.Add(africa23);
            allCountries.Add(africa24);
            allCountries.Add(africa25);
            allCountries.Add(africa26);
            allCountries.Add(africa27);
            allCountries.Add(africa28);
            allCountries.Add(africa29);
            allCountries.Add(africa30);
            allCountries.Add(africa31);
            allCountries.Add(africa32);
            allCountries.Add(africa33);
            allCountries.Add(africa34);
            allCountries.Add(africa35);
            allCountries.Add(africa36);
            allCountries.Add(africa37);
            allCountries.Add(africa38);
            allCountries.Add(africa39);
            allCountries.Add(africa40);
            allCountries.Add(africa41);
            allCountries.Add(africa42);
            allCountries.Add(africa43);
            allCountries.Add(africa44);
            allCountries.Add(africa45);
            allCountries.Add(africa46);
            allCountries.Add(africa47);
            allCountries.Add(africa48);
            allCountries.Add(africa49);
            allCountries.Add(africa50);
            allCountries.Add(africa51);
            allCountries.Add(africa52);
            allCountries.Add(africa53);
            allCountries.Add(africa54);
            allCountries.Add(asia1);
            allCountries.Add(asia2);
            allCountries.Add(asia3);
            allCountries.Add(asia4);
            allCountries.Add(asia5);
            allCountries.Add(asia6);
            allCountries.Add(asia7);
            allCountries.Add(asia8);
            allCountries.Add(asia9);
            allCountries.Add(asia10);
            allCountries.Add(asia11);
            allCountries.Add(asia12);
            allCountries.Add(asia13);
            allCountries.Add(asia14);
            allCountries.Add(asia15);
            allCountries.Add(asia16);
            allCountries.Add(asia17);
            allCountries.Add(asia18);
            allCountries.Add(asia19);
            allCountries.Add(asia20);
            allCountries.Add(asia21);
            allCountries.Add(asia22);
            allCountries.Add(asia23);
            allCountries.Add(asia24);
            allCountries.Add(asia25);
            allCountries.Add(asia26);
            allCountries.Add(asia27);
            allCountries.Add(asia28);
            allCountries.Add(asia29);
            allCountries.Add(asia30);
            allCountries.Add(asia31);
            allCountries.Add(asia32);
            allCountries.Add(asia33);
            allCountries.Add(asia34);
            allCountries.Add(asia35);
            allCountries.Add(asia36);
            allCountries.Add(asia37);
            allCountries.Add(asia38);
            allCountries.Add(asia39);
            allCountries.Add(asia40);
            allCountries.Add(asia41);
            allCountries.Add(asia42);
            allCountries.Add(asia43);
            allCountries.Add(asia44);
            allCountries.Add(asia45);
            allCountries.Add(asia46);
            allCountries.Add(asia47);
            allCountries.Add(asia48);
            allCountries.Add(euro1);
            allCountries.Add(euro2);
            allCountries.Add(euro3);
            allCountries.Add(euro4);
            allCountries.Add(euro5);
            allCountries.Add(euro6);
            allCountries.Add(euro7);
            allCountries.Add(euro8);
            allCountries.Add(euro9);
            allCountries.Add(euro10);
            allCountries.Add(euro11);
            allCountries.Add(euro12);
            allCountries.Add(euro13);
            allCountries.Add(euro14);
            allCountries.Add(euro15);
            allCountries.Add(euro16);
            allCountries.Add(euro17);
            allCountries.Add(euro18);
            allCountries.Add(euro19);
            allCountries.Add(euro20);
            allCountries.Add(euro21);
            allCountries.Add(euro22);
            allCountries.Add(euro23);
            allCountries.Add(euro24);
            allCountries.Add(euro25);
            allCountries.Add(euro26);
            allCountries.Add(euro27);
            allCountries.Add(euro28);
            allCountries.Add(euro29);
            allCountries.Add(euro30);
            allCountries.Add(euro31);
            allCountries.Add(euro32);
            allCountries.Add(euro33);
            allCountries.Add(euro34);
            allCountries.Add(euro35);
            allCountries.Add(euro36);
            allCountries.Add(euro37);
            allCountries.Add(euro38);
            allCountries.Add(euro39);
            allCountries.Add(euro40);
            allCountries.Add(euro41);
            allCountries.Add(euro42);
            allCountries.Add(euro43);
            allCountries.Add(euro44);
            allCountries.Add(laac1);
            allCountries.Add(laac2);
            allCountries.Add(laac3);
            allCountries.Add(laac4);
            allCountries.Add(laac5);
            allCountries.Add(laac6);
            allCountries.Add(laac7);
            allCountries.Add(laac8);
            allCountries.Add(laac9);
            allCountries.Add(laac10);
            allCountries.Add(laac11);
            allCountries.Add(laac12);
            allCountries.Add(laac13);
            allCountries.Add(laac14);
            allCountries.Add(laac15);
            allCountries.Add(laac16);
            allCountries.Add(laac17);
            allCountries.Add(laac18);
            allCountries.Add(laac19);
            allCountries.Add(laac20);
            allCountries.Add(laac21);
            allCountries.Add(laac22);
            allCountries.Add(laac23);
            allCountries.Add(laac24);
            allCountries.Add(laac25);
            allCountries.Add(laac26);
            allCountries.Add(laac27);
            allCountries.Add(laac28);
            allCountries.Add(laac29);
            allCountries.Add(laac30);
            allCountries.Add(laac31);
            allCountries.Add(laac32);
            allCountries.Add(laac33);
            allCountries.Add(oceania1);
            allCountries.Add(oceania2);
            allCountries.Add(oceania3);
            allCountries.Add(oceania4);
            allCountries.Add(oceania5);
            allCountries.Add(oceania6);
            allCountries.Add(oceania7);
            allCountries.Add(oceania8);
            allCountries.Add(oceania9);
            allCountries.Add(oceania10);
            allCountries.Add(oceania11);
            allCountries.Add(oceania12);
            allCountries.Add(oceania13);
            allCountries.Add(oceania14);
            allCountries.Add(northa1);
            allCountries.Add(northa2);
            //Sorts the names of the countries.
            sortCountries();
            //Dsplay the countries
            list_bx_world_countries.ItemsSource = allCountries;
        }
        #endregion

        //##########################

        //End Of Listboxes Region for all of the listboxes and buttons for them
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

        #region CountryFilter
       
        #endregion

        //##########################

        //Region for all of the smaller methods that don't quite fit in another region
        #region Small Methods
        //Sorts the countries method
        private void sortCountries()
        {
            allCountries.Sort();
        }
        #endregion
    }
}

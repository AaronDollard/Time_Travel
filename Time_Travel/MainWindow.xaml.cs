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

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Country africa1 = new Country("Nigeria", Country.Zone.Africa);
            Country africa2 = new Country("Ethiopia", Country.Zone.Africa);
            Country africa3 = new Country("Egypt", Country.Zone.Africa);
            Country africa4 = new Country("Democratic Republic Of Congo", Country.Zone.Africa);
            Country africa5 = new Country("Tanzania", Country.Zone.Africa);
            Country africa6 = new Country("South Africa", Country.Zone.Africa);
            Country africa7 = new Country("Kenya", Country.Zone.Africa);
            Country africa8 = new Country("Uganda", Country.Zone.Africa);
            Country africa9 = new Country("Algeria", Country.Zone.Africa);
            Country africa10 = new Country("Sudan", Country.Zone.Africa);
            Country africa11 = new Country("Morocco", Country.Zone.Africa);
            Country africa12 = new Country("Angola", Country.Zone.Africa);
            Country africa13 = new Country("Mozambique", Country.Zone.Africa);
            Country africa14 = new Country("Ghana", Country.Zone.Africa);
            Country africa15 = new Country("Madagascar", Country.Zone.Africa);
            Country africa16 = new Country("Cameroon", Country.Zone.Africa);
            Country africa17 = new Country("Côte d'Ivoire", Country.Zone.Africa);
            Country africa18 = new Country("Niger", Country.Zone.Africa);
            Country africa19 = new Country("Burkina Faso", Country.Zone.Africa);
            Country africa20 = new Country("Mali", Country.Zone.Africa);
            Country africa21 = new Country("Malawi", Country.Zone.Africa);
            Country africa22 = new Country("Zambia", Country.Zone.Africa);
            Country africa23 = new Country("Senegal", Country.Zone.Africa);
            Country africa24 = new Country("Chad", Country.Zone.Africa);
            Country africa25 = new Country("Somalia", Country.Zone.Africa);
            Country africa26 = new Country("Zimbabwe", Country.Zone.Africa);
            Country africa27 = new Country("Guinea", Country.Zone.Africa);
            Country africa28 = new Country("Rwanda", Country.Zone.Africa);
            Country africa29 = new Country("Benin", Country.Zone.Africa);
            Country africa30 = new Country("Burundi", Country.Zone.Africa);
            Country africa31 = new Country("Tunisia", Country.Zone.Africa);
            Country africa32 = new Country("South Sudan", Country.Zone.Africa);
            Country africa33 = new Country("Togo", Country.Zone.Africa);
            Country africa34 = new Country("Sierra Leone", Country.Zone.Africa);
            Country africa35 = new Country("Libya", Country.Zone.Africa);
            Country africa36 = new Country("Congo", Country.Zone.Africa);
            Country africa37 = new Country("Liberia", Country.Zone.Africa);
            Country africa38 = new Country("Central African Republic", Country.Zone.Africa);
            Country africa39 = new Country("Mauritania", Country.Zone.Africa);
            Country africa40 = new Country("Eritrea", Country.Zone.Africa);
            Country africa41 = new Country("Namibia", Country.Zone.Africa);
            Country africa42 = new Country("Gambia", Country.Zone.Africa);
            Country africa43 = new Country("Botswana", Country.Zone.Africa);
            Country africa44 = new Country("Gabon", Country.Zone.Africa);
            Country africa45 = new Country("Lesotho", Country.Zone.Africa);
            Country africa46 = new Country("Guinea-Bissau", Country.Zone.Africa);
            Country africa47 = new Country("Equatorial Guinea", Country.Zone.Africa);
            Country africa48 = new Country("Mauritius", Country.Zone.Africa);
            Country africa49 = new Country("Eswatini", Country.Zone.Africa);
            Country africa50 = new Country("Djibouti", Country.Zone.Africa);
            Country africa51 = new Country("Comoros", Country.Zone.Africa);
            Country africa52 = new Country("Cabo Verde", Country.Zone.Africa);
            Country africa53 = new Country("Sao Tom & Principe", Country.Zone.Africa);
            Country africa54 = new Country("Seychelles", Country.Zone.Africa);
            Country asia1 = new Country("China", Country.Zone.Asia);
            Country asia2 = new Country("India", Country.Zone.Asia);
            Country asia3 = new Country("Indonesia", Country.Zone.Asia);
            Country asia4 = new Country("Pakistan", Country.Zone.Asia);
            Country asia5 = new Country("Bangladesh", Country.Zone.Asia);
            Country asia6 = new Country("Japan", Country.Zone.Asia);
            Country asia7 = new Country("Philippines", Country.Zone.Asia);
            Country asia8 = new Country("Vietnam", Country.Zone.Asia);
            Country asia9 = new Country("Turkey", Country.Zone.Asia);
            Country asia10 = new Country("Iran", Country.Zone.Asia);
            Country asia11 = new Country("Thailand", Country.Zone.Asia);
            Country asia12 = new Country("Myanmar", Country.Zone.Asia);
            Country asia13 = new Country("South Korea", Country.Zone.Asia);
            Country asia14 = new Country("Iraq", Country.Zone.Asia);
            Country asia15 = new Country("Afghanistan", Country.Zone.Asia);
            Country asia16 = new Country("Saudi Arabia", Country.Zone.Asia);
            Country asia17 = new Country("Uzbekistan", Country.Zone.Asia);
            Country asia18 = new Country("Malaysia", Country.Zone.Asia);
            Country asia19 = new Country("Yemen", Country.Zone.Asia);
            Country asia20 = new Country("Nepal", Country.Zone.Asia);
            Country asia21 = new Country("North Korea", Country.Zone.Asia);
            Country asia22 = new Country("Sri Lanka", Country.Zone.Asia);
            Country asia23 = new Country("Kazakhstan", Country.Zone.Asia);
            Country asia24 = new Country("Syria", Country.Zone.Asia);
            Country asia25 = new Country("Cambodia", Country.Zone.Asia);
            Country asia26 = new Country("Jordan", Country.Zone.Asia);
            Country asia27 = new Country("Azerbaijan", Country.Zone.Asia);
            Country asia28 = new Country("United Arab Emirates", Country.Zone.Asia);
            Country asia29 = new Country("Tajikistan", Country.Zone.Asia);
            Country asia30 = new Country("Israel", Country.Zone.Asia);
            Country asia31 = new Country("Laos", Country.Zone.Asia);
            Country asia32 = new Country("Lebanon", Country.Zone.Asia);
            Country asia33 = new Country("Kyrgyzstan", Country.Zone.Asia);
            Country asia34 = new Country("Turkmenistan", Country.Zone.Asia);
            Country asia35 = new Country("Singapore", Country.Zone.Asia);
            Country asia36 = new Country("Oman", Country.Zone.Asia);
            Country asia37 = new Country("State of Palestine", Country.Zone.Asia);
            Country asia38 = new Country("Kuwait", Country.Zone.Asia);
            Country asia39 = new Country("Georgia", Country.Zone.Asia);
            Country asia40 = new Country("Mongolia", Country.Zone.Asia);
            Country asia41 = new Country("Armenia", Country.Zone.Asia);
            Country asia42 = new Country("Qatar", Country.Zone.Asia);
            Country asia43 = new Country("Bahrain", Country.Zone.Asia);
            Country asia44 = new Country("Timor-Leste", Country.Zone.Asia);
            Country asia45 = new Country("Cyprus", Country.Zone.Asia);
            Country asia46 = new Country("Bhutan", Country.Zone.Asia);
            Country asia47 = new Country("Maldives", Country.Zone.Asia);
            Country asia48 = new Country("Brunei", Country.Zone.Asia);
            Country euro1 = new Country("Russia", Country.Zone.Europe);
            Country euro2 = new Country("Germany", Country.Zone.Europe);
            Country euro3 = new Country("United Kingdom", Country.Zone.Europe);
            Country euro4 = new Country("France", Country.Zone.Europe);
            Country euro5 = new Country("Italy", Country.Zone.Europe);
            Country euro6 = new Country("Spain", Country.Zone.Europe);
            Country euro7 = new Country("Ukraine", Country.Zone.Europe);
            Country euro8 = new Country("Poland", Country.Zone.Europe);
            Country euro9 = new Country("Romania", Country.Zone.Europe);
            Country euro10 = new Country("Netherlands", Country.Zone.Europe);
            Country euro11 = new Country("Belgium", Country.Zone.Europe);
            Country euro12 = new Country("Czech Republic", Country.Zone.Europe);
            Country euro13 = new Country("Greece", Country.Zone.Europe);
            Country euro14 = new Country("Portugal", Country.Zone.Europe);
            Country euro15 = new Country("Sweden", Country.Zone.Europe);
            Country euro16 = new Country("Hungary", Country.Zone.Europe);
            Country euro17 = new Country("Belarus", Country.Zone.Europe);
            Country euro18 = new Country("Austria", Country.Zone.Europe);
            Country euro19 = new Country("Serbia", Country.Zone.Europe);
            Country euro20 = new Country("Switzerland", Country.Zone.Europe);
            Country euro21 = new Country("Bulgaria", Country.Zone.Europe);
            Country euro22 = new Country("Denmark", Country.Zone.Europe);
            Country euro23 = new Country("Finland", Country.Zone.Europe);
            Country euro24 = new Country("Slovakia", Country.Zone.Europe);
            Country euro25 = new Country("Norway", Country.Zone.Europe);
            Country euro26 = new Country("Ireland", Country.Zone.Europe);
            Country euro27 = new Country("Croatia", Country.Zone.Europe);
            Country euro28 = new Country("Moldova", Country.Zone.Europe);
            Country euro29 = new Country("Bosnia and Herzegovina", Country.Zone.Europe);
            Country euro30 = new Country("Albania", Country.Zone.Europe);
            Country euro31 = new Country("Lithuania", Country.Zone.Europe);
            Country euro32 = new Country("North Macedonia", Country.Zone.Europe);
            Country euro33 = new Country("Slovenia", Country.Zone.Europe);
            Country euro34 = new Country("Latvia", Country.Zone.Europe);
            Country euro35 = new Country("Estonia", Country.Zone.Europe);
            Country euro36 = new Country("Montenegro", Country.Zone.Europe);
            Country euro37 = new Country("Luxembourg", Country.Zone.Europe);
            Country euro38 = new Country("Malta", Country.Zone.Europe);
            Country euro39 = new Country("Iceland", Country.Zone.Europe);
            Country euro40 = new Country("Andorra", Country.Zone.Europe);
            Country euro41 = new Country("Monaco", Country.Zone.Europe);
            Country euro42 = new Country("Liechtenstein", Country.Zone.Europe);
            Country euro43 = new Country("SanMarino", Country.Zone.Europe);
            Country euro44 = new Country("Holy See", Country.Zone.Europe);
            Country laac1 = new Country("Brazil", Country.Zone.Latin_America_and_Carribean);
            Country laac2 = new Country("Mexico", Country.Zone.Latin_America_and_Carribean);
            Country laac3 = new Country("Colombia", Country.Zone.Latin_America_and_Carribean);
            Country laac4 = new Country("Argentina", Country.Zone.Latin_America_and_Carribean);
            Country laac5 = new Country("Peru", Country.Zone.Latin_America_and_Carribean);
            Country laac6 = new Country("Venezuela", Country.Zone.Latin_America_and_Carribean);
            Country laac7 = new Country("Chile", Country.Zone.Latin_America_and_Carribean);
            Country laac8 = new Country("Guatemala", Country.Zone.Latin_America_and_Carribean);
            Country laac9 = new Country("Ecuador", Country.Zone.Latin_America_and_Carribean);
            Country laac10 = new Country("Bolivia", Country.Zone.Latin_America_and_Carribean);
            Country laac11 = new Country("Haiti", Country.Zone.Latin_America_and_Carribean);
            Country laac12 = new Country("Cuba", Country.Zone.Latin_America_and_Carribean);
            Country laac13 = new Country("Dominican Republic", Country.Zone.Latin_America_and_Carribean);
            Country laac14 = new Country("Honduras", Country.Zone.Latin_America_and_Carribean);
            Country laac15 = new Country("Paraguay", Country.Zone.Latin_America_and_Carribean);
            Country laac16 = new Country("Nicaragua", Country.Zone.Latin_America_and_Carribean);
            Country laac17 = new Country("El Salvador", Country.Zone.Latin_America_and_Carribean);
            Country laac18 = new Country("Costa Rica", Country.Zone.Latin_America_and_Carribean);
            Country laac19 = new Country("Panama", Country.Zone.Latin_America_and_Carribean);
            Country laac20 = new Country("Uruguay", Country.Zone.Latin_America_and_Carribean);
            Country laac21 = new Country("Jamaica", Country.Zone.Latin_America_and_Carribean);
            Country laac22 = new Country("Trinidad and Tobago", Country.Zone.Latin_America_and_Carribean);
            Country laac23 = new Country("Guyana", Country.Zone.Latin_America_and_Carribean);
            Country laac24 = new Country("Suriname", Country.Zone.Latin_America_and_Carribean);
            Country laac25 = new Country("Belize", Country.Zone.Latin_America_and_Carribean);
            Country laac26 = new Country("Bahamas", Country.Zone.Latin_America_and_Carribean);
            Country laac27 = new Country("Barbados", Country.Zone.Latin_America_and_Carribean);
            Country laac28 = new Country("SaintLucia", Country.Zone.Latin_America_and_Carribean);
            Country laac29 = new Country("Grenada", Country.Zone.Latin_America_and_Carribean);
            Country laac30 = new Country("St .Vincent & Grenadines", Country.Zone.Latin_America_and_Carribean);
            Country laac31 = new Country("Antiguaand Barbuda", Country.Zone.Latin_America_and_Carribean);
            Country laac32 = new Country("Dominica", Country.Zone.Latin_America_and_Carribean);
            Country laac33 = new Country("Saint Kitts & Nevis", Country.Zone.Latin_America_and_Carribean);
            Country oceania1 = new Country("Australia", Country.Zone.Oceania);
            Country oceania2 = new Country("Papua New Guinea", Country.Zone.Oceania);
            Country oceania3 = new Country("New Zealand", Country.Zone.Oceania);
            Country oceania4 = new Country("Fiji", Country.Zone.Oceania);
            Country oceania5 = new Country("Solomon Islands", Country.Zone.Oceania);
            Country oceania6 = new Country("Vanuatu", Country.Zone.Oceania);
            Country oceania7 = new Country("Samoa", Country.Zone.Oceania);
            Country oceania8 = new Country("Kiribati", Country.Zone.Oceania);
            Country oceania9 = new Country("Micronesia", Country.Zone.Oceania);
            Country oceania10 = new Country("Tonga", Country.Zone.Oceania);
            Country oceania11 = new Country("Marshall Islands", Country.Zone.Oceania);
            Country oceania12 = new Country("Palau", Country.Zone.Oceania);
            Country oceania13 = new Country("Tuvalu", Country.Zone.Oceania);
            Country oceania14 = new Country("Nauru", Country.Zone.Oceania);
            Country northa1 = new Country("United States", Country.Zone.North_America);
            Country northa2 = new Country("Canada", Country.Zone.North_America);

            

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
            //allCountries.Sort();
            //Dsplay the countries
            list_bx_world_countries.ItemsSource = allCountries;
        }


        private void world_countries_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Country selectedCountry = list_bx_world_countries.SelectedItem as Country;

            if (selectedCountry != null)
            {
            
            }
        }
    }
}

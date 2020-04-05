﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Time_Travel;

namespace DatabaseManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            CountryData db = new CountryData();

            using (db)
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
                db.WorldCountry.Add(africa1);
                db.WorldCountry.Add(africa2);
                db.WorldCountry.Add(africa3);
                db.WorldCountry.Add(africa4);
                db.WorldCountry.Add(africa5);
                db.WorldCountry.Add(africa6);
                db.WorldCountry.Add(africa7);
                db.WorldCountry.Add(africa8);
                db.WorldCountry.Add(africa9);
                db.WorldCountry.Add(africa10);
                db.WorldCountry.Add(africa11);
                db.WorldCountry.Add(africa12);
                db.WorldCountry.Add(africa13);
                db.WorldCountry.Add(africa14);
                db.WorldCountry.Add(africa15);
                db.WorldCountry.Add(africa16);
                db.WorldCountry.Add(africa17);
                db.WorldCountry.Add(africa18);
                db.WorldCountry.Add(africa19);
                db.WorldCountry.Add(africa20);
                db.WorldCountry.Add(africa21);
                db.WorldCountry.Add(africa22);
                db.WorldCountry.Add(africa23);
                db.WorldCountry.Add(africa24);
                db.WorldCountry.Add(africa25);
                db.WorldCountry.Add(africa26);
                db.WorldCountry.Add(africa27);
                db.WorldCountry.Add(africa28);
                db.WorldCountry.Add(africa29);
                db.WorldCountry.Add(africa30);
                db.WorldCountry.Add(africa31);
                db.WorldCountry.Add(africa32);
                db.WorldCountry.Add(africa33);
                db.WorldCountry.Add(africa34);
                db.WorldCountry.Add(africa35);
                db.WorldCountry.Add(africa36);
                db.WorldCountry.Add(africa37);
                db.WorldCountry.Add(africa38);
                db.WorldCountry.Add(africa39);
                db.WorldCountry.Add(africa40);
                db.WorldCountry.Add(africa41);
                db.WorldCountry.Add(africa42);
                db.WorldCountry.Add(africa43);
                db.WorldCountry.Add(africa44);
                db.WorldCountry.Add(africa45);
                db.WorldCountry.Add(africa46);
                db.WorldCountry.Add(africa47);
                db.WorldCountry.Add(africa48);
                db.WorldCountry.Add(africa49);
                db.WorldCountry.Add(africa50);
                db.WorldCountry.Add(africa51);
                db.WorldCountry.Add(africa52);
                db.WorldCountry.Add(africa53);
                db.WorldCountry.Add(africa54);
                db.WorldCountry.Add(asia1);
                db.WorldCountry.Add(asia2);
                db.WorldCountry.Add(asia3);
                db.WorldCountry.Add(asia4);
                db.WorldCountry.Add(asia5);
                db.WorldCountry.Add(asia6);
                db.WorldCountry.Add(asia7);
                db.WorldCountry.Add(asia8);
                db.WorldCountry.Add(asia9);
                db.WorldCountry.Add(asia10);
                db.WorldCountry.Add(asia11);
                db.WorldCountry.Add(asia12);
                db.WorldCountry.Add(asia13);
                db.WorldCountry.Add(asia14);
                db.WorldCountry.Add(asia15);
                db.WorldCountry.Add(asia16);
                db.WorldCountry.Add(asia17);
                db.WorldCountry.Add(asia18);
                db.WorldCountry.Add(asia19);
                db.WorldCountry.Add(asia20);
                db.WorldCountry.Add(asia21);
                db.WorldCountry.Add(asia22);
                db.WorldCountry.Add(asia23);
                db.WorldCountry.Add(asia24);
                db.WorldCountry.Add(asia25);
                db.WorldCountry.Add(asia26);
                db.WorldCountry.Add(asia27);
                db.WorldCountry.Add(asia28);
                db.WorldCountry.Add(asia29);
                db.WorldCountry.Add(asia30);
                db.WorldCountry.Add(asia31);
                db.WorldCountry.Add(asia32);
                db.WorldCountry.Add(asia33);
                db.WorldCountry.Add(asia34);
                db.WorldCountry.Add(asia35);
                db.WorldCountry.Add(asia36);
                db.WorldCountry.Add(asia37);
                db.WorldCountry.Add(asia38);
                db.WorldCountry.Add(asia39);
                db.WorldCountry.Add(asia40);
                db.WorldCountry.Add(asia41);
                db.WorldCountry.Add(asia42);
                db.WorldCountry.Add(asia43);
                db.WorldCountry.Add(asia44);
                db.WorldCountry.Add(asia45);
                db.WorldCountry.Add(asia46);
                db.WorldCountry.Add(asia47);
                db.WorldCountry.Add(asia48);
                db.WorldCountry.Add(euro1);
                db.WorldCountry.Add(euro2);
                db.WorldCountry.Add(euro3);
                db.WorldCountry.Add(euro4);
                db.WorldCountry.Add(euro5);
                db.WorldCountry.Add(euro6);
                db.WorldCountry.Add(euro7);
                db.WorldCountry.Add(euro8);
                db.WorldCountry.Add(euro9);
                db.WorldCountry.Add(euro10);
                db.WorldCountry.Add(euro11);
                db.WorldCountry.Add(euro12);
                db.WorldCountry.Add(euro13);
                db.WorldCountry.Add(euro14);
                db.WorldCountry.Add(euro15);
                db.WorldCountry.Add(euro16);
                db.WorldCountry.Add(euro17);
                db.WorldCountry.Add(euro18);
                db.WorldCountry.Add(euro19);
                db.WorldCountry.Add(euro20);
                db.WorldCountry.Add(euro21);
                db.WorldCountry.Add(euro22);
                db.WorldCountry.Add(euro23);
                db.WorldCountry.Add(euro24);
                db.WorldCountry.Add(euro25);
                db.WorldCountry.Add(euro26);
                db.WorldCountry.Add(euro27);
                db.WorldCountry.Add(euro28);
                db.WorldCountry.Add(euro29);
                db.WorldCountry.Add(euro30);
                db.WorldCountry.Add(euro31);
                db.WorldCountry.Add(euro32);
                db.WorldCountry.Add(euro33);
                db.WorldCountry.Add(euro34);
                db.WorldCountry.Add(euro35);
                db.WorldCountry.Add(euro36);
                db.WorldCountry.Add(euro37);
                db.WorldCountry.Add(euro38);
                db.WorldCountry.Add(euro39);
                db.WorldCountry.Add(euro40);
                db.WorldCountry.Add(euro41);
                db.WorldCountry.Add(euro42);
                db.WorldCountry.Add(euro43);
                db.WorldCountry.Add(euro44);
                db.WorldCountry.Add(laac1);
                db.WorldCountry.Add(laac2);
                db.WorldCountry.Add(laac3);
                db.WorldCountry.Add(laac4);
                db.WorldCountry.Add(laac5);
                db.WorldCountry.Add(laac6);
                db.WorldCountry.Add(laac7);
                db.WorldCountry.Add(laac8);
                db.WorldCountry.Add(laac9);
                db.WorldCountry.Add(laac10);
                db.WorldCountry.Add(laac11);
                db.WorldCountry.Add(laac12);
                db.WorldCountry.Add(laac13);
                db.WorldCountry.Add(laac14);
                db.WorldCountry.Add(laac15);
                db.WorldCountry.Add(laac16);
                db.WorldCountry.Add(laac17);
                db.WorldCountry.Add(laac18);
                db.WorldCountry.Add(laac19);
                db.WorldCountry.Add(laac20);
                db.WorldCountry.Add(laac21);
                db.WorldCountry.Add(laac22);
                db.WorldCountry.Add(laac23);
                db.WorldCountry.Add(laac24);
                db.WorldCountry.Add(laac25);
                db.WorldCountry.Add(laac26);
                db.WorldCountry.Add(laac27);
                db.WorldCountry.Add(laac28);
                db.WorldCountry.Add(laac29);
                db.WorldCountry.Add(laac30);
                db.WorldCountry.Add(laac31);
                db.WorldCountry.Add(laac32);
                db.WorldCountry.Add(laac33);
                db.WorldCountry.Add(oceania1);
                db.WorldCountry.Add(oceania2);
                db.WorldCountry.Add(oceania3);
                db.WorldCountry.Add(oceania4);
                db.WorldCountry.Add(oceania5);
                db.WorldCountry.Add(oceania6);
                db.WorldCountry.Add(oceania7);
                db.WorldCountry.Add(oceania8);
                db.WorldCountry.Add(oceania9);
                db.WorldCountry.Add(oceania10);
                db.WorldCountry.Add(oceania11);
                db.WorldCountry.Add(oceania12);
                db.WorldCountry.Add(oceania13);
                db.WorldCountry.Add(oceania14);
                db.WorldCountry.Add(northa1);
                db.WorldCountry.Add(northa2);
                Console.WriteLine("Countries added to database");
                db.SaveChanges();
                Console.WriteLine("Changes saved");
            }
        }
    }
}

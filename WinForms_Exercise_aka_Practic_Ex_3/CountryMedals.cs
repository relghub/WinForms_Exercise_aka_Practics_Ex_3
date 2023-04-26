using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForms_Exercise_aka_Practic_Ex_3
{
    internal class CountryMedals
    {
        internal string? country;
        internal int contestants_count;
        internal int first_medal_count;
        internal int second_medal_count;
        internal int third_medal_count;
        public CountryMedals(string country)
        {
            this.country = country;
        }
        public CountryMedals(string country, int contestants_count)
        {
            this.country = country;
            this.contestants_count = contestants_count;
        }
        public CountryMedals(string country, int contestants_count,
        int first_medal_count)
        {
            this.country = country;
            this.contestants_count = contestants_count;
            this.first_medal_count = first_medal_count;
        }
        public CountryMedals(string country, int contestants_count,
        int first_medal_count, int second_medal_count)
        {
            this.country = country;
            this.first_medal_count = first_medal_count;
            this.second_medal_count = second_medal_count;
            this.contestants_count = contestants_count;
        }
        public CountryMedals(string country, int contestants_count,
        int first_medal_count, int second_medal_count, int third_medal_count)
        {
            this.country = country;
            this.first_medal_count = first_medal_count;
            this.second_medal_count = second_medal_count;
            this.third_medal_count = third_medal_count;
            this.contestants_count = contestants_count;
        }
        public string GetInformation()
        {
            string information;
            information = "Країна: " + country + "; Кількість учасників: " +
            contestants_count.ToString() + "; Золоті медалі: " +
            first_medal_count + "; Срібні медалі: " + second_medal_count +
            "; Бронзові медалі: " + third_medal_count;
            return information;
        }
    }
}

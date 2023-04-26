using System;

namespace WinForms_Exercise_aka_Practic_Ex_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            CountryMedals new_medal_position;
            if (CountryBox.Text == "")
            {
                MessageBox.Show("Ââåä³òü ³ì'ÿ.");
            }
            else
            {
                if (ContestCountBox.Text != "" && ContestCountBox.Text != "0")
                {
                    if (GoldMedalCountBox.Text != ""
                        && SilverMedalCountBox.Text != ""
                        && BronzeMedalCountBox.Text != "")
                    {
                        new_medal_position = new CountryMedals(CountryBox.Text,
                        Convert.ToInt32(ContestCountBox.Text),
                        Convert.ToInt32(GoldMedalCountBox.Text),
                        Convert.ToInt32(SilverMedalCountBox.Text),
                        Convert.ToInt32(BronzeMedalCountBox.Text));
                    }
                    else if (GoldMedalCountBox.Text != ""
                        && SilverMedalCountBox.Text != ""
                        && BronzeMedalCountBox.Text == "")
                    {
                        new_medal_position = new CountryMedals(CountryBox.Text,
                        Convert.ToInt32(ContestCountBox.Text),
                        Convert.ToInt32(GoldMedalCountBox.Text),
                        Convert.ToInt32(SilverMedalCountBox.Text),
                        0);
                    }
                    else if (GoldMedalCountBox.Text != ""
                        && SilverMedalCountBox.Text == ""
                        && BronzeMedalCountBox.Text != "")
                    {
                        new_medal_position = new CountryMedals(CountryBox.Text,
                        Convert.ToInt32(ContestCountBox.Text),
                        Convert.ToInt32(GoldMedalCountBox.Text),
                        0,
                        Convert.ToInt32(BronzeMedalCountBox.Text));
                    }
                    else if (GoldMedalCountBox.Text == ""
                        && SilverMedalCountBox.Text != ""
                        && BronzeMedalCountBox.Text != "")
                    {
                        new_medal_position = new CountryMedals(CountryBox.Text,
                        Convert.ToInt32(ContestCountBox.Text),
                        0,
                        Convert.ToInt32(SilverMedalCountBox.Text),
                        Convert.ToInt32(BronzeMedalCountBox.Text));
                    }
                    else if (GoldMedalCountBox.Text != ""
                        && SilverMedalCountBox.Text == ""
                        && BronzeMedalCountBox.Text == "")
                    {
                        new_medal_position = new CountryMedals(CountryBox.Text,
                        Convert.ToInt32(ContestCountBox.Text),
                        Convert.ToInt32(GoldMedalCountBox.Text),
                        0,
                        0);
                    }
                    else if (GoldMedalCountBox.Text == ""
                        && SilverMedalCountBox.Text != ""
                        && BronzeMedalCountBox.Text == "")
                    {
                        new_medal_position = new CountryMedals(CountryBox.Text,
                        Convert.ToInt32(ContestCountBox.Text),
                        0,
                        Convert.ToInt32(SilverMedalCountBox.Text),
                        0);
                    }
                    else if (GoldMedalCountBox.Text == ""
                        && SilverMedalCountBox.Text == ""
                        && BronzeMedalCountBox.Text != "")
                    {
                        new_medal_position = new CountryMedals(CountryBox.Text,
                        Convert.ToInt32(ContestCountBox.Text),
                        0,
                        0,
                        Convert.ToInt32(BronzeMedalCountBox.Text));
                    }
                    else
                    {
                        new_medal_position = new CountryMedals(CountryBox.Text,
                        Convert.ToInt32(ContestCountBox.Text),
                        0,
                        0,
                        0);
                    }
                }
                else
                {
                    new_medal_position = new CountryMedals(CountryBox.Text);
                }
                ResultBox.AppendText(new_medal_position.GetInformation() + Environment.NewLine);
            }
        }
    }
}
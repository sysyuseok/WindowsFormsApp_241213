using System;
using System.Windows.Forms;

namespace WindowsFormsApp_241216
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            byte ageOfOldestManInEarth=100;
            short increaseDecreasePopulationPerNation=10000;
            int hairLossIncomePerDay=1000000000;
            float degreeOfClockHands = 37.628f;
            double militaryServiceRateForEverySecond = 15.32321542;
            decimal cellNumInBody = 10000000000000000;
            textBox_print.Text += ageOfOldestManInEarth.GetType();
            textBox_print.Text += "   ageOfOldestManInEarth   ";
            textBox_print.Text += ageOfOldestManInEarth.ToString();
            textBox_print.Text += "\r\n";
            textBox_print.Text += increaseDecreasePopulationPerNation.GetType();
            textBox_print.Text += "   increaseDecreasePopulationPerNation   ";
            textBox_print.Text += increaseDecreasePopulationPerNation.ToString();
            textBox_print.Text += "\r\n";
            textBox_print.Text += hairLossIncomePerDay.GetType();
            textBox_print.Text +="   hairLossIncomePerDay   ";
            textBox_print.Text += hairLossIncomePerDay.ToString();
            textBox_print.Text += "\r\n";
            textBox_print.Text += degreeOfClockHands.GetType();
            textBox_print.Text +="   degreeOfClockHands   ";
            textBox_print.Text += degreeOfClockHands.ToString();
            textBox_print.Text += "\r\n";
            textBox_print.Text += militaryServiceRateForEverySecond.GetType();
            textBox_print.Text +="   militaryServiceRateForEverySecond   ";
            textBox_print.Text += militaryServiceRateForEverySecond.ToString();
            textBox_print.Text += "\r\n";
            textBox_print.Text += cellNumInBody.GetType();
            textBox_print.Text += "   cellNumInBody   ";
            textBox_print.Text += cellNumInBody.ToString();
            textBox_print.Text += "\r\n";
        }

    }
}

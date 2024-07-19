using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//name: Natalia Andrrea Herrera Espinosa
//date: 2023-11-02
//description: Final Project : design a botton code

//date: 2023-11-04
//description: Final Project : boton, exit and lotto 649 mini app

//date: 2023-11-07/08
//description: Final Project : lotto Max mini app and fixing some errors for lotto649

//date: 2023-11-09
//description: Final Project : change date display and fix text file save


namespace ProjectOOP_NataliaHerrera
{
    public partial class frm23Dashboard : Form
    {
        private DateTime startTime; // Variable to store the start time of the application

        public frm23Dashboard()
        {
            InitializeComponent(); // Initialize the form components
            // Capture the start time when the program initializes
            startTime = DateTime.Now; 
        }

        // Event handler for the LottoMax button click
        private void btnLottoMax_Click(object sender, EventArgs e)
        {
            LottoMax obj = new LottoMax();
            obj.ShowDialog();// Display the LottoMax form
        }

        // Event handler for the Lotto649 button click
        private void btnLotto649_Click(object sender, EventArgs e)
        {
            Lotto649 obj = new Lotto649();
            obj.ShowDialog();  // Display the Lotto649 form
        }

        // Event handler for the Exit button click
        private void btnExit_Click(object sender, EventArgs e)
        {
            
            // Calculate the time elapsed since the program started
            TimeSpan totalTime = DateTime.Now - startTime;

            // Format the pass by time as a string
            string formattedTime = FormatTotalTime(totalTime);

            // Display a message box asking if the user wants to quit with the elapsed time
            if (MessageBox.Show("Do you want to quit this app? "+" You have been here "+ formattedTime, "Exit ", MessageBoxButtons.YesNo, MessageBoxIcon.Question).ToString() == "Yes")
            {
                Application.Exit();  // If 'Yes' is clicked, exit the application
            }

        }

        // Helper method to format the total elapsed time
        private string FormatTotalTime(TimeSpan totalTime)
        {
            // Format the total time as "X minutes Y seconds"
            string formattedTime = $"{totalTime.Minutes} minutes {totalTime.Seconds} seconds";
            return formattedTime;
        }

        // Event handler for Money Exchange button click
        private void btnMoneyExchange_Click(object sender, EventArgs e)
        {
            Form form = new MoneyExchange();
            form.Show();
        }

        private void frm23Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void btnExit2_Click(object sender, EventArgs e)
        {

            // Calculate the time elapsed since the program started
            TimeSpan totalTime = DateTime.Now - startTime;

            // Format the pass by time as a string
            string formattedTime = FormatTotalTime(totalTime);

            if (MessageBox.Show("Do you want to quit this app? " + " You have been here " + formattedTime, "Exit ", MessageBoxButtons.YesNo, MessageBoxIcon.Question).ToString() == "Yes")
            {
                Application.Exit();
            }
        }

        private void btnTemperatureConvert_Click(object sender, EventArgs e)
        {
            Form form = new TemperatureConversion();
            form.Show();
        }

        private void btnIpValidation_Click(object sender, EventArgs e)
        {
            
            Form form = new IP_Validator();
            form.Show();
        }

        private void btnCalculator_Click(object sender, EventArgs e)
        {
            Form form = new simpleCalculator();
            form.Show();
        }

        private void btn_Exit4_Click(object sender, EventArgs e)
        {
            // Calculate the time elapsed since the program started
            TimeSpan totalTime = DateTime.Now - startTime;

            // Format the pass by time as a string
            string formattedTime = FormatTotalTime(totalTime);

            if (MessageBox.Show("Do you want to quit this app? " + " You have been here " + formattedTime, "Exit ", MessageBoxButtons.YesNo, MessageBoxIcon.Question).ToString() == "Yes")
            {
                Application.Exit();
            }
        }

        private void btnExit3_Click(object sender, EventArgs e)
        {
            // Calculate the time elapsed since the program started
            TimeSpan totalTime = DateTime.Now - startTime;

            // Format the pass by time as a string
            string formattedTime = FormatTotalTime(totalTime);

            if (MessageBox.Show("Do you want to quit this app? " + " You have been here " + formattedTime, "Exit ", MessageBoxButtons.YesNo, MessageBoxIcon.Question).ToString() == "Yes")
            {
                Application.Exit();
            }
        }
    }
}

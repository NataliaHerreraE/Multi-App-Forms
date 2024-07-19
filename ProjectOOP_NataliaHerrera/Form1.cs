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


namespace ProjectOOP_NataliaHerrera
{
    public partial class Form1 : Form
    {
        private DateTime startTime;

        public Form1()
        {
            InitializeComponent();
            // Capture the start time when the program initializes
            startTime = DateTime.Now;
        }

        private void btnLottoMax_Click(object sender, EventArgs e)
        {
            LottoMax obj = new LottoMax();
            obj.ShowDialog();
        }

        private void btnLotto649_Click(object sender, EventArgs e)
        {
            Lotto649 obj = new Lotto649();
            obj.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            
            // Calculate the time elapsed since the program started
            TimeSpan totalTime = DateTime.Now - startTime;

            // Format the pass by time as a string
            string formattedTime = FormatTotalTime(totalTime);

            if (MessageBox.Show("Do you want to quit this app? "+" You have been here "+ formattedTime, "Exit ", MessageBoxButtons.YesNo, MessageBoxIcon.Question).ToString() == "Yes")
            {
                Application.Exit();
            }

        }

        private string FormatTotalTime(TimeSpan totalTime)
        {
            // Format the total time as "X minutes Y seconds"
            string formattedTime = $"{totalTime.Minutes} minutes {totalTime.Seconds} seconds";
            return formattedTime;
        }
    }
}

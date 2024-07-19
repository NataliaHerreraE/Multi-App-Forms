using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml;

// Name: Natalia Andrea Herrera Espinosa
//date: 2023-11-17
//description: Final Project : design ip validator and calculator

// Name: Natalia Andrea Herrera Espinosa
//date: 2023-11-30
//description: Final Project : partial code ip validator

namespace ProjectOOP_NataliaHerrera
{
    public partial class IP_Validator : Form
    {
        public IP_Validator()
        {
            InitializeComponent();
            
            
        }


        private void IP_Validator_Load(object sender, EventArgs e)
        {
            startTime = DateTime.Now;
            string Start = startTime.ToLongDateString();
            textBox_day.Text = Start;


        }


        private DateTime startTime;

        //files creation
        // File paths for storing IP validation data
        static string dir = @".\files\";
        string textFilePath = dir + "IPValidator.txt";
        string binaryFilePath = dir + "IPValidatorB.txt";

        // Instances for IPv4 and IPv6 validation
        ValidateIP obj1 = null;
        IPv4 obj2 = null;
        IPv6 obj3 = null;

        // Validates entered IPv4 and IPv6 addresses
        private void btnValidate_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(textBoxIPv4.Text) && !string.IsNullOrWhiteSpace(textBoxIPv6.Text))
                {
                    string ipAddressV4 = textBoxIPv4.Text.Trim();
                    obj2 = new IPv4();
                    obj2.Validate(ipAddressV4);

                    string ipAddressV6 = textBoxIPv6.Text.Trim();
                    obj3 = new IPv6();
                    obj3.Validate(ipAddressV6);

                    // Record IPv4, IPv6, and timestamp to text and binary files

                    //if (!Directory.Exists(path)) Directory.CreateDirectory(path);
                    String InfoData = $"{textBoxIPv4.Text}\t{textBoxIPv6.Text}\t {DateTime.Now.ToString("yyyy/M/d h:mm:ss tt", System.Globalization.CultureInfo.InvariantCulture)}\n";
                    createTextFile(InfoData);
                    createBinaryFile(InfoData);
                }
                else
                {
                    
                     MessageBox.Show("Please enter an IPv4 and IPv6 address.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            textBoxIPv4.Clear();
            textBoxIPv6.Clear();
            textBoxIPv4.Focus();
        }


        // Reads and displays recorded IP validation data
        private void btnReadnDisplay_Click(object sender, EventArgs e)
        {
            


            FileStream fs = null;
            try
            {
                fs = new FileStream(textFilePath, FileMode.OpenOrCreate,
                    FileAccess.Read);

                StreamReader textIn = new StreamReader(fs);
                string textToPrint = "IP v4 \t\t IP v6\t\t\t Date\n";

                string content = textIn.ReadToEnd();
                textToPrint += content;

                if (content != null && content.Trim() != null)
                {
                    MessageBox.Show(textToPrint, "IP Validation - Natalia Herrera", MessageBoxButtons.OK);
                }
                else
                    MessageBox.Show("There are no registers.", "IP Validation - Natalia Herrera", MessageBoxButtons.OK);
                // close the input stream for the text file
                textIn.Close();
            }
            catch (IOException ex)
            { MessageBox.Show(ex.Message, "IOException"); }
            finally { if (fs != null) fs.Close(); }
        }

        public void createTextFile(string dataInfo)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(textFilePath, true))
                {
                    writer.WriteLine(dataInfo);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error writing to text file: {ex.Message}", "Error");
            }
        }

        public void createBinaryFile(string dataInfo)
        {
            try
            {
                using (FileStream fs = new FileStream(binaryFilePath, FileMode.Append, FileAccess.Write))
                using (BinaryWriter writer = new BinaryWriter(fs))
                {
                    writer.Write(dataInfo);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error writing to binary file: {ex.Message}", "Error");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Calculate the time elapsed since the program started
            TimeSpan totalTime = DateTime.Now - startTime;

            // Format the pass by time as a string
            string formattedTime = FormatTotalTime(totalTime);

            if (MessageBox.Show("Do you want to quit this app? " + " You have been here " + formattedTime, "Exit ", MessageBoxButtons.YesNo, MessageBoxIcon.Question).ToString() == "Yes")
            {
                this.Close();
            }
        }

        private string FormatTotalTime(TimeSpan totalTime)
        {
            // Method to format the total time elapsed as "X minutes Y seconds".
            string formattedTime = $"{totalTime.Minutes} minutes {totalTime.Seconds} seconds";
            return formattedTime;

        }
    }
}

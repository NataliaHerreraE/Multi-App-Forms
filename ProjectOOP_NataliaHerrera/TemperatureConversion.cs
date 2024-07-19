using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

//Name: Natalia Andrea Herrera Espinosa
//date: 2023-11-16
//description: Final Project : design temperature and money exchange

// Name: Natalia Andrea Herrera Espinosa
//date: 2023-11-20
//description: Final Project : temperature conversion code

namespace ProjectOOP_NataliaHerrera
{

    public partial class TemperatureConversion : Form
    {
        public TemperatureConversion()
        {
            InitializeComponent();
            startTime = DateTime.Now;
        }


        private DateTime startTime;

        static string dir = @".\files\";
        string textFilePath = dir + "TempConversions.txt";
        string binaryFilePath = dir + "TempConversionsB.txt";
        //string title = "Conversion App";
        // Temperature temperature = null;
        CtoF celsius = null;
        FtoC Fahrenheit = null;


        private void TemperatureConversion_Load(object sender, EventArgs e)
        {
            // default select
            radioCtoF.Checked = true;

            textTemp1.Focus();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            string messageColor = ""; // Initialize the variable

            try
            {
                // Extract the temperature value from textTemp1 textbox
                double temperature = Convert.ToDouble(textTemp1.Text.Trim());
                Regex myRegex = new Regex(@"^-?(\d{0,3})(\.\d*)?$"); // Regex pattern to match valid number formats

                // Check if the input temperature matches the regex pattern
                if (myRegex.IsMatch(textTemp1.Text)) 
                {
                    double num1 = Convert.ToDouble(textTemp1.Text);

                    if (radioCtoF.Checked)  // If Celsius to Fahrenheit conversion is selected
                    {
                        celsius = new CtoF(); // Create an instance of the CtoF class 

                        try
                        {
                            // Perform Celsius to Fahrenheit conversion and display the result in textTemp2 textbox
                            textTemp2.Text = celsius.Convert(num1).ToString();
                            // Create a string containing the conversion details, timestamp, and message description
                            String InfoData = $"{num1} {labelInput1.Text} = {textTemp2.Text} {labelInput2.Text},\t {DateTime.Now.ToString("yyyy/M/d h:mm:ss tt", System.Globalization.CultureInfo.InvariantCulture)} \t{MessageDescription(num1)}\n";
                            createTextFile(InfoData);  // Write the conversion details to a text file
                            createBinaryFile(InfoData); // Write the conversion details to a binary file
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message); // Display any exception occurred during conversion
                        }
                    }
                    else // If Fahrenheit to Celsius conversion is selected
                    {
                        Fahrenheit = new FtoC(); // Create an instance of the FtoC class (assuming it handles Fahrenheit to Celsius conversion)

                        try
                        {
                            // Perform Fahrenheit to Celsius conversion and display the result in textTemp2 textbox
                            textTemp2.Text = Fahrenheit.Convert(num1).ToString();
                            // Create a string containing the conversion details, timestamp, and message description
                            String InfoData = $"{num1} {labelInput1.Text} = {textTemp2.Text} {labelInput2.Text},\t {DateTime.Now.ToString("yyyy/M/d h:mm:ss tt", System.Globalization.CultureInfo.InvariantCulture)}\t {MessageDescription(Convert.ToDouble(textTemp2.Text))}\n";
                            createTextFile(InfoData);
                            createBinaryFile(InfoData);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please, enter a valid number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception)
            {
                labelInput1.ForeColor = Color.Red;
                MessageBox.Show("Please, enter a number to be converted.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    
        private string MessageDescription(double celsiusTemperature)
        {
            //set the message and color

            if (celsiusTemperature >= 100)
            {
                textBoxMessage.ForeColor = Color.Red;
                textTemp1.ForeColor = Color.Red;
                textTemp2.ForeColor = Color.Red;
                textTemp1.Font = new Font(textTemp1.Font, FontStyle.Regular);
                textTemp2.Font = new Font(textTemp1.Font, FontStyle.Regular);
                textBoxMessage.Text = "Water boils";
            }
            else if (celsiusTemperature < 100 && celsiusTemperature >= 40)
            {
                textBoxMessage.ForeColor = Color.Red;
                textTemp1.ForeColor = Color.Red;
                textTemp2.ForeColor = Color.Red;
                textTemp1.Font = new Font(textTemp1.Font, FontStyle.Regular);
                textTemp2.Font = new Font(textTemp1.Font, FontStyle.Regular);
                textBoxMessage.Text = "Hot Bath";
            }
            else if (celsiusTemperature < 40 && celsiusTemperature >= 37)
            {
                textBoxMessage.ForeColor = Color.Orange;
                textTemp1.ForeColor = Color.Orange;
                textTemp2.ForeColor = Color.Orange;
                textTemp1.Font = new Font(textTemp1.Font, FontStyle.Regular);
                textTemp2.Font = new Font(textTemp1.Font, FontStyle.Regular);
                textBoxMessage.Text = "Body temperature";
            }
            else if (celsiusTemperature < 37 && celsiusTemperature >= 30)
            {
                textBoxMessage.ForeColor = Color.Orange;
                textTemp1.ForeColor = Color.Orange;
                textTemp2.ForeColor = Color.Orange;
                textTemp1.Font = new Font(textTemp1.Font, FontStyle.Regular);
                textTemp2.Font = new Font(textTemp1.Font, FontStyle.Regular);
                textBoxMessage.Text = "Beach weather";
            }
            else if (celsiusTemperature < 30 && celsiusTemperature >= 21)
            {
                textBoxMessage.ForeColor = Color.Green;
                textTemp1.ForeColor = Color.Green;
                textTemp2.ForeColor = Color.Green;
                textTemp1.Font = new Font(textTemp1.Font, FontStyle.Regular);
                textTemp2.Font = new Font(textTemp1.Font, FontStyle.Regular);
                textBoxMessage.Text = "Room temperature";
            }
            else if (celsiusTemperature < 21 && celsiusTemperature > 10)
            {
                textBoxMessage.ForeColor = Color.Blue;
                textTemp1.ForeColor = Color.Blue;
                textTemp2.ForeColor = Color.Blue;
                textTemp1.Font = new Font(textTemp1.Font, FontStyle.Regular);
                textTemp2.Font = new Font(textTemp1.Font, FontStyle.Regular);
                textBoxMessage.Text = "Cold Day";
            }
            else if (celsiusTemperature < 10 && celsiusTemperature >= 0)
            {
                textBoxMessage.ForeColor = Color.Blue;
                textTemp1.ForeColor = Color.Blue;
                textTemp2.ForeColor = Color.Blue;
                textTemp1.Font = new Font(textTemp1.Font, FontStyle.Regular);
                textTemp2.Font = new Font(textTemp1.Font, FontStyle.Regular);
                textBoxMessage.Text = "Freezing point of water";
            }
            else if (celsiusTemperature < 0 && celsiusTemperature >= -18)
            {
                textBoxMessage.ForeColor = Color.Black;
                textTemp1.ForeColor = Color.Black;
                textTemp2.ForeColor = Color.Black;
                textTemp1.Font = new Font(textTemp1.Font, FontStyle.Regular);
                textTemp2.Font = new Font(textTemp1.Font, FontStyle.Regular);
                textBoxMessage.Text = "Very cold day";
            }

            else if (celsiusTemperature == -40)
            {//bold also
                textBoxMessage.ForeColor = Color.Black;
                textTemp1.ForeColor = Color.Black;
                textTemp2.ForeColor = Color.Black;
                textTemp1.Font = new Font(textTemp1.Font, FontStyle.Bold);
                textTemp2.Font = new Font(textTemp1.Font, FontStyle.Bold);
                textBoxMessage.Text = "Extremely Cold Day (and the same number!)";
            }

            return textBoxMessage.Text;
        }

        private void btnReadFile_Click(object sender, EventArgs e)
        {
            FileStream fs2 = null;
            try
            {
                fs2 = new FileStream(textFilePath, FileMode.OpenOrCreate,
                    FileAccess.Read);
               
                StreamReader textIn = new StreamReader(fs2);
                string textToPrint = "From/To\t\t Date&Time\t\t Message\n";
               
                string content = textIn.ReadToEnd();
                textToPrint += content;

                if (content != null && content.Trim() != null)
                {
                    MessageBox.Show(textToPrint, "Temperature Conversion - Natalia Herrera", MessageBoxButtons.OK);
                }
                else
                    MessageBox.Show("There are no registers.", "Temperature Conversion - Natalia Herrera", MessageBoxButtons.OK);
                // close the input stream for the text file
                textIn.Close();
            }
            catch (IOException ex)
            { MessageBox.Show(ex.Message, "IOException"); }
            finally { if (fs2 != null) fs2.Close(); }
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

        private string FormatTotalTime(TimeSpan totalTime)
        {
            // Method to format the total time elapsed as "X minutes Y seconds".
            string formattedTime = $"{totalTime.Minutes} minutes {totalTime.Seconds} seconds";
            return formattedTime;

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

        private void radioCtoF_CheckedChanged(object sender, EventArgs e)
        {
            if (radioCtoF.Checked)
            {
                labelInput1.Text = "°C";
                labelInput2.Text = "°F";

            }
            textTemp2.Clear();
            textTemp1.Clear();
            textBoxMessage.Clear();
        }

        private void radioFtoC_CheckedChanged(object sender, EventArgs e)
        {
            if (radioFtoC.Checked)
            {
                labelInput1.Text = "°F";
                labelInput2.Text = "°C";

            }
            textTemp2.Clear();
            textTemp1.Clear();
            textBoxMessage.Clear();
        }

        private void textTemp2_TextChanged(object sender, EventArgs e)
        {
            labelInput1.ForeColor = Color.Black;
            textTemp1.ForeColor = Color.Black;
            textTemp2.Clear();
            textBoxMessage.Clear();
        }

        
    }
}


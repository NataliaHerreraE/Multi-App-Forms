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
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

// Name: Natalia Andrea Herrera Espinosa
//date: 2023-11-09
//description: Final Project : design temperature and money exchange


// Name: Natalia Andrea Herrera Espinosa
//date: 2023-11-18
//description: Final Project : money exchange code

// Name: Natalia Andrea Herrera Espinosa
//date: 2023-11-20
//description: Final Project : temperature conversion code


//
/*=================================
 *  general exchange factor nov 18/2023
 *=================================
 * CAD 1.37 = 1 USD
 * EUR 0.92 = 1 USD
 * GBP 0.80 = 1 USD
 * YEN 149.53 = 1 USD
 * COP 4066.43 = 1 USD
 */
namespace ProjectOOP_NataliaHerrera
{
    public partial class MoneyExchange : Form
    {
        public MoneyExchange()
        {
            InitializeComponent();
            startTime = DateTime.Now; // Capture the start time when the MoneyExchange form initializes
        }

        // Define file paths for storing data
        static string dir = @".\files\";
        string textFilePath = dir + "MoneyConversions.txt";
        string binaryFilePath = dir + "MoneyConversionsB.txt";
        //string title = "Money Exchange App";

        private DateTime startTime; // Variable to store the start time of the MoneyExchange form

        // Event handler when the MoneyExchange form loads
        private void MoneyExchange_Load(object sender, EventArgs e)
        {
            // default select
            radioCAD.Checked = true;

        }

        // Method to format the total elapsed time
        private string FormatTotalTime(TimeSpan totalTime)
        {
            // Method to format the total time elapsed as "X minutes Y seconds".
            string formattedTime = $"{totalTime.Minutes} minutes {totalTime.Seconds} seconds";
            return formattedTime;
        }

        // Event handler for currency conversion button click
        private void btnConvertCurrency_Click(object sender, EventArgs e)
        {


            String InfoData;
            decimal amount = 0;

            try
            {
                amount = Convert.ToDecimal(textinputToConvert.Text);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: " + ex.Message, "Error ");
            }

            // Code for currency conversion based on selected radio button
            // Each block handles a different currency conversion based on the selected radio button



            if (radioCAD.Checked)
            {
                ExchangeCAD conversorCAD = new ExchangeCAD();

                textBoxCAD.Text = textinputToConvert.Text;
                textBoxUSD.Text = conversorCAD.CADtoUSD(amount).ToString();
                textBoxEUR.Text = conversorCAD.CADtoEUR(amount).ToString();
                textBoxGBP.Text = conversorCAD.CADtoGBP(amount).ToString();
                textBoxJPY.Text = conversorCAD.CADtoJPY(amount).ToString();
                textBoxCOP.Text = conversorCAD.CADtoCOP(amount).ToString();

                InfoData = textBoxCAD.Text + " CAD =  " + textBoxCAD.Text + " CAD; " + textBoxUSD.Text + " USD; " + textBoxEUR.Text + " EUR; " 
                           + textBoxGBP.Text + " GBP; " + textBoxJPY.Text + " JPY; " + textBoxCOP.Text + " COP;";
                createTextFile(textFilePath, InfoData);
                createBinaryFile(binaryFilePath, InfoData);

            }
            else if (radioUSD.Checked)
            {
                ExchangeUSD conversorUSD = new ExchangeUSD();

                textBoxUSD.Text = textinputToConvert.Text;
                textBoxCAD.Text = conversorUSD.USDtoCAD(amount).ToString();
                textBoxEUR.Text = conversorUSD.USDtoEUR(amount).ToString();
                textBoxGBP.Text = conversorUSD.USDtoGBP(amount).ToString();
                textBoxJPY.Text = conversorUSD.USDtoJPY(amount).ToString();
                textBoxCOP.Text = conversorUSD.USDtoCOP(amount).ToString();

                InfoData = textBoxUSD.Text + " USD =  " + textBoxUSD.Text + " USD; " + textBoxCAD.Text + " CAD; " + textBoxEUR.Text + " EUR; "
                            + textBoxGBP.Text + " GBP; " + textBoxJPY.Text + " JPY; " + textBoxCOP.Text + " COP;" ;
                createTextFile(textFilePath, InfoData);
                createBinaryFile(binaryFilePath, InfoData);

            }
            else if (radioEUR.Checked)
            {
                ExchangeEUR conversorEUR = new ExchangeEUR();

                textBoxEUR.Text = textinputToConvert.Text;
                textBoxCAD.Text = conversorEUR.EURtoCAD(amount).ToString();
                textBoxUSD.Text = conversorEUR.EURtoUSD(amount).ToString();
                textBoxGBP.Text = conversorEUR.EURtoGBP(amount).ToString();
                textBoxJPY.Text = conversorEUR.EURtoJPY(amount).ToString();
                textBoxCOP.Text = conversorEUR.EURtoCOP(amount).ToString();

                InfoData = textBoxEUR.Text + " EUR =  " + textBoxEUR.Text + " EUR; " + textBoxCAD.Text + " CAD; " + textBoxUSD.Text + " USD; " 
                           + textBoxGBP.Text + " GBP; " + textBoxJPY.Text + " JPY; " + textBoxCOP.Text + " COP;" ;
                createTextFile(textFilePath, InfoData);
                createBinaryFile(binaryFilePath, InfoData);
            }
            else if (radioGBP.Checked)
            {
                ExchangeGBP conversorGBP = new ExchangeGBP();

                textBoxGBP.Text = textinputToConvert.Text;
                textBoxCAD.Text = conversorGBP.GBPtoCAD(amount).ToString();
                textBoxUSD.Text = conversorGBP.GBPtoUSD(amount).ToString();
                textBoxEUR.Text = conversorGBP.GBPtoEUR(amount).ToString();
                textBoxJPY.Text = conversorGBP.GBPtoJPY(amount).ToString();
                textBoxCOP.Text = conversorGBP.GBPtoCOP(amount).ToString();

                InfoData = textBoxGBP.Text + " GBP =  " + textBoxGBP.Text + " GBP; " + textBoxCAD.Text + " CAD; " + textBoxUSD.Text + " USD; " 
                           + textBoxEUR.Text + " EUR; " + textBoxJPY.Text + " JPY; " + textBoxCOP.Text + " COP;";
                createTextFile(textFilePath, InfoData);
                createBinaryFile(binaryFilePath, InfoData);

            }
            else if (radioJPY.Checked)
            {
                ExchangeJPY conversorJPY = new ExchangeJPY();

                textBoxJPY.Text = textinputToConvert.Text;
                textBoxCAD.Text = conversorJPY.JPYtoCAD(amount).ToString();
                textBoxUSD.Text = conversorJPY.JPYtoUSD(amount).ToString();
                textBoxEUR.Text = conversorJPY.JPYtoEUR(amount).ToString();
                textBoxGBP.Text = conversorJPY.JPYtoGBP(amount).ToString();
                textBoxCOP.Text = conversorJPY.JPYtoCOP(amount).ToString();

                InfoData = textBoxJPY.Text + " JPY =  " + textBoxJPY.Text + " JPY; " + textBoxCAD.Text + " CAD; " + textBoxUSD.Text + " USD; " 
                           + textBoxEUR.Text + " EUR; " + textBoxGBP.Text + " GBP; " + textBoxCOP.Text + " COP;";
                createTextFile(textFilePath, InfoData);
                createBinaryFile(binaryFilePath, InfoData);

            }
            // Methods to create text and binary files with the converted data
            // These methods write the converted data along with timestamps to text and binary files
   
        }

        // Method to write data to a text file
        public void createTextFile(string textFilePath, string dataInfo)
        {
            // Writing data along with timestamps to a text file
            DateTime currentDate = DateTime.Now; // Gets the current date and time.
            string dateText = currentDate.ToString("yyyy/M/d h:mm:ss tt", System.Globalization.CultureInfo.InvariantCulture);
            // Replaces tabs with commas in the input string.

            try
            {
                using (StreamWriter writer = new StreamWriter(textFilePath, true))
                {
                    writer.WriteLine($"{dateText}\n{dataInfo}");
                }

            }
            catch (Exception ex)
            {
                
                MessageBox.Show($"Error writing to text file: {ex.Message}", "Error");
            }

        }

        // Method to write data to a binary file
        public void createBinaryFile(string binaryFilePath, string dataInfo)
        {
            // Writing data along with timestamps to a binary file
            DateTime currentDate = DateTime.Now;
            string dataFormatada = currentDate.ToString("yyyy/M/d h:mm:ss tt", System.Globalization.CultureInfo.InvariantCulture);

            try
            {
                //FileStream provides a stream for handling operations on files. It allows reading from or writing to a file in a synchronous manner.
                // is used to initialize a new instance of the FileStream class. It opens a file specified by path with the given mode and access.
                using (FileStream fs = new FileStream(binaryFilePath, FileMode.Append, FileAccess.Write))
                //mode: Determines how the file should be opened. FileMode.Append means the data will be appended to the end of the file if it already exists, or a new file will be created if it doesn’t exist.
                //access: Specifies the operations that can be performed on the file. 
                //FileAccess.Write indicates that the file can be written to.

                using (BinaryWriter writer = new BinaryWriter(fs))
                {
                    writer.Write(dataFormatada);
                    writer.Write(dataInfo);
                    writer.Close();
                }
                

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error writing to binary file: {ex.Message}", "Error");
            }
        }

        // Event handler for reading and displaying data from the text file
        private void btnReadDisplay_Click(object sender, EventArgs e)
        {

            // Reading data from the text file and displaying it in a MessageBox
            // It extracts data based on a specific pattern from the text file

            string patternData = @"^\d{4}/\d{2}/\d{2}\s\d{1,2}:\d{2}:\d{2}\s(AM|PM)$";

            try
            {
                using (StreamReader reader = new StreamReader(textFilePath))
                {
                    StringBuilder displayText = new StringBuilder();

                    for (int i = 0; i < 1000; i++)
                    {
                        // Read a line from the text file
                        string line = reader.ReadLine();

                        // Check if the line is not null (file not ended)
                        if (line != null)
                        {
                            string[] columns = line.Split(';');
                            if (Regex.IsMatch(columns[0], patternData))
                            {
                                displayText.AppendLine($"{columns[0]}");
                            }
                            else
                            {
                                displayText.AppendLine($"{columns[0]} {columns[1]} {columns[2]} {columns[3]} {columns[4]} {columns[5]}");
                            }

                        }
                        else
                        {
                            // Break the loop if there are no more lines in the file
                            break;
                        }
                    }

                    MessageBox.Show(displayText.ToString(), "Money Exchange - Natalia Herrera");
                }


            }
            catch (Exception ex)
            {
                // If an exception occurs during the try block, display an error message
                MessageBox.Show($"Error reading from text file: {ex.Message}", "Error");
            }
        }



        // Classes for currency exchanges
        // Each class contains methods to convert a specific currency to other currencies

        public class ExchangeCAD
        {

            /*
            *   exchange factor nov 18/2023
            *
            * CAD 1.00 = 0.73 USD
            * CAD 1.00 = 0.67 EUR
            * CAD 1.00 = 0.59 GBP
            * CAD 1.00 = 109.03 JPY
            * CAD 1.00 = 2964.90 COP
            */

            public decimal CADtoUSD(decimal amount)
            {
                return Math.Round(amount * 0.73m, 2);
            }

            public decimal CADtoEUR(decimal amount)
            {
                return Math.Round(amount * 0.67m, 2);
            }

            public decimal CADtoGBP(decimal amount)
            {
                return Math.Round(amount * 0.59m, 2);
            }

            public decimal CADtoJPY(decimal amount)
            {
                return Math.Round(amount * 109.03m, 2);
            }

            public decimal CADtoCOP(decimal amount)
            {
                return amount * 2964.90m;
            }
        }

        public class ExchangeUSD
        {
            /*
            *   exchange factor nov 18/2023
            *
            * USD 1.00 = 1.37 CAD
            * USD 1.00 = 0.92 EUR
            * USD 1.00 = 0.80 GBP
            * USD 1.00 = 149.73 JPY
            * USD 1.00 = 4066.94 COP
            */


            public decimal USDtoCAD(decimal amount)
            {
                return Math.Round(amount * 1.37m, 2);
            }

            public decimal USDtoEUR(decimal amount)
            {
                return Math.Round(amount * 0.92m, 2);
            }

            public decimal USDtoGBP(decimal amount)
            {
                return Math.Round(amount * 0.80m, 2);
            }

            public decimal USDtoJPY(decimal amount)
            {
                return Math.Round(amount * 149.73m, 2);
            }

            public decimal USDtoCOP(decimal amount)
            {
                return amount * 4066.94m;
            }
        }

        public class ExchangeEUR
        {
            /*
           *   exchange factor nov 18/2023
           *
           * EUR 1.00 = 1.50 CAD
           * EUR 1.00 = 1.09 USD
           * EUR 1.00 = 0.88 GBP
           * EUR 1.00 = 163.35 JPY
           * EUR 1.00 = 4437.16 COP
           */

            public decimal EURtoCAD(decimal amount)
            {
                return Math.Round(amount * 1.50m, 2);
            }

            public decimal EURtoUSD(decimal amount)
            {
                return Math.Round(amount * 1.09m, 2);
            }

            public decimal EURtoGBP(decimal amount)
            {
                return Math.Round(amount * 0.88m, 2);
            }

            public decimal EURtoJPY(decimal amount)
            {
                return Math.Round(amount * 163.35m, 2);
            }

            public decimal EURtoCOP(decimal amount)
            {
                return amount * 4437.16m;
            }
        }

        public class ExchangeGBP
        {
            /*
             *   exchange factor nov 18/2023
             *
             * GBP 1.00 = 1.71 CAD
             * GBP 1.00 = 1.14 EUR
             * GBP 1.00 = 1.25 USD
             * GBP 1.00 = 186.52 JPY
             * GBP 1.00 = 5066.94 COP
             */

            public decimal GBPtoCAD(decimal amount)
            {
                return Math.Round(amount * 1.71m, 2);
            }

            public decimal GBPtoEUR(decimal amount)
            {
                return Math.Round(amount * 1.14m, 2);
            }

            public decimal GBPtoUSD(decimal amount)
            {
                return Math.Round(amount * 1.25m, 2);
            }

            public decimal GBPtoJPY(decimal amount)
            {
                return Math.Round(amount * 186.52m, 2);
            }

            public decimal GBPtoCOP(decimal amount)
            {
                return amount * 5066.94m;
            }
        }


        public class ExchangeJPY
        {
            /*
            *   exchange factor nov 18/2023
            *
            * JPY 1.00 = 0.0092 CAD
            * JPY 1.00 = 0.0061 EUR
            * JPY 1.00 = 0.0067 USD
            * JPY 1.00 = 0.0054 GBP
            * JPY 1.00 = 27.16 COP
            */

            public decimal JPYtoCAD(decimal amount)
            {
                return Math.Round(amount * 0.0092m, 2);
            }

            public decimal JPYtoEUR(decimal amount)
            {
                return Math.Round(amount * 0.0061m, 2);
            }

            public decimal JPYtoUSD(decimal amount)
            {
                return Math.Round(amount * 0.0067m, 2);
            }

            public decimal JPYtoGBP(decimal amount)
            {
                return Math.Round(amount * 0.0054m, 2);
            }

            public decimal JPYtoCOP(decimal amount)
            {
                return amount * 27.16m;
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

    }
    

}

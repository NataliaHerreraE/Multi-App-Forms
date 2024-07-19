using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
    public partial class LottoMax : Form
    {
        public LottoMax()
        {
            // Initializes the form components and sets the start time.
            InitializeComponent();
            startTime = DateTime.Now;
        }

        // Path and file name for storing data to a text file.
        string dir = @".\files\"; // Specifies the directory where the file will be saved.
        string file = "LottoNbrs.txt"; // Specifies the name of the text file.
        string name = "Max "; // Specifies the name of the Lotto game.
        private DateTime startTime; // Stores the start time of the application.

        private void LottoMax_Load(object sender, EventArgs e)
        {
            // Event handler for when the Lotto649 form is loaded.
            // Checks if the specified directory exists; if not, creates the directory.
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }
        }

        private void btnLMaxGenerate_Click(object sender, EventArgs e)
        {

            int range = 8;    // Quantity of random numbers to generate.
            //label2.Text = "";
            //label2.Text = controlRange(range);     // label2 = "Range" random numbers
            textBox1.Text = "";
            textBox1.Text = rangeSeq(range);   // Generates and displays "range" random numbers in textBox1.

            string txt = textBox1.Text;
            createFile(dir, file, name, txt);    // Displays a message box with the specified title and message.
        }

        private void btnLMaxReadDsiaply_Click(object sender, EventArgs e)
        {

            // Event handler for the button click to read and display data from the text file.
            string path = Path.Combine(dir, file); // Combines the directory and file name to create the complete file path.
            string title = "Lotto Max Natalia Herrera"; // Title for the message box.
            string textToPrint = ""; // Variable to store the text read from the file.
            FileStream stream = null; // FileStream to read from the file.
            //byte counter = 0;
            //int numexhibit = 10;

            try
            {
                // Opens the file in read mode and reads the data line by line.
                using (stream = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read))
                using (StreamReader reader = new StreamReader(stream))
                {
                    // Reads lines from the file until the end of the file is reached.
                    while (reader.Peek() != -1)
                    {
                        string line = reader.ReadLine();
                        textToPrint += line + "\r\n"; // Appends each line to the textToPrint variable.
                    }

                    // Calls the showMsg method to display the read text in a message box.
                    showMsg(title, textToPrint);
                    reader.Close();
                }
            }
            catch (IOException ex)
            {
                // Displays an error message if an IOException occurs while reading the file.
                MessageBox.Show("IO Exception\n" + ex.Message);
            }
            finally
            {
                // Closes the FileStream after reading the file.
                if (stream != null)
                    stream.Close();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Event handler for the button click to exit the application.
            // Calculates the time elapsed since the program started.
            TimeSpan totalTime = DateTime.Now - startTime;

            // Formats the passed time as a string using the FormatTotalTime method.
            string formattedTime = FormatTotalTime(totalTime);

            // Displays a confirmation dialog with the elapsed time.
            if (MessageBox.Show("Do you want to quit this app? " + " You have been here " + formattedTime, "Exit ", MessageBoxButtons.YesNo, MessageBoxIcon.Question).ToString() == "Yes")
            {
                this.Close(); // Exits the application if the user clicks "Yes".
            }
        }
        private string FormatTotalTime(TimeSpan totalTime)
        {
            // Method to format the total time elapsed as "X minutes Y seconds".
            string formattedTime = $"{totalTime.Minutes} minutes {totalTime.Seconds} seconds";
            return formattedTime;
        }

        private void showMsg(string title, string msg)
        {
            // Method to display a message box with the specified title and message.
            MessageBox.Show(msg.Trim(), title);
        }

        public string rangeSeq(int range)
        {
            // Method to generate a sequence of unique random numbers within a specified range in this case 50.
            Random random = new Random();
            string tempString = "";   // Variable to store the generated random numbers as a string.

            List<int> numbers = Enumerable.Range(1, 50).ToList();   // Creates a list of numbers from 1 to 50.

            for (int i = 0; i < range; i++)
            {
                int index = random.Next(numbers.Count);
                int randomNumber = numbers[index];

                tempString += randomNumber.ToString() + "\t";     // Adds the random number followed by a TAB.
                numbers.RemoveAt(index);                          // Removes the generated number to prevent repetition.
            }

            string txt = tempString.Remove(tempString.Length - 1, 1);   // Removes the last TAB and returns the random numbers as a string.

            return (txt);
        }

        public string controlRange(int range)
        {
            // Method to generate a sequence of random single-digit numbers within a specified range.
            Random random = new Random();
            string tempString = "";   // Variable to store the generated random numbers as a string.

            List<int> numbers = Enumerable.Range(1, 9).ToList();   // Creates a list of numbers from 1 to 9 (single-digit numbers). 

            for (int i = 0; i < range; i++)
            {
                int index = random.Next(numbers.Count);
                int randomNumber = numbers[index];

                tempString += randomNumber.ToString() + " ";      // Adds the random single-digit number followed by a space.
                // Note: The line below is commented out, so repeating numbers are not removed in this method.
                //numbers.RemoveAt(index);                                    // Remove all the repeating numbers. 
            }

            return tempString;  // Returns the random single-digit numbers as a string.
        }


        public void createFile(string dir, string file, string name, string txt)
        {

            // Method to create a text file and write data into it.
            string path = Path.Combine(dir, file); // Combines the directory and file name to create the complete file path.

            DateTime currentDate = DateTime.Now; // Gets the current date and time.
            string dateText = currentDate.ToString("yyyy/M/d h:mm:ss tt", System.Globalization.CultureInfo.InvariantCulture);
            txt = txt.Replace("\t", ","); // Replaces tabs with commas in the input string.
            
            try
            {
                if (!Directory.Exists(dir))
                {
                    Directory.CreateDirectory(dir); // Creates the directory if it does not exist.
                }
                else
                {
                    StreamWriter sw = new StreamWriter(path, true);   // Initializes a StreamWriter to write to the file (append mode).
                    // Writes data into the file in the format: "name, date, random_numbers, Extra extra_numbers".
                    sw.WriteLine($"{name}, {dateText}, {txt.Remove(txt.LastIndexOf(","))}, Extra " + txt.Substring(txt.LastIndexOf(",") + 1));  //Write a line of text

                    sw.Close();  //Close the file
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: " + ex.Message, "Error " + name);  // Displays an error message if an exception occurs.
            }
        }


    }
}

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
using System.Xml;
// Name: Natalia Andrea Herrera Espinosa
//date: 2023-11-30
//description: Final Project : PARTIAL calculator code

// Name: Natalia Andrea Herrera Espinosa
//date: 2023-12-07
//description: Final Project : final calculator code with some errors fixed

namespace ProjectOOP_NataliaHerrera
{
    public partial class simpleCalculator : Form
    {
        // Constructor for the calculator form
        public simpleCalculator()
        {
            InitializeComponent();
            calc = new CalculatorEquals();  // Initializes the calculator object
        }

        private CalculatorEquals calc; // Instance of the CalculatorEquals class
        private Boolean operatorOn = false; // Flags for tracking operator and equal button presses
        private Boolean equalOn = false;
        string operation = null; // String to store the ongoing operation
        static string Path = @".\files\"; // Path to file storage
        string textFilePath = Path + "Calculator.txt";  // Path to the text file
        private const string operationsFileName = "CalculatorOperations.xml";  // XML file name
        private DateTime startTime; // Stores the start time when the calculator loads



        private void calculator_Load(object sender, EventArgs e)
        {
            startTime = DateTime.Now;
            if (!Directory.Exists(Path)) Directory.CreateDirectory(Path);
        }

        // Method to handle appending numbers to the operation
        private void NumberToOperation(string number)
        {
            // Checks if the text box is empty or if an operator was previously pressed
            if (textBoxResult.Text == "0" || operatorOn)
            {
                operation = number;
                textBoxResult.Text = number;
            }
            else
            {
                operation += number;
                textBoxResult.Text += number;
            }
            textBoxOperation.Text += number; // Append the number to the operation display
            operatorOn = false;
            equalOn = false;
        }

        // Event handlers for number buttons (0-9)
        // Each button click adds the corresponding number to the ongoing operation

        private void btn1_Click(object sender, EventArgs e)
        {

            NumberToOperation("1");

        }

        private void btn2_Click(object sender, EventArgs e)
        {

            NumberToOperation("2");
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            NumberToOperation("3");
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            NumberToOperation("4");
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            NumberToOperation("5");
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            NumberToOperation("6");
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            NumberToOperation("7");
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            NumberToOperation("8");
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            NumberToOperation("9");
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            NumberToOperation("0");
        }

        private void btnPoint_Click(object sender, EventArgs e)
        {
            // Handles adding a decimal point to the ongoing operation
            // Checks if the text box is empty or an operator was previously pressed

            if (textBoxResult.Text == "" || operatorOn)
            {
                operation = "0.";
                textBoxResult.Text = "0.";
                textBoxOperation.Text = operation;
                operatorOn = false;
                equalOn = false;
            }
            else if (!textBoxResult.Text.Contains("."))
            {
                operation += ".";
                textBoxResult.Text += ".";
                textBoxOperation.Text += ".";
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Clears the text boxes for result and operation
            textBoxResult.Clear();
            textBoxOperation.Clear();
        }

        // Event handlers for arithmetic operation buttons (Add, Subtract, Multiply, Divide)
        // Each button click performs the respective operation
        // It updates the display and prepares for the next number input
        // It also handles writing the operation to a text file and an XML file

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!operatorOn)
            {
                if (!equalOn)
                {
                    calc.Equals(Convert.ToDecimal(textBoxResult.Text));
                }
                calc.Add(Convert.ToDecimal(textBoxResult.Text));
                operatorOn = true;
                textBoxOperation.Text += " + "; // Append the operator to the operation display
                textBoxResult.Clear();
            }
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            if (!operatorOn)
            {
                if (!equalOn)
                {
                    calc.Equals(Convert.ToDecimal(textBoxResult.Text));
                }
                calc.Subtract(Convert.ToDecimal(textBoxResult.Text));
                operatorOn = true;
                textBoxOperation.Text += " - "; // Append the operator to the operation display
                textBoxResult.Clear();
            }
        }

        private void btnMul_Click(object sender, EventArgs e)
        {

            if (!operatorOn)
            {
                if (!equalOn)
                {
                    calc.Equals(Convert.ToDecimal(textBoxResult.Text));
                }
                calc.Multiply(Convert.ToDecimal(textBoxResult.Text));
                operatorOn = true;
                textBoxOperation.Text += " * "; // Append the operator to the operation display
                textBoxResult.Clear();
            }
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            if (!operatorOn)
            {
                if (!equalOn)
                {
                    calc.Equals(Convert.ToDecimal(textBoxResult.Text));
                }
                calc.Divide(Convert.ToDecimal(textBoxResult.Text));
                operatorOn = true;
                textBoxOperation.Text += " / "; // Append the operator to the operation display
                textBoxResult.Clear();
            }
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            //write text file
            FileStream fs1 = new FileStream(textFilePath, FileMode.Append, FileAccess.Write);
            StreamWriter objW = new StreamWriter(fs1);

            if (equalOn == true)
            {
                int index = textBoxResult.Text.IndexOf(" ");
                textBoxResult.Text = calc.CurrentValue.ToString() + textBoxResult.Text.Substring(index);
                calc.Equals();
                operatorOn = true;
                textBoxResult.Text = calc.CurrentValue.ToString();
               
                SaveOperationToXML(textBoxOperation.Text);
               // createTextFile(textBoxOperation.Text);
            }
            else
            {
                calc.Equals(Convert.ToDecimal(textBoxResult.Text));
                operatorOn = true;
                textBoxResult.Text += textBoxResult.Text + " = ";
                textBoxOperation.Text += " = ";
                textBoxResult.Text = calc.CurrentValue.ToString();
                textBoxOperation.Text += calc.CurrentValue.ToString();
                equalOn = true;
                
                SaveOperationToXML(textBoxOperation.Text);
               // createTextFile(textBoxOperation.Text);
            }


            objW.Write(textBoxOperation.Text + "\n"); // Writes the operation followed by a newline

            objW.Close();
            fs1.Close();

        }

        public void createTextFile(string operation)
        {
            string dataInfo = $"{operation}";

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

        private void SaveOperationToXML(string operation)
        {
            string xmlFilePath = Path + operationsFileName;

            XmlDocument xmlDoc = new XmlDocument();

            // Check if the file exists, if not, create a new XML structure
            if (!File.Exists(xmlFilePath))
            {
                XmlDeclaration xmlDeclaration = xmlDoc.CreateXmlDeclaration("1.0", "UTF-8", null);
                xmlDoc.AppendChild(xmlDeclaration);

                XmlElement root = xmlDoc.CreateElement("CalculatorOperations");
                xmlDoc.AppendChild(root);
            }
            else
            {
                xmlDoc.Load(xmlFilePath);
            }

            string operationString = $"{operation}";

            XmlElement operationElement = xmlDoc.CreateElement("Operation");
            operationElement.InnerText = operationString;

            xmlDoc.DocumentElement?.AppendChild(operationElement);

            // Save the modified XML document to the file
            xmlDoc.Save(xmlFilePath);
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

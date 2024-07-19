using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectOOP_NataliaHerrera
{
    internal class IPv4 : ValidateIP
    {
        public override void Validate(string ipToValidate)
        {

            try
            {
                Regex ipv4Regex = new Regex(@"^(25[0-5]|2[0-4]\d|[0-1]?\d?\d)(\.(25[0-5]|2[0-4]\d|[0-1]?\d?\d)){3}$");

                if (ipv4Regex.IsMatch(ipToValidate))
                {
                    MessageBox.Show(ipToValidate + "\nThe IP v4 is correct.", "Valid IP", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show(ipToValidate + "\nThe IP must have 4 bytes \ninteger number between 0 to 255\n separeted by a dot (255.255.255.255).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                  
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }

}

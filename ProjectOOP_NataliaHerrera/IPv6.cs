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
    internal class IPv6 : ValidateIP
    {
        public override void Validate(string ipToValidate)
        {

            try
            {
                Regex ipv6Regex = new Regex(@"^(([0-9a-fA-F]{1,4}:){7}[0-9a-fA-F]{1,4}|([0-9a-fA-F]{1,4}:){1,7}:
                |(([0-9a-fA-F]{1,4}:){1,6}|:):[0-9a-fA-F]{1,4}|(([0-9a-fA-F]{1,4}:){1,5}|(:[0-9a-fA-F]{1,4}){1,2}|:)
                :(:[0-9a-fA-F]{1,4}){1,2}|(([0-9a-fA-F]{1,4}:){1,4}|(:[0-9a-fA-F]{1,4}){1,3}|:):((:[0-9a-fA-F]{1,4}){1,3}|
                :[0-9a-fA-F]{1,4})|(([0-9a-fA-F]{1,4}:){1,3}|(:[0-9a-fA-F]{1,4}){1,4}|:):((:[0-9a-fA-F]{1,4}){1,4}|:[0-9a-fA-F]{1,4})
                |(([0-9a-fA-F]{1,4}:){1,2}|(:[0-9a-fA-F]{1,4}){1,5}|:):((:[0-9a-fA-F]{1,4}){1,5}|:[0-9a-fA-F]{1,4})|(([0-9a-fA-F]{1,4}:){1}
                |(:[0-9a-fA-F]{1,4}){1,6}|:):((:[0-9a-fA-F]{1,4}){1,6}|:[0-9a-fA-F]{1,4})|:(:(([0-9a-fA-F]{1,4}){1,7}|:[0-9a-fA-F]{1,4})|:)
                |::(ffff(:0{1,4}){0,1}:){0,1}((25[0-5]|(2[0-4]|1{0,1}[0-9]){0,1}[0-9])\.){3,3}(25[0-5]|(2[0-4]|1{0,1}[0-9]){0,1}[0-9])|
                ([0-9a-fA-F]{1,4}:){1,4}:((25[0-5]|(2[0-4]|1{0,1}[0-9]){0,1}[0-9])\.){3,3}(25[0-5]|(2[0-4]|1{0,1}[0-9]){0,1}[0-9]))$");

                if (ipv6Regex.IsMatch(ipToValidate))
                {
                    MessageBox.Show(ipToValidate + "\nThe IP v6 is correct.", "Valid", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show(ipToValidate + "\nThe IP must have 8 groups of 16 bits each.\nEach group is written as four hexadecimal digits\nand the groups are separated by colons (:) - (2001:0db8:0000:0000:0000:ff00:0042:8329).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}

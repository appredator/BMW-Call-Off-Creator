using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace CallOffCreator1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void CreateFileButton1_Click(object sender, EventArgs e)
        {
            // RegEx Pattern Match Approach

            // Declare Supplier Number Pattern
            string suppliernumpattern = @"-?\d+";

            // Create a bool variable and use the Regex.IsMatch static method which returns true if a specific value matches a specific pattern  
            bool isSupplierNumValid = Regex.IsMatch(SupplierNumberBox.Text, suppliernumpattern);
            if (!isSupplierNumValid)
            {
                //Show Error if Input does not match expression
                MessageBox.Show("Please enter a valid 6 digit Supplier Number");
                MessageBox.Show(Application.StartupPath);
            }
            else
            {
                //Write to text file for portion of Call-Off that text box is responsible for
                using (StreamWriter sw = new StreamWriter(Application.StartupPath + "\\Call-Offs\\" + CallOffBox.Text + ".txt", true))
                    sw.Write("8900175" + SupplierNumberBox.Text);
            }

            // Declare Part Fam Seq Pattern
            string calloffpattern = @"-?\d+";
            // Create a bool variable and use the Regex.IsMatch static method which returns true if a specific value matches a specific pattern  
            bool isCallOffValid = Regex.IsMatch(CallOffBox.Text, calloffpattern);
            if (!isCallOffValid)
            {
                MessageBox.Show("Please enter a valid 8 digit Call Off Number");
            }
            else
            {
                using (StreamWriter sw2 = new StreamWriter(Application.StartupPath + "\\Call-Offs\\" + CallOffBox.Text + ".txt", true))
                    sw2.Write("10S" + CallOffBox.Text);
            }

            // Declare Part Fam Seq Pattern
            string partfamseqpattern = @"-?\d+";
            // Create a bool variable and use the Regex.IsMatch static method which returns true if a specific value matches a specific pattern  
            bool isPartFamSeqValid = Regex.IsMatch(PartFamilySeqBox.Text, partfamseqpattern);
            if (!isPartFamSeqValid)
            {
                MessageBox.Show("Please enter a valid 6 digit Part Family Sequence");
            }
            else
            {
                using (StreamWriter sw3 = new StreamWriter(Application.StartupPath + "\\Call-Offs\\" + CallOffBox.Text + ".txt", true))
                    sw3.Write("00" + PartFamilySeqBox.Text);
            }

            // Declare Part Family Pattern
            string partfampattern = @"-?\d+";
            // Create a bool variable and use the Regex.IsMatch static method which returns true if a specific value matches a specific pattern  
            bool isPartFamValid = Regex.IsMatch(PartFamilyBox.Text, partfampattern);
            if (!isPartFamValid)
            {
                MessageBox.Show("Please enter a valid 8 digit Part Family. The value must be 8 characters in length. If your part family is not 8 digits, add two spaces to the end.");
            }
            else
            {
                using (StreamWriter sw3 = new StreamWriter(Application.StartupPath + "\\Call-Offs\\" + CallOffBox.Text + ".txt", true))
                    sw3.Write(PartFamilyBox.Text);
            }

            // Declare SWET Time Pattern
            string swetpattern = @"-?\d+";
            // Create a bool variable and use the Regex.IsMatch static method which returns true if a specific value matches a specific pattern  
            bool isSwetValid = Regex.IsMatch(SWETTimeBox.Text, swetpattern);
            if (!isSwetValid)
            {
                MessageBox.Show("Please enter a valid SWET Time. The value must be like (23.11.2019-11:56) - excluding the brackets.");
            }
            else
            {
                using (StreamWriter sw4 = new StreamWriter(Application.StartupPath + "\\Call-Offs\\" + CallOffBox.Text + ".txt", true))
                    sw4.Write(SWETTimeBox.Text);
            }

            // Declare Seq Pattern
            string seqpattern = @"-?\d+";
            // Create a bool variable and use the Regex.IsMatch static method which returns true if a specific value matches a specific pattern  
            bool isSeqValid = Regex.IsMatch(ProcessSequenceBox.Text, seqpattern);
            if (!isSeqValid)
            {
                MessageBox.Show("Please enter a valid Process Sequence.");
            }
            else
            {
                using (StreamWriter sw5 = new StreamWriter(Application.StartupPath + "\\Call-Offs\\" + CallOffBox.Text + ".txt", true))
                    sw5.Write("7550M1100000#00" + ProcessSequenceBox.Text + "  ");
            }

            string ordpattern = @"-?\d+";
            // Create a bool variable and use the Regex.IsMatch static method which returns true if a specific value matches a specific pattern  
            bool isOrdValid = Regex.IsMatch(OrderNumberBox.Text, ordpattern);
            if (!isOrdValid)
            {
                MessageBox.Show("Please enter a valid 7 digit Order Number.");
            }
            else
            {
                using (StreamWriter sw6 = new StreamWriter(Application.StartupPath + "\\Call-Offs\\" + CallOffBox.Text + ".txt", true))
                    sw6.Write(OrderNumberBox.Text + "1");
            }

            string buildpattern = @"-?\d+";
            // Create a bool variable and use the Regex.IsMatch static method which returns true if a specific value matches a specific pattern  
            bool isBuildValid = Regex.IsMatch(BuildNumBox.Text, buildpattern);
            if (!isBuildValid)
            {
                MessageBox.Show("Please enter a valid 5 digit Build Number.");
            }
            else
            {
                using (StreamWriter sw7 = new StreamWriter(Application.StartupPath + "\\Call-Offs\\" + CallOffBox.Text + ".txt", true))
                    sw7.Write("  " + BuildNumBox.Text);
            }

            string vinpattern = @"-?\d+";
            // Create a bool variable and use the Regex.IsMatch static method which returns true if a specific value matches a specific pattern  
            bool isVinValid = Regex.IsMatch(VinNumberBox.Text, vinpattern);
            if (!isVinValid)
            {
                MessageBox.Show("Please enter a valid 7 digit VIN Number.");
            }
            else
            {
                using (StreamWriter sw8 = new StreamWriter(Application.StartupPath + "\\Call-Offs\\" + CallOffBox.Text + ".txt", true))
                    sw8.Write(VinNumberBox.Text);
            }




        }

        private void SupplierNumberBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
    

//7550M1100000#
            //8900175 + Supplier Number 6 ints (8-13) + Call Off Number + part Family Sequence + Part Family STFGBR11 + SWET Time + Supply G STFGKP11

            //sw.WriteLine("8900175" +SupplierNumberBox.Text + CallOffBox.Text + PartFamilySeqBox.Text + PartFamilyBox.Text +SWETTimeBox.Text);








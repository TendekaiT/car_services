using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VendaBoulevardAutoCentre
{
    public partial class VehicleSale : Form
    {
        //declaring variable, while tax variable
        //is declared and initialized.

        decimal tax = 0.15m;
        decimal subtotal;
        decimal total;
        decimal due;
        public VehicleSale()
        {
            InitializeComponent();
        }

        private void VehicleSale_Load(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //Calling the method to the event handler.
            //Exception handling, using try-catch statement, is used here. It is 
            //used when a method cannot complete a task or when an exception to test 
            //an exception handler needs to be generated.
            try
            {
                if (IsValidData())
                {
                    Calculations(tax, subtotal, total, due);
                }
            }

            catch (FormatException)
            {
                MessageBox.Show("A format exception has occured. Please check all entries.", "Entry Error");
            }

            catch (OverflowException)
            {
                MessageBox.Show("An overflow exception has occured. Pleae enter smaller values.", "Entry Error");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }
        //Method needed to validate data in textboxes. It calls other methods that make sure
        //numerical data is entered by user, the data is a decimal data type and falls within a 
        //range specified below. If any of the conditions are not met, a message box with a 
        //message to guide the user is shown.  
        public bool IsValidData()
        {
            return
            IsPresent(txtCarSalesPrices, "Car Sales Price ") &&
            IsPresent(txtTradeInAllowance, "Trade In Allowance ") &&
            IsDecimal(txtCarSalesPrices, "Car Sales Price ") &&
            IsDecimal(txtTradeInAllowance, "Trade In Allowance") &&
            IsWithinRange(txtCarSalesPrices, "Car Sales Price ", 25000, 2000000) &&
            IsWithinRange(txtTradeInAllowance, "Trade In Allowance ", 0, 240000);
        }

        public bool IsPresent(TextBox textBox, string name)
        {
            if (textBox.Text == "")
            {
                MessageBox.Show(name + "is a required field.", "Entry Error");
                textBox.Focus();
                return false;
            }
            return true;
        }
        public bool IsDecimal(TextBox textBox, string name)
        {
            decimal number = 0m;
            if (Decimal.TryParse(textBox.Text, out number))
            {
                return true;
            }
            else
            {
                MessageBox.Show(name + "must be a decimal number.", "Entry Error");
                textBox.Focus();
                return false;
            }

        }
        public bool IsWithinRange(TextBox textBox, string name, decimal min, decimal max)
        {
            decimal number = Convert.ToDecimal(textBox.Text);
            if (number < min || number > max)
            {
                MessageBox.Show(name + " must be between " + min
                +
                " and " + max + ".", "Entry Error");
                textBox.Focus();
                return false;
            }
            return true;
        }

        //A method with parameters is created to carry out the calculations.
        public decimal Calculations(decimal tax, decimal subtotal, decimal total, decimal due)
        {
            //using if-statement, that when condition is true, allow the block of code in the brackets 
            //to be executed.
            //To.String() allow variable to be displayed in textbox.
            
            decimal add = 0m;
            if (chkBxStereoSystem.CheckState == CheckState.Checked)
            {
                add += 5999;
                txtAccAndFinish.Text = add.ToString();
            }
            if (chkBxLeatherInterior.CheckState == CheckState.Checked)
            {
                add += 29999;
                txtAccAndFinish.Text = add.ToString();
            }
            if (chkBxComputerNav.CheckState == CheckState.Checked)
            {
                add += 15900;
                txtAccAndFinish.Text = add.ToString();
            }

            //else-if statements used with radio buttons. They are executed when the if 
            //condition is evaluated to false. 
            //Convert Class converts a specified value in textbox to a decimal number.
            if (rdbnStandard.Checked)
            {
                decimal standard = Convert.ToDecimal(rdbnStandard.Checked);
                decimal price = Convert.ToDecimal(txtCarSalesPrices.Text);
                decimal Allowance = Convert.ToDecimal(txtTradeInAllowance.Text);

                standard = 0m;

                subtotal = standard + add + price;
                tax = subtotal * 0.15m;
                total = tax + subtotal;
                due = total - Allowance;


                txtSubtotal.Text = subtotal.ToString();
                txtSalesTax.Text = tax.ToString();
                txtTotal.Text = total.ToString();
                txtAmountDue.Text = due.ToString();
            }
            else if (rdbnPearlized.Checked)
            {
                decimal pearlized = Convert.ToDecimal(rdbnPearlized.Checked);
                decimal price = Convert.ToDecimal(txtCarSalesPrices.Text);
                decimal Allowance = Convert.ToDecimal(txtTradeInAllowance.Text);


                pearlized = 9999m;

                subtotal = pearlized + add + price;
                tax = subtotal * 0.15m;
                total = tax + subtotal;
                due = total - Allowance;


                txtSubtotal.Text = subtotal.ToString();
                txtSalesTax.Text = tax.ToString();
                txtTotal.Text = total.ToString();
                txtAmountDue.Text = due.ToString();
            }
            else if (rdbnCustDetail.Checked)
            {
                decimal custom = Convert.ToDecimal(rdbnCustDetail.Checked);
                decimal price = Convert.ToDecimal(txtCarSalesPrices.Text);
                decimal Allowance = Convert.ToDecimal(txtTradeInAllowance.Text);


                custom = 12999m;

                subtotal = custom + add + price;
                tax = subtotal * 0.15m;
                total = tax + subtotal;
                due = total - Allowance;


                txtSubtotal.Text = subtotal.ToString();
                txtSalesTax.Text = tax.ToString();
                txtTotal.Text = total.ToString();
                txtAmountDue.Text = due.ToString();
            }
            return due;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //all cells cleared when clear button event handler is executed. 
            txtCarSalesPrices.Text = "";
            txtAccAndFinish.Text = "";
            txtSubtotal.Text = "";
            txtSalesTax.Text = "";
            txtTotal.Text = "";
            txtTradeInAllowance.Text = "";
            txtAmountDue.Text = "";
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Form closed when exit button is clicked.
            this.Close();
        }

        private void calculationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Calculations button on menu strips calls method to carry out calculations
            //using the formula in the Calculations method. 
            Calculations(tax, subtotal, total, due);
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //all cells cleared when clear button event handler is executed.
            txtCarSalesPrices.Text = "";
            txtAccAndFinish.Text = "";
            txtSubtotal.Text = "";
            txtSalesTax.Text = "";
            txtTotal.Text = "";
            txtTradeInAllowance.Text = "";
            txtAmountDue.Text = "";
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Message Box with useful Information is opened when click event is fired.
            string info = "Venda Boulevard Auto Centre was established in 2000 and prides itself in having the widest selection of car brands in " +
                "South Africa.\nThe catalog is refreshed every Monday at 9am CAT and accessories are available while stocks last";
            MessageBox.Show(info, "More Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void backToMainMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Message Box with help is opened when click event is fired. String variable is displayed
            //in Message Box. 
            string help = "For further assistance, please email vendaboulevard@gmail.com or \n reach our call centre on 0123456789.";
            MessageBox.Show(help, "Help", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //Block of code dictates the format of text and position of heading and body
            
            Font HeadingFont = new Font("Microsoft Sans Serif", 12, FontStyle.Bold, GraphicsUnit.Pixel);
            Font BodyFont = new Font("Microsoft Sans Serif", 10, FontStyle.Regular, GraphicsUnit.Pixel);

            float HeadingLineSpacing = HeadingFont.GetHeight() + 1;
            float HorizontalPrintMargin = e.MarginBounds.Left;
            float VerticalPrintMargin = e.MarginBounds.Top;

            string heading = "Vehicle Sale Order";
            VerticalPrintMargin += HeadingLineSpacing * 2;
            e.Graphics.DrawString(heading, HeadingFont, Brushes.Black, HorizontalPrintMargin, VerticalPrintMargin);

            //Block of code uses string to retrieve text from the textboxes and 
            //lay out information going down the page.
            string printout = "";
            printout = "Car Sales Price: " + txtCarSalesPrices.Text + "\n" 
                        + "Accessories and Finish:" + txtAccAndFinish.Text + "\n" 
                        + "Subtotal:" + txtSubtotal.Text + "\n"
                        + "Sales Tax:" + txtSalesTax.Text + "\n"
                        + "Total:" + txtTotal.Text + "\n" 
                        + "Amount Due:" + txtAmountDue.Text;
            //Prints the words onto the page of the print preview
            VerticalPrintMargin += HeadingLineSpacing * 2;
            e.Graphics.DrawString(printout, HeadingFont, Brushes.Black, HorizontalPrintMargin, VerticalPrintMargin);
            VerticalPrintMargin += HeadingLineSpacing * 2;
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Event handler calls the method in brackets. This allows the print feature
            //to happen.
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }
    }
}

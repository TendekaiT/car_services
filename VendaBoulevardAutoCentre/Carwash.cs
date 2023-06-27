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
    public partial class Carwash : Form
    {
        public Carwash()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbBxExterior_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void cmbBxPackages_SelectedIndexChanged(object sender, EventArgs e)
        {
            //The conditions next to the if-statements state that
            //if the item selected in the combobox matches the package that
            //is is the quotation marks, The list box will display specific items.
            //It also clears each the item chosen in the combobox is changed. 
            if (cmbBxPackages.SelectedItem.ToString() == "Standard")
            {
                lbxExterior.Items.Clear();
                lbxExterior.Items.AddRange(new object[] { "Hand Wash" });
                lbxInterior.Items.Clear();
                lbxInterior.Items.AddRange(new object[] { "Fragrance" });
            }
            if (cmbBxPackages.SelectedItem.ToString() == "Deluxe")
            {
                lbxExterior.Items.Clear();
                lbxExterior.Items.AddRange(new object[] { "Hand Wash", "Hand Wax" });
                lbxInterior.Items.Clear();
                lbxInterior.Items.AddRange(new object[] { "Fragrance", "Shampoo Carpets" });
                
            }
            if (cmbBxPackages.SelectedItem.ToString() == "Executive")
            {
                lbxExterior.Items.Clear();
                lbxExterior.Items.AddRange(new object[] { "Hand Wash", "Hand Wax", "Check Engine Fliuds" });
                lbxInterior.Items.Clear();
                lbxInterior.Items.AddRange(new object[] { "Fragrance", "Shampoo Carpets", "Interior Protection Coat" });
            }
            if(cmbBxPackages.SelectedItem.ToString() == "Luxury")
            {
                lbxExterior.Items.Clear();
                lbxExterior.Items.AddRange(new object[] { "Hand Wash", "Hand Wax", "Check Engine Fliuds", 
                "Detail Engine Compartment", "Detail Undercarriage"});
                lbxInterior.Items.Clear();
                lbxInterior.Items.AddRange(new object[] { "Fragrance", "Shampoo Carpets", "Interior Protection Coat", 
                "Scotchgard"});
            }
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Items in the list boxes are cleared when the clear option of the 
            //menu strip is clicked. 
            lbxExterior.Items.Clear();
            lbxInterior.Items.Clear();
        }

        private void printOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Font HeadingFont = new Font("Microsoft Sans Serif", 12, FontStyle.Bold, GraphicsUnit.Pixel);
            Font BodyFont = new Font("Microsoft Sans Serif", 10, FontStyle.Regular, GraphicsUnit.Pixel);

            float HeadingLineSpacing = HeadingFont.GetHeight() + 1;
            float HorizontalPrintMargin = e.MarginBounds.Left;
            float VerticalPrintMargin = e.MarginBounds.Top;

            string heading = "Carwash Order";
            VerticalPrintMargin += HeadingLineSpacing * 2;
            e.Graphics.DrawString(heading, HeadingFont, Brushes.Black, HorizontalPrintMargin, VerticalPrintMargin);

            string outcome = "";
            outcome = "Package Name: " + cmbBxPackages.Text + "\n" + "Exterior:" + lbxExterior.Text + "\n" + "Interior:" + lbxInterior.Text + "\n"
                + "Fragrance: " + cmbBxFragrances.Text; 
            VerticalPrintMargin += HeadingLineSpacing * 2;
            e.Graphics.DrawString(outcome, HeadingFont, Brushes.Black, HorizontalPrintMargin, VerticalPrintMargin);
            VerticalPrintMargin += HeadingLineSpacing * 2;
        }

        private void cmbBxFragrances_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Carwash_Load(object sender, EventArgs e)
        {
            
                cmbBxFragrances.Items.Add("Hawaaian Must");
                cmbBxFragrances.Items.Add("Baby Powder");
                cmbBxFragrances.Items.Add("Pine");
                cmbBxFragrances.Items.Add("Country Floral");
                cmbBxFragrances.Items.Add("Pina Colada");
                cmbBxFragrances.Items.Add("Vanilla");
            
        }
    }
}

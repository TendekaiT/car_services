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
    public partial class AutoPartsLookupForm : Form
    {
        public AutoPartsLookupForm()
        {
            InitializeComponent();
        }

        //Part numbers and VB Auto Part Numbers are stored in a one dimensional arrays.
        //They are retrieved in the loop below. 
        string[] vbAuto = {"PR214", "PR223", "PR224", "PR246", "PR247", "PR248", "PR324", "PR326", "PR444" };
        string[] brandA = {"MR43T", "R43", "R43N", "R46N", "R46TS", "R46TX", "S46", "SR46E", "47L" };
        string[] brandC = {"RBL8", "RJ6", "RN4", "RN8", "RBL17Y", "RBL12-6", "J11", "XEJ8", "H12" };
        string[] brandX = {"14K22", "14K24", "14K30", "14K44", "14K33", "14K35", "14K38", "14K40", "14k44" };

        public void FillComboBox(string[] array, ComboBox box)
        {
            
        }



        private void btnLookup_Click(object sender, EventArgs e)
        {
            string chosen = "";
            //Blocks of code under this event handler make use of loops.
            //A loop statement allows us to execute a statement or a group of
            //statements multiple times. 
            //If-statements are used inside the for-loops so that a condition 
            //has to be met in order for the loop to start. 

            for (int i = 0; i < brandA.Length; i++)
            {
                if (txtCustomerPartNo.Text == vbAuto[i] && rdBnBrandA.Checked)
                {
                    chosen = brandA[i];
                    txtVBAutoPartNo.Text = chosen;
                }
            }
            for (int i = 0; i < brandC.Length; i++)
            {
                if (txtCustomerPartNo.Text == vbAuto[i] && rdBnBrandC.Checked)
                {
                    chosen = brandC[i];
                    txtVBAutoPartNo.Text = chosen;
                }
            }
            for (int i = 0; i < brandX.Length; i++)
            {
                if (txtCustomerPartNo.Text == vbAuto[i] && rdBnBrandX.Checked)
                {
                    chosen = brandX[i];
                    txtVBAutoPartNo.Text = chosen;
                }
            }
        }

        private void cmbBxBrand_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void AutoPartsLookupForm_Load(object sender, EventArgs e)
        {
           
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //clears all text in textboxes and unchecks the radio buttons. 
            txtCustomerPartNo.Text = "";
            txtVBAutoPartNo.Text = "";
            rdBnBrandA.Checked = false;
            rdBnBrandC.Checked = false;
            rdBnBrandX.Checked = false;
            
        }
    }
}

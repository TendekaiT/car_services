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
    public partial class AboutUs : Form
    {
        public AboutUs()
        {
            InitializeComponent();
        }

        int intImgeNum = 0;
        private void tmrChangeImage_Tick(object sender, EventArgs e)
        {
            pBxVBAuto.Image = imgList.Images[intImgeNum];
            if (intImgeNum == imgList.Images.Count - 1)
            {
                intImgeNum = 0;
            }
            else
            {
                intImgeNum++;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

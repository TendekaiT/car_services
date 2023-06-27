namespace VendaBoulevardAutoCentre
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            VehicleSale v = new VehicleSale();
            v.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLeave_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AutoPartsLookupForm a = new AutoPartsLookupForm();
            a.Show();
        }

        private void btnCarwash_Click(object sender, EventArgs e)
        {
            Carwash wash = new Carwash();
            wash.Show();

        }

        private void btnAboutUs_Click(object sender, EventArgs e)
        {
            AboutUs u = new AboutUs();
            u.Show();
        }
    }
}
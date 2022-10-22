using System;
using System.Windows.Forms;

namespace Toledo
{
    public partial class Form1 : Form
    {
        public DateTime thisDay = DateTime.Today;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n1 = Convert.ToInt32(thisDay.ToString("dd")) + 20;
            int n2 = Convert.ToInt32(thisDay.ToString("MM")) + 11;
            label1.Text = Convert.ToString(n1) + Convert.ToString(n2);


            //thisDay.ToString("dd");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

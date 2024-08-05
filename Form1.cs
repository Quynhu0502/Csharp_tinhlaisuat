using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Csharp_tinhlaisuat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txb3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txbtinh_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sotien = Convert.ToDouble(txb1.Text);
            double sonam = Convert.ToDouble(txb2.Text);
            double laisuat = Convert.ToDouble(txb3.Text) / 100;

            double tienlai = sotien * laisuat * sonam;
            double tongtien = tienlai + sotien;

            lblKQ.Text = Environment.NewLine + tongtien.ToString();
            lbltienlai.Text = Environment.NewLine + tienlai.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

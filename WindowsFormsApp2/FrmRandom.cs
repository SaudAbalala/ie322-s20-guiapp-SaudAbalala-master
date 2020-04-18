using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class FrmRandom : Form
    {
        Random y = new Random();
        public FrmRandom()
        {
            InitializeComponent();
        }

        private void BtnGenerateRandom_Click(object sender, EventArgs e)
        {
            int R = y.Next(0, 255);
            int G = y.Next(0, 255);
            int B = y.Next(0, 255);

            Label.Text = Convert.ToString(R) + " - " + Convert.ToString(G) + " - " + Convert.ToString(B);

            BtnGenerateRandom.BackColor = Color.FromArgb(R, G, B);
            this.BackColor = Color.FromArgb(255 - R, 255 - G, 255 - B);
        }

        private void BtnRandomNum_Click(object sender, EventArgs e)
        {
            BtnRandomNum.Text = Convert.ToString(y.Next(1, 10));
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

    }
}

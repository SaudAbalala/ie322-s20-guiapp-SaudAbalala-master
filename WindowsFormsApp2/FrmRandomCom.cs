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
    public partial class FrmRandomCom : Form
    {
        public FrmRandomCom()
        {
            InitializeComponent();
        }

        private void FrmRandomCom_Load(object sender, EventArgs e)
        {

        }

        private void BtnGenerate1_Click(object sender, EventArgs e)
        {
            CmbRandom1.ResetText();
            CmbRandom1.Items.Clear();
            Random r = new Random();
            for (int i = 0; i < r.Next(1, 51); i++)
            {
                CmbRandom1.Items.Add(r.Next(100, 999));
            }
        }

        private void CmbRandom1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(CmbRandom1.Text) >= 500)
            {
                RdoGreater1.Checked = true;
            }
            else
            {
                RdoLess1.Checked = true;
            }
        }

        private void BtnGenerate2_Click(object sender, EventArgs e)
        {
            CmbRandom2.ResetText();
            CmbRandom2.Items.Clear();
            Random r = new Random();
            for (int i = 0; i < r.Next(2, 9) - 1; i++)
            {
                CmbRandom2.Items.Add(r.Next(10, 99));
            }
            Label.Text = Convert.ToString(CmbRandom2.Items.Count);
        }

        private void CmbRandom2_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (Convert.ToInt32(CmbRandom2.Text) >= 50)
            {
                RdoGreater2.Checked = true;
            }
            else
            {
                RdoLess2.Checked = true;
            }
        }

        private void btnReset1_Click(object sender, EventArgs e)
        {
            CmbRandom1.ResetText();
            CmbRandom1.Items.Clear();
            RdoLess1.Checked = false;
            RdoGreater1.Checked = false;
        }

        private void btnReset2_Click(object sender, EventArgs e)
        {
            CmbRandom2.ResetText();
            CmbRandom2.Items.Clear();
            RdoLess2.Checked = false;
            RdoGreater2.Checked = false;
            Label.Text = "";
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
    
}

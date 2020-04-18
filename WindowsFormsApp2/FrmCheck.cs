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
    public partial class FrmCheck : Form
    {
        public FrmCheck()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btnShow_Click(object sender, EventArgs e)
        {            
                string Msg = "";
                if ( ChkCoffee.Checked == true )
                {
                    Msg = Msg+" "+ChkCoffee.Text;
            }

                if ( ChkDonut.Checked == true )
                {
                    Msg = Msg+" "+ChkDonut.Text;
                }

                if ( ChkBrownie.Checked == true )
                {
                    Msg = Msg+" "+ChkBrownie.Text;
                }

                if ( Msg.Length > 0 )
                {
                    MessageBox.Show(Msg+" selected ");
                }
                else 
                {
                    MessageBox.Show("Nothing selected");
                }            
        }
    }
}

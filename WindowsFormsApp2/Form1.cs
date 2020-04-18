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
    public partial class Form1 : Form
    {
        string username = ""; //empty for demonstration
        string password = ""; //empty for demonstration
        bool loggedIn = false;
        int attempt = 1;
        int MaxAttempts = 3;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (var grp in groupBox1.Controls.OfType<GroupBox>())
            {
                foreach (var btn in grp.Controls.OfType<Button>())
                {
                    btn.Enabled = false;
                }
            }
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            {
                if (!loggedIn)
                {

                    while (attempt <= MaxAttempts)
                    {
                        if (TxtUser.Text != username)
                        {

                            MessageBox.Show("Invalid username, " + (MaxAttempts - attempt) + " attempts remaining");
                            attempt++;
                            return;
                        }
                        else
                        {

                            if (TxtPass.Text != password)
                            {

                                MessageBox.Show("Incorrect password," + (MaxAttempts - attempt) + " attempts remaining");
                                attempt++;
                                return;
                            }
                            else
                            {

                                attempt = 1;
                                loggedIn = true;
                                MessageBox.Show("Hi " + username + ", your login successful", "Welcome!!");


                                foreach (var grp in groupBox1.Controls.OfType<GroupBox>())
                                {
                                    foreach (var btn in grp.Controls.OfType<Button>())
                                    {
                                        btn.Enabled = true;
                                    }
                                }
                                BtnLogin.Text = "Logout";
                                BtnLogin.BackColor = Color.FromName("crimson");
                                break;
                            }

                        }
                    }
                }
                else
                {
                    BtnLogin.Text = "Login";
                    loggedIn = false;
                    BtnLogin.BackColor = Color.FromName("forestgreen");
                    TxtUser.Clear();
                    TxtPass.Clear();

                    foreach (var grp in groupBox1.Controls.OfType<GroupBox>())
                    {
                        foreach (var btn in grp.Controls.OfType<Button>())
                        {
                            btn.Enabled = false;
                        }
                    }
                }



            }
        }

        private void BtnRadio_Click(object sender, EventArgs e)
        {
            FrmRadio Frm = new FrmRadio();
            Frm.ShowDialog();
        }

        private void BtnCheck_Click(object sender, EventArgs e)
        {
            FrmCheck Frm = new FrmCheck();
            Frm.ShowDialog();
        }

        private void BtnCombo_Click(object sender, EventArgs e)
        {
            FrmCombo Frm = new FrmCombo();
            Frm.ShowDialog();
        }

        private void BtnPic_Click(object sender, EventArgs e)
        {
            FrmPic1 Frm = new FrmPic1();
            Frm.ShowDialog();
        }

        private void BtnPic2_Click(object sender, EventArgs e)
        {
            FrmPic2 Frm = new FrmPic2();
            Frm.ShowDialog();
        }

        private void PicLogo_Click(object sender, EventArgs e)
        {

        }

        private void BtnRandom_Click(object sender, EventArgs e)
        {
            FrmRandom Frm = new FrmRandom();
            Frm.ShowDialog();
        }

        private void BtnRandomCom_Click(object sender, EventArgs e)
        {
            FrmRandomCom Frm = new FrmRandomCom();
            Frm.ShowDialog();
        }

        private void BtnMethods_Click(object sender, EventArgs e)
        {
            FrmMethods Frm = new FrmMethods();
            Frm.ShowDialog();
        }

        private void BtnClasses_Click(object sender, EventArgs e)
        {
            FrmClasses Frm = new FrmClasses();
            Frm.ShowDialog();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void LnkForgot_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Not my problem.");
        }
    }   
}

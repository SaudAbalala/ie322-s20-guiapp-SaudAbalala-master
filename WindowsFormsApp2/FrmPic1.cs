using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;            
using System.Reflection;    
namespace WindowsFormsApp2
{
    public partial class FrmPic1 : Form
    {

        Assembly _assembly; 
        Stream _imageStream;
        public FrmPic1()
        {
            InitializeComponent();
            Picture1.SizeMode = PictureBoxSizeMode.StretchImage;
            Picture2.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void FrmPic1_Load(object sender, EventArgs e)
        {
            _assembly = Assembly.GetExecutingAssembly(); 
            _imageStream = _assembly.GetManifestResourceStream("SaudProjectIE.img.AAA.jpg");
        }

        private void BtnImageFromFile_Click(object sender, EventArgs e)
        {
            try
            {
                Picture1.Image = Image.FromFile("..\\..\\Resources\\AA.png");
            }
            catch
            {
                MessageBox.Show("Image file not found");
            }
        }

        private void BtnImageFromRes_Click(object sender, EventArgs e)
        {
            try
            {
                Picture2.Image = Image.FromStream(_imageStream);
            }
            catch
            {
                MessageBox.Show("Error creating image from resource!");
            }
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}

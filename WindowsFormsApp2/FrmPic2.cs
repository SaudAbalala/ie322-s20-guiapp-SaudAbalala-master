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
    public partial class FrmPic2 : Form
    {
        Assembly _assembly;
        Stream _imageStream;
        public FrmPic2()
        {
            InitializeComponent();
            Picture.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void BtnLoad_Click(object sender, EventArgs e)
        {

            try
            {

                Picture.Image = Image.FromStream(_imageStream);

            }
            catch
            {
                MessageBox.Show("Error creating image!");
            }
        }

        private void FrmPic2_Load(object sender, EventArgs e)
        {
            _assembly = Assembly.GetExecutingAssembly();
            _imageStream = _assembly.GetManifestResourceStream("SaudProjectIE.img.AAA.jpg");
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}

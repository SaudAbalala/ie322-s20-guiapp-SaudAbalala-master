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
    public partial class FrmClasses : Form
    {
        Car MyCar = new Car();
        Car HisCar = new Car();

        Truck MyTruck = new Truck();

        public FrmClasses()
        {
            InitializeComponent();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void BtnStartMyCar_Click(object sender, EventArgs e)
        {
            MyCar.Start();
        }

        private void BtnAccMyCar_Click(object sender, EventArgs e)
        {
            MyCar.Accelerate(30);
            MessageBox.Show(Convert.ToString(MyCar.speed));
        }

        private void BtnStopMyCar_Click(object sender, EventArgs e)
        {
            MyCar.Stop();
        }

        private void BtnStartHisCar_Click(object sender, EventArgs e)
        {
            HisCar.Start();
        }

        private void BtnAccHisCar_Click(object sender, EventArgs e)
        {
            HisCar.Accelerate(30);
            MessageBox.Show(Convert.ToString(HisCar.speed));
        }

        private void BtnStopHisCar_Click(object sender, EventArgs e)
        {
            HisCar.Stop();
        }

        private void BtnStartMyTruck_Click(object sender, EventArgs e)
        {
            MyTruck.Start();
        }
    }
}

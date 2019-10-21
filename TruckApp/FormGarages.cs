using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TruckApp
{
    public partial class FormGarages : Form
    {
        Garages<ITransport> garages;
        public FormGarages()
        {
            InitializeComponent();
            garages = new Garages<ITransport>(20, pbGarages.Width, pbGarages.Height);
            Draw();
        }

        private void Draw()
        {
            Bitmap bmp = new Bitmap(pbGarages.Width, pbGarages.Height);
            Graphics gr = Graphics.FromImage(bmp);
            garages.Draw(gr);
            pbGarages.Image = bmp;
        }

        private void btnSetTruckInGarege_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var truck = new Truck(100,2,3,true,dialog.Color,Color.White,Color.Black);
                int place = garages + truck;
                Draw();
            }
        }

        private void btnSetFuelTruckInGarege_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                ColorDialog dialogDop = new ColorDialog();
                if (dialogDop.ShowDialog() == DialogResult.OK)
                {
                    var car = new FuelTruck(100, 3, 100, "Fuel", 1000, true, dialog.Color, dialogDop.Color, Color.Black, Color.Red);
                    int place = garages + car;
                    Draw();
                }
            }
        }

        private void buttonTakeCar_Click(object sender, EventArgs e)
        {
            if (tbTruckТumber.Text != "")
            {
                var car = garages - Convert.ToInt32(tbTruckТumber.Text);
                if (car != null)
                {
                    Bitmap bmp = new Bitmap(pbPickUpTruck.Width,
                   pbPickUpTruck.Height);
                    Graphics gr = Graphics.FromImage(bmp);
                    car.SetPosition(5, 5, pbPickUpTruck.Width,
                   pbPickUpTruck.Height);
                    car.DrawTransport(gr);
                    pbPickUpTruck.Image = bmp;
                }
                else
                {
                    Bitmap bmp = new Bitmap(pbPickUpTruck.Width,
                   pbPickUpTruck.Height);
                    pbPickUpTruck.Image = bmp;
                }
                Draw();
            }
        }
    }
}

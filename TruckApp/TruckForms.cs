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
    public partial class TruckForms : Form
    {
        FuelTruck fuelTruck;
        public TruckForms()
        {
            InitializeComponent();
        }

        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBox.Width, pictureBox.Height);
            Graphics gr = Graphics.FromImage(bmp);
            fuelTruck.drawTruck(gr);
            pictureBox.Image = bmp;
        }
        private void btnCreateFuelTruck_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            fuelTruck = new FuelTruck(100, rnd.Next(2, 5), 1000, Color.White, Color.Red, Color.White, Color.Black);
            fuelTruck.setPosition(rnd.Next(10, 100), rnd.Next(10, 100), pictureBox.Width, pictureBox.Height);
            Draw();
        }

        private void btnMove_Click(object sender, EventArgs e)
        {
            //получаем имя кнопки
            string name = (sender as Button).Name;
            switch (name)
            {
                case "btnUp":
                    fuelTruck.moveTruck(Direction.Up);
                    break;
                case "btnDown":
                    fuelTruck.moveTruck(Direction.Down);
                    break;
                case "btnLeft":
                    fuelTruck.moveTruck(Direction.Left);
                    break;
                case "btnRight":
                    fuelTruck.moveTruck(Direction.Right);
                    break;
            }
            Draw();
        }
    }
}

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
        private ITransport Truck;
        public TruckForms()
        {
            InitializeComponent();
        }

        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBox.Width, pictureBox.Height);
            Graphics gr = Graphics.FromImage(bmp);
            Truck.DrawTransport(gr);
            pictureBox.Image = bmp;
        }
        private void btnCreateFuelTruck_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            Truck = new FuelTruck(100, rnd.Next(2, 5), 1000, "fuel", 1000, true, Color.White, Color.White, Color.Black, Color.Red);
            Truck.SetPosition(rnd.Next(10, 100), rnd.Next(10, 100), pictureBox.Width, pictureBox.Height);
            Draw();
        }

        private void btnMove_Click(object sender, EventArgs e)
        {
            //получаем имя кнопки
            string name = (sender as Button).Name;
            switch (name)
            {
                case "btnUp":
                    Truck.MoveTransport(Direction.Up);
                    break;
                case "btnDown":
                    Truck.MoveTransport(Direction.Down);
                    break;
                case "btnLeft":
                    Truck.MoveTransport(Direction.Left);
                    break;
                case "btnRight":
                    Truck.MoveTransport(Direction.Right);
                    break;
            }
            Draw();

        }

        private void btnCreateTruck_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            Truck = new Truck(100, rnd.Next(2, 5), 1000, false, Color.White, Color.BlueViolet, Color.Black);
            Truck.SetPosition(rnd.Next(10, 100), rnd.Next(10, 100), pictureBox.Width, pictureBox.Height);
            Draw();
        }
    }
}

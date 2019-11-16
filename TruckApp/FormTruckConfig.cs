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
    public partial class formTruckConfig : Form
    {
        ITransport transport = null;
        public event truckDelegate eventAddTruck;
        public formTruckConfig()
        {
            InitializeComponent();
            btnCancel.Click += (object sender, EventArgs e) => { Close(); };
        }

        private void DrawCar()
        {
            if (transport != null)
            {
                Bitmap bmp = new Bitmap(pbExampleTruck.Width, pbExampleTruck.Height);
                Graphics gr = Graphics.FromImage(bmp);
                transport.SetPosition(5, 5, pbExampleTruck.Width, pbExampleTruck.Height);
                transport.DrawTransport(gr);
                pbExampleTruck.Image = bmp;
            }
        }

        public void AddEvent(truckDelegate ev)
        {
            if (eventAddTruck == null)
            {
                eventAddTruck = new truckDelegate(ev);
            }
            else
            {
                eventAddTruck += ev;
            }
        }

        private void labelTruck_MouseDown(object sender, MouseEventArgs e)
        {
            labelTruck.DoDragDrop(labelTruck.Text, DragDropEffects.Move | DragDropEffects.Copy);
        }

        private void labelFuelTruck_MouseDown(object sender, MouseEventArgs e)
        {
            labelFuelTruck.DoDragDrop(labelFuelTruck.Text, DragDropEffects.Move | DragDropEffects.Copy);
        }

        private void panelTruck_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void panelColor_MouseDown(object sender, MouseEventArgs e)
        {
            (sender as Control).DoDragDrop((sender as Control).BackColor,DragDropEffects.Move | DragDropEffects.Copy);
        }

        private void panelTruck_DragDrop(object sender, DragEventArgs e)
        {
            switch (e.Data.GetData(DataFormats.Text).ToString())
            {
                case "Truck":
                    transport = new Truck(100,2,100,true,Color.White,Color.White,Color.Black);
                    break;
                case "FuelTruck":
                    transport = new FuelTruck(100, 2, 100, "Fuel", 100, false, Color.White, Color.White, Color.Black, Color.White);
                    break;
            }
            DrawCar();
        }

        private void labelMainColor_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Color)))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void labelMainColor_DragDrop(object sender, DragEventArgs e)
        {
            if (transport != null)
            {
                transport.SetMainColor((Color)e.Data.GetData(typeof(Color)));
                DrawCar();
            }
        }

        private void labelTankColor_DragDrop(object sender, DragEventArgs e)
        {
            if (transport != null)
            {
                if (transport is FuelTruck)
                {
                    (transport as FuelTruck).SetTankColor((Color)e.Data.GetData(typeof(Color)));
                    DrawCar();
                }
            }
        }

        private void btnAddTransport_Click(object sender, EventArgs e)
        {
            eventAddTruck?.Invoke(transport);
            Close();
        }
    }
}

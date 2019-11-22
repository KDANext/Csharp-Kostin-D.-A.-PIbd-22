using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NLog;

namespace TruckApp
{
    public partial class FormGarages : Form
    {
        MultiLevelGarages garages;
        formTruckConfig form;
        /// <summary>
        /// Количество уровней-парковок
        /// </summary>
        private const int countLevel = 5;
        private Logger logger;
        public FormGarages()
        {
            InitializeComponent();
            logger = LogManager.GetCurrentClassLogger();
            garages = new MultiLevelGarages(countLevel, pbGarages.Width,pbGarages.Height);
            //заполнение listBox
            for (int i = 0; i < countLevel; i++)
            {
                listBoxLevels.Items.Add("Уровень " + (i + 1));
            }
            listBoxLevels.SelectedIndex = 0;
        }

        private void Draw()
        {
            if (listBoxLevels.SelectedIndex > -1)
            {//если выбран один из пуктов в listBox (при старте программы ни один пунктне будет выбран и может возникнуть ошибка, если мы попытаемся обратиться к элементу listBox)
                 Bitmap bmp = new Bitmap(pbGarages.Width,pbGarages.Height);
                Graphics gr = Graphics.FromImage(bmp);
                garages[listBoxLevels.SelectedIndex].Draw(gr);
                pbGarages.Image = bmp;
            }
        }

        private void btnSetTruckInGarege_Click(object sender, EventArgs e)
        {
            if (listBoxLevels.SelectedIndex > -1)
            {
                ColorDialog dialog = new ColorDialog();
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    var truck = new Truck(100, 2, 3, true, dialog.Color, Color.White, Color.Black);
                    int place = garages[listBoxLevels.SelectedIndex] + truck;
                    if (place == -1)
                    {
                        MessageBox.Show("No free places", "Mistake",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    Draw();
                }
            }
        }
        private void btnSetFuelTruckInGarege_Click(object sender, EventArgs e)
        {
            if (listBoxLevels.SelectedIndex > -1)
            {
                ColorDialog dialog = new ColorDialog();
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    ColorDialog dialogDop = new ColorDialog();
                    if (dialogDop.ShowDialog() == DialogResult.OK)
                    {
                        var truck = new FuelTruck(100, 3, 100, "Fuel", 1000, true, dialog.Color, dialogDop.Color, Color.Black, Color.Red);
                        int place = garages[listBoxLevels.SelectedIndex] + truck;
                        if (place == -1)
                        {
                            MessageBox.Show("No free places", "Mistake",
                           MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        Draw();
                    }
                }
            }
        }

        private void buttonTakeCar_Click(object sender, EventArgs e)
        {
            if (listBoxLevels.SelectedIndex > -1)
            {
                if (tbTruckТumber.Text != "")
                {
                    try
                    {
                        var truck = garages[listBoxLevels.SelectedIndex] -
                       Convert.ToInt32(tbTruckТumber.Text);
                        if (truck != null)
                        {                     
                            Bitmap bmp = new Bitmap(pbGarages.Width,pbGarages.Height);
                            Graphics gr = Graphics.FromImage(bmp);
                            truck.SetPosition(5, 5, pbGarages.Width,pbGarages.Height);
                            truck.DrawTransport(gr);
                            pbPickUpTruck.Image = bmp;
                        }
                        else
                        {
                            Bitmap bmp = new Bitmap(pbPickUpTruck.Width,pbPickUpTruck.Height);
                            pbPickUpTruck.Image = bmp;
                        }
                        logger.Info("Vehicle seized " + truck.ToString() + " from place " + tbTruckТumber.Text);
                        Draw();
                    } catch (GaragesNotFoundException ex)
                    {
                        MessageBox.Show(ex.Message
                            , "Not found"
                            , MessageBoxButtons.OK, MessageBoxIcon.Error); 
                        Bitmap bmp = new Bitmap(pbPickUpTruck.Width, pbPickUpTruck.Height); pbPickUpTruck.Image = bmp;
                    } catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Unknown error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private void listBoxLevels_SelectedIndexChanged(object sender, EventArgs e)
        {
            Draw();
        }

        private void AddTransport(ITransport transport)
        {
            if (transport != null && listBoxLevels.SelectedIndex > -1)
            {
                try
                {
                    int place = garages[listBoxLevels.SelectedIndex] + transport;
                    logger.Info("Added car " + transport.ToString() + " in place " + place);
                    Draw();
                }
                catch (GaragesOverflowException ex) 
                { 
                    MessageBox.Show(ex.Message, "Overflow", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                }
                catch (Exception ex) 
                { 
                    MessageBox.Show(ex.Message, "Unknown error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                }
            }
        }

        private void btnNewTransport_Click(object sender, EventArgs e)
        {
            form = new formTruckConfig();
            form.AddEvent(AddTransport);
            form.Show();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    garages.SaveData(saveFileDialog.FileName);
                    MessageBox.Show("Saving was successful", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Unknown error while saving", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    garages.LoadData(openFileDialog.FileName);
                    MessageBox.Show("Uploaded", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    logger.Info("Loaded from file " + openFileDialog.FileName);
                }
                catch (GaragesOccupiedPlaceException ex)
                {
                    MessageBox.Show(ex.Message, "Place taken", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                { MessageBox.Show(ex.Message, "Unknown error while saving", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                Draw();
            }

        }
    }
}

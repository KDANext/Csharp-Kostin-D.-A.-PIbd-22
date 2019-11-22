using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TruckApp
{
    class FuelTruck : Truck
    {

        public string typeLiquid { private set; get; }
        public float countLiquid { private set; get; }
        public Color tankColor { private set; get; }

        public FuelTruck(
                        int maxSpeed,
                        int countWheels,
                        float weight,
                        string typeLiquid,
                        float countLiquid,
                        bool flasher,
                        Color bodyColor,
                        Color drivesColor,
                        Color frameColor,
                        Color tankColor


                        ) : base(
                         maxSpeed,
                         countWheels,
                         weight,
                         flasher,
                         bodyColor,
                         drivesColor,
                         frameColor)
        {
            this.maxSpeed = maxSpeed;
            this.countWheels = countWheels;
            this.weight = weight;
            this.typeLiquid = typeLiquid;
            this.countLiquid = countLiquid;
            this.flasher = flasher;
            this.bodyColor = bodyColor;
            this.tankColor = tankColor;
            this.drivesColor = drivesColor;
            this.frameColor = frameColor;
        }

        public FuelTruck(string info) : base(info)
        {
            string[] strs = info.Split(';');
            if (strs.Length == 9)
            {
                maxSpeed = Convert.ToInt32(strs[0]);
                weight = Convert.ToInt32(strs[1]);
                bodyColor = Color.FromName(strs[2]);
                drivesColor = Color.FromName(strs[3]);
                flasher = Convert.ToBoolean(strs[4]);
                frameColor = Color.FromName(strs[5]);
                typeLiquid = strs[6];
                countLiquid = Convert.ToSingle(strs[7]);
                tankColor = Color.FromName(strs[8]);
            }
        }

        public override void DrawTransport(Graphics g)
        {
            Brush brush = new SolidBrush(tankColor);
            g.FillRectangle(brush, startX + 3, startY + 8, 55 - 3, 28 - 8);
            g.FillRectangle(brush, startX + 16, startY + 3, 28 - 16, 8 - 3);
            g.FillRectangle(brush, startX + 35, startY + 3, 28 - 16, 8 - 3);
            g.FillRectangle(brush, startX + 17, startY + 1, 27 - 17, 3 - 1);
            g.FillRectangle(brush, startX + 36, startY + 1, 27 - 17, 3 - 1);
            base.DrawTransport(g);
        }

        public void SetTankColor(Color color)
        {
            tankColor = color;
        }
        public override string ToString()
        {
            return base.ToString() + ";"
                + typeLiquid + ";"
                + countLiquid + ";"
                + tankColor.Name;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TruckApp
{
    class Truck : Vehicle,IComparable<Truck>,IEquatable<Truck>
    {
        protected const int truckWidth = 90;
        protected const int truckHeight = 50;
        public bool flasher { protected set; get; }

        public Truck(int maxSpeed,
                        int countWheels,
                        float weight,
                        bool flasher,
                        Color bodyColor,
                        Color drivesColor,
                        Color frameColor)
        {
            this.maxSpeed = maxSpeed;
            this.countWheels = countWheels;
            this.weight = weight;
            this.flasher = flasher;
            this.bodyColor = bodyColor;
            this.drivesColor = drivesColor;
            this.frameColor = frameColor;
        }


        public override void DrawTransport(Graphics g)
        {
            Brush brush = new SolidBrush(bodyColor);
            g.FillRectangle(brush, startX + 64, startY + 4, 85 - 64, 43 - 4);
            if (flasher)
            {
                brush = new SolidBrush(Color.Orange);
                g.FillRectangle(brush, startX + 80, startY, 4, 4);
            }
            brush = new SolidBrush(frameColor);
            g.FillRectangle(brush, startX + 80, startY + 36, 85 - 80, 43 - 36);
            g.FillRectangle(brush, startX + 0, startY + 30, 63 - 0, 43 - 30);
            g.FillRectangle(brush, startX + 7, startY + 28, 52 - 7, 3);

            drawWheel(g, startX + 60, startY + 30);
            drawWheel(g, startX + 0, startY + 30);
            brush = new SolidBrush(Color.Black);
            switch (countWheels)
            {
                case 4:
                    brush = new SolidBrush(Color.Black);
                    g.FillRectangle(brush, startX + 58, startY + 8, 6, 16);
                    drawWheel(g, startX + 20, startY + 30);
                    break;
                case 3:
                    drawWheel(g, startX + 20, startY + 30);
                    break;
            }

            brush = new SolidBrush(Color.Yellow);
            g.FillRectangle(brush, startX + 83, startY + 33, 85 - 83, 39 - 33);

            Pen pen = new Pen(Color.Black);
            brush = new SolidBrush(Color.Black);
            g.DrawRectangle(pen, startX + 72, startY + 5, 84 - 72, 16 - 5);
            g.DrawLine(pen, startX + 84, startY + 5, startX + 87, startY + 8);
            g.FillRectangle(brush, startX + 87, startY + 8, 88 - 87, 15 - 7);
            g.DrawLine(pen, startX + 51, startY + 1, startX + 65, startY + 4);
        }

        private void drawWheel(Graphics g, float x, float y)
        {
            Brush brush = new SolidBrush(Color.Gray);
            g.FillRectangle(brush, x, y, 19, 12);
            Pen pen = new Pen(frameColor);
            g.DrawRectangle(pen, x, y, 19, 12);
            brush = new SolidBrush(Color.Black);
            g.FillEllipse(brush, x + 1, y + 1, 16, 16);
            brush = new SolidBrush(drivesColor);
            g.FillEllipse(brush, x + 4, y + 4, 10, 10);
        }

        public override void MoveTransport(Direction direction)
        {
            float step = maxSpeed * 100 / weight;
            switch (direction)
            {
                // вправо
                case Direction.Right:
                    if (startX + step < sizeX - truckWidth)
                    {
                        startX += step;
                    }
                    break;
                //влево
                case Direction.Left:
                    if (startX - step > 0)
                    {
                        startX -= step;
                    }
                    break;
                //вверх
                case Direction.Up:
                    if (startY - step > 0)
                    {
                        startY -= step;
                    }
                    break;
                //вниз
                case Direction.Down:
                    if (startY + step < sizeY - truckHeight)
                    {
                        startY += step;
                    }
                    break;
            }
        }
        public Truck(string info)
        {
            string[] strs = info.Split(';');
            if (strs.Length == 6)
            {
                maxSpeed = Convert.ToInt32(strs[0]);
                weight = Convert.ToInt32(strs[1]);
                bodyColor = Color.FromName(strs[2]);
                drivesColor = Color.FromName(strs[3]);
                flasher = Convert.ToBoolean(strs[4]);
                frameColor = Color.FromName(strs[5]);
            }
        }

        public override string ToString()
        {
            return maxSpeed + ";"
                + weight + ";"
                + bodyColor.Name + ";"
                + drivesColor.Name + ";"
                + flasher +";"
                + frameColor.Name ;
        }

        public bool Equals(Truck other)
        {
            if (other == null)
            {
                return false;
            }
            if (GetType().Name != other.GetType().Name)
            {
                return false;
            }
            if (maxSpeed != other.maxSpeed)
            {
                return false;
            }
            if (weight != other.weight)
            {
                return false;
            }
            if (bodyColor != other.bodyColor)
            {
                return false;
            }
            return true;
        }

        public int CompareTo(Truck other)
        {
            if (other == null)
            {
                return 1;
            }
            if (maxSpeed != other.maxSpeed)
            {
                return maxSpeed.CompareTo(other.maxSpeed);
            }
            if (weight != other.weight)
            {
                return weight.CompareTo(other.weight);
            }
            if (bodyColor != other.bodyColor)
            {
                bodyColor.Name.CompareTo(other.bodyColor.Name);
            }
            if (flasher != other.flasher)
            {
                flasher.CompareTo(other.flasher);
            }
            return 0;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override bool Equals(Object obj)
        {
            if (obj == null)
            {
                return false;
            }
            if (!(obj is Truck carObj))
            {
                return false;
            }
            else
            {
                return Equals(carObj);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TruckApp
{
    class FuelTruck
    {
        private float startX;
        private float startY;
        private int sizeX;
        private int sizeY;
        private int countWheels;
        private const int truckWidth = 90;
        private const int truckHeight = 50;
        public int maxSpeed { private set; get; }
        public float weight { private set; get; }
        public Color bodyColor { private set; get; }
        public Color tankColor { private set; get; }
        public Color drivesColor { private set; get; }

        public Color frameColor { private set; get; }

        public FuelTruck(int maxSpeed,
                        int countWheels,
                        float weight,
                        Color bodyColor,
                        Color tankColor,
                        Color drivesColor,
                        Color frameColor)
        {
            this.maxSpeed = maxSpeed;
            this.countWheels = countWheels;
            this.weight = weight;
            this.bodyColor = bodyColor;
            this.tankColor = tankColor;
            this.drivesColor = drivesColor;
            this.frameColor = frameColor;
        }

        public void setPosition(int x, int y, int sizeX, int sizeY)
        {
            startX = x;
            startY = y;
            this.sizeX = sizeX;
            this.sizeY = sizeY;
        }

        public void moveTruck(Direction direction)
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

        public void drawTruck(Graphics g)
        {            Brush brush = new SolidBrush(bodyColor);            g.FillRectangle(brush, startX+64, startY+4, 85-64, 43-4);

            brush = new SolidBrush(frameColor);
            g.FillRectangle(brush, startX + 80, startY + 36, 85 - 80, 43-36);
            g.FillRectangle(brush, startX + 0, startY + 30, 63-0, 43 - 30);
            g.FillRectangle(brush, startX + 7, startY + 28, 52 - 7, 3);

            brush = new SolidBrush(tankColor);
            g.FillRectangle(brush, startX + 3, startY + 8, 55 -3, 28 - 8);
            g.FillRectangle(brush, startX + 16, startY + 3, 28 - 16, 8 - 3);
            g.FillRectangle(brush, startX + 35, startY + 3, 28 - 16, 8 - 3);
            g.FillRectangle(brush, startX + 17, startY + 1, 27 - 17, 3 - 1);
            g.FillRectangle(brush, startX + 36, startY + 1, 27 - 17, 3 - 1);
            
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
            g.FillRectangle(brush,startX + 87, startY + 8, 88 - 87, 15 - 7);
            g.DrawLine(pen, startX + 51, startY + 1, startX + 65, startY + 4);
        }

        private void drawWheel(Graphics g, float x, float y)
        {
            Brush brush = new SolidBrush(Color.Gray);
            g.FillRectangle(brush, x , y , 19, 12);
            Pen pen = new Pen(frameColor);
            g.DrawRectangle(pen, x, y, 19, 12);
            brush = new SolidBrush(Color.Black);
            g.FillEllipse(brush, x + 1, y + 1, 16, 16);
            brush = new SolidBrush(drivesColor);
            g.FillEllipse(brush, x + 4, y + 4, 10, 10);
        }
    } 
}

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TruckApp
{
    public abstract class Vehicle : ITransport
    {
        protected float startX;
        protected float startY;
        protected int sizeX;
        protected int sizeY;
        protected int countWheels;
        public int maxSpeed { protected set; get; }
        public float weight { protected set; get; }
        public Color bodyColor { protected set; get; }
        public Color drivesColor { protected set; get; }
        public Color frameColor { protected set; get; }

        public void SetPosition(int x, int y, int width, int height)
        {
            startX = x;
            startY = y;
            this.sizeX = width;
            this.sizeY = height;

        }

        public abstract void MoveTransport(Direction direction);
        public abstract void DrawTransport(Graphics g);

    }

}

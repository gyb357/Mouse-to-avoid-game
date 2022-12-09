using System;
using System.Drawing;
using System.Windows.Forms;



namespace MTAG
{
    internal class Objects
    {
        public static Objects objects;
        public Objects()
        {
            objects = this;
        }



        public struct Vector2
        {
            public double x, y;
            public Vector2(double x, double y)
            {
                this.x = x;
                this.y = y;
            }
        }



        public double Clamp(double n, double min, double max)
        {
            if (n < min) { n = min; }
            if (n > max) { n = max; }

            return n;
        }



        public Vector2 GetPointDirection(Point p1, Point p2)
        {
            int     x     = p2.X - p1.X;
            int     y     = p2.Y - p1.Y;
            double length = Math.Sqrt(x * x + y * y);

            Vector2 dir = new Vector2(x / length, y / length);

            return dir;
        }



        public void ObjectMove_Linear(PictureBox o, Point p1, Point p2, double[] world, double spd)
        {
            Vector2 dir = GetPointDirection(p1, p2);

            world[0] += dir.x * spd;
            world[1] += dir.y * spd;
            world[0] = Clamp(world[0], p1.X, p2.X);
            world[1] = Clamp(world[1], p1.Y, p2.Y);

            o.Location = new Point((int)world[0], (int)world[1]);
        }



        public int ObjectMove_RoundTrip(PictureBox o, Point p1, Point p2, double[] world, double spd, int sign)
        {
            Point loc = o.Location;
            int   x   = loc.X;
            int   y   = loc.Y;

            if (!(x != p2.X || y != p2.Y) && sign == 1)  { sign = -1; }
            if (!(x != p1.X || y != p1.Y) && sign == -1) { sign = 1; }

            ObjectMove_Linear(o, p1, p2, world, spd * sign);

            return sign;
        }



        public Bitmap ObjectMove_Rotate(PictureBox backGround, Image image, PointF offset, float angle)
        {
            Bitmap rotatedBmp = new Bitmap(backGround.Width, backGround.Height);
                   rotatedBmp.SetResolution(image.HorizontalResolution, image.VerticalResolution);
            Graphics g = Graphics.FromImage(rotatedBmp);

            g.TranslateTransform(backGround.Width / 2, backGround.Height / 2);
            g.RotateTransform(angle);
            g.TranslateTransform(-offset.X, -offset.Y);
            g.DrawImage(image, new PointF(0, 0));
            g.Dispose();

            return rotatedBmp;
        }
    }
}

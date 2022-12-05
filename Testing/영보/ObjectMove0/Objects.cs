using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;



namespace ObjectMove0
{
    internal class Objects
    {
        public static Objects obj;
        public Objects()
        {
            obj = this;
        }



        // 값 제한 함수
        public double Clamp(double value, double min, double max)
        {
            if (value < min) value = min;
            if (value > max) value = max;
            return value;
        }



        // 선형 운동 함수
        public void ObjectMove_Linear(PictureBox o, Point p1, Point p2, double[] world, double spd)
        {
            int x = p2.X - p1.X;
            int y = p2.Y - p1.Y;
            double length = Math.Sqrt(x * x + y * y);
            double dirX = x / length;
            double dirY = y / length;


            world[0] += dirX * spd;
            world[1] += dirY * spd;
            world[0] = Clamp(world[0], p1.X, p2.X);
            world[1] = Clamp(world[1], p1.Y, p2.Y);


            o.Location = new Point((int)world[0], (int)world[1]);
        }



        // 왕복 운동 함수
        public int ObjectMove_RoundTrip(PictureBox o, Point p1, Point p2, double[] world, double spd, int sign)
        {
            Point loc = o.Location;
            int x = loc.X;
            int y = loc.Y;
            
            
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

            g.TranslateTransform(backGround.Width/2, backGround.Height/2);
            g.RotateTransform(angle);
            g.TranslateTransform(-offset.X, -offset.Y);
            g.DrawImage(image, new PointF(0, 0));
            g.Dispose();

            return rotatedBmp;
        }
    }
}

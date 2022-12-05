using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace ObjectMove0
{
    public partial class Form1 : Form
    {
        public Image fish_image;
        public Image opacity_image;

        public Form1()
        {
            InitializeComponent();


        }



        Objects obj = new Objects();



        // PictureBox1
        Point start1 = new Point(0, 0);
        Point target1 = new Point(300, 50);
        int sign1 = 1;
        double[] world1 = { 0, 0 };
        // PictureBox2
        Point start2 = new Point(200, 200);
        Point target2 = new Point(200, 400);
        int sign2 = 1;
        double[] world2 = { 0, 0 };
        // PictureBox4
        float angle1;
        float spd1 = 2;
        // PictureBox5
        float angle2;
        float spd2 = 4;



        private void timer1_Tick(object sender, EventArgs e)
        {
            sign1 = obj.ObjectMove_RoundTrip(pictureBox1, start1, target1, world1, 5, sign1);
            sign2 = obj.ObjectMove_RoundTrip(pictureBox2, start2, target2, world2, 6, sign2);


            angle1 += spd1;
            label1.Text = angle1.ToString();
            pictureBox4.Image = obj.ObjectMove_Rotate(pictureBox4, pictureBox3.Image, new PointF(pictureBox3.Image.Width / 2, pictureBox3.Image.Height/2), angle1);

            angle2 += spd2;
            label1.Text = angle2.ToString();
            pictureBox5.Image = obj.ObjectMove_Rotate(pictureBox5, pictureBox3.Image, new PointF(pictureBox3.Image.Width / 2, pictureBox3.Image.Height / 2), angle2);
        }
    }
}

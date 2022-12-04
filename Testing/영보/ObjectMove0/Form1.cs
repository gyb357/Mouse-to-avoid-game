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
        // PictureBox3
        Point start3 = new Point(50, 50);
        Point target3 = new Point(400, 400);
        int sign3 = 1;
        double[] world3 = { 0, 0 };


        private void timer1_Tick(object sender, EventArgs e)
        {
            sign1 = obj.ObjectMove_RoundTrip(pictureBox1, start1, target1, world1, 5, sign1);
            sign2 = obj.ObjectMove_RoundTrip(pictureBox2, start2, target2, world2, 6, sign2);
            sign3 = obj.ObjectMove_RoundTrip(pictureBox3, start3, target3, world3, 6, sign3);
        }
    }
}

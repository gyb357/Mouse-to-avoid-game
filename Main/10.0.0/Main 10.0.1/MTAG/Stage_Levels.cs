using System;
using System.ComponentModel.Design;
using System.Drawing;
using System.Windows.Forms;


namespace MTAG
{
    internal class Stage_Levels
    {
        public static Stage_Levels stage_levels;
        public Stage_Levels()
        {
            stage_levels = this;
        }



        public struct Object
        {
            public Point start;
            public Point end;
            public double spd;
            public int sign;
            public double[] world;
            public Object(Point p1, Point p2, double spd, int s)
            {
                this.start = p1;
                this.end = p2;
                this.spd = spd;
                this.sign = s;
                this.world = new double[2];
            }
        }



        Objects objects = new Objects();

        

        Object o1_3 = new Object(new Point(300, 100), new Point(300, 400), 20, 1);
        Object o1_4 = new Object(new Point(300, 100), new Point(300, 400), 20, 1);
        Object o1_51 = new Object(new Point(0, 488), new Point(330, 488), 10, 1);
        Object o1_52 = new Object(new Point(184, 0), new Point(184, 570), 8, 1);
        Object o1_53 = new Object(new Point(429, 0), new Point(429, 570), 12, 1);
        Object o1_61 = new Object(new Point(0, 0), new Point(0, 570), 10, 1);
        Object o1_62 = new Object(new Point(160, 0), new Point(160, 570), 8, 1);
        Object o1_63 = new Object(new Point(320, 0), new Point(320, 570), 12, 1);
        Object o1_64 = new Object(new Point(480, 0), new Point(480, 570), 20, 1);
        Object o1_65 = new Object(new Point(640, 0), new Point(640, 570), 8, 1);
        Object o2_11 = new Object(new Point(150, 100), new Point(150, 450), 10, 1);
        Object o2_12 = new Object(new Point(430, 150), new Point(430, 400), 8, 1);
        Object o2_21 = new Object(new Point(0, 0), new Point(150, 180), 10, 1);
        Object o2_22 = new Object(new Point(465, 0), new Point(465, 570), 35, 1);
        Object o2_23 = new Object(new Point(313, 0), new Point(313, 570), 20, 1);
        Object o2_41 = new Object(new Point(30, 110), new Point(300, 110), 10, 1);
        Object o2_42 = new Object(new Point(30, 210), new Point(300, 210), 25, 1);
        Object o2_43 = new Object(new Point(30, 310), new Point(300, 310), 20, 1);
        Object o2_44 = new Object(new Point(550, 110), new Point(700, 110), 8, 1);
        Object o2_45 = new Object(new Point(550, 210), new Point(700, 210), 7, 1);
        Object o2_46 = new Object(new Point(550, 310), new Point(700, 310), 5, 1);
        Object o2_51 = new Object(new Point(50, 450), new Point(50, 560), 3, 1);
        Object o2_52 = new Object(new Point(400, 242), new Point(400, 380), 7, 1);
        Object o2_53 = new Object(new Point(510, 242), new Point(510, 380), 9, 1);
        Object o2_54 = new Object(new Point(620, 242), new Point(620, 380), 3, 1);

        Object o3_41 = new Object(new Point(550, 0), new Point(550, 100), 5, 1);
        Object o3_42 = new Object(new Point(450, 0), new Point(450, 150), 7, 1);
        Object o3_43 = new Object(new Point(400, 0), new Point(400, 150), 9, 1);
        Object o3_44 = new Object(new Point(150, 200), new Point(150, 300), 3, 1);
        Object o3_45 = new Object(new Point(220, 200), new Point(220, 300), 2, 1);
        Object o3_46 = new Object(new Point(300, 200), new Point(300, 300), 3, 1);

        Object o3_51 = new Object(new Point(215, 55), new Point(412, 55), 8, 1);
        Object o3_52 = new Object(new Point(150, 140), new Point(512, 400), 12, 1);
        Object o3_53 = new Object(new Point(215, 500), new Point(432, 500), 9, 1);



        float angle;
        float angle1;


        public void StageLevels_Objects(int s, int l)
        {
            if (s == 1)
            {
                if      (l == 1) { }
                else if (l == 2) 
                {
                    Form1.form1.stage_level1.pictureBox10.Size = new Size(50,450);
                    Form1.form1.stage_level1.pictureBox10.Location = new Point(375, 75);
                }
                else if (l == 3) 
                {
                    Form1.form1.stage_level1.pictureBox10.Size = new Size(200,100);
                    o1_3.sign = objects.ObjectMove_RoundTrip(Form1.form1.stage_level1.pictureBox10, o1_3.start, o1_3.end, o1_3.world, o1_3.spd, o1_3.sign);
                }
                else if (l == 4) {
                    angle++;
                    Form1.form1.stage_level1.pictureBox15.Location = new Point(150, 50);
                    Form1.form1.stage_level1.pictureBox15.Size = new Size(500, 500);
                    Form1.form1.stage_level1.pictureBox19.Size = new Size(500, 20);
                    Form1.form1.stage_level1.pictureBox15.Image = objects.ObjectMove_Rotate(Form1.form1.stage_level1.pictureBox15, Form1.form1.stage_level1.pictureBox19.Image, new PointF(Form1.form1.stage_level1.pictureBox19.Width / 2, Form1.form1.stage_level1.pictureBox19.Height / 2), angle);
                }
                else if (l == 5) 
                {
                    Form1.form1.stage_level1.pictureBox10.Size = new Size(30, 150);
                    o1_51.sign = objects.ObjectMove_RoundTrip(Form1.form1.stage_level1.pictureBox10, o1_51.start, o1_51.end, o1_51.world, o1_51.spd, o1_51.sign);
                    Form1.form1.stage_level1.pictureBox11.Size = new Size(171, 30);
                    o1_52.sign = objects.ObjectMove_RoundTrip(Form1.form1.stage_level1.pictureBox11, o1_52.start, o1_52.end, o1_52.world, o1_52.spd, o1_52.sign);
                    Form1.form1.stage_level1.pictureBox12.Size = new Size(193, 30);
                    o1_53.sign = objects.ObjectMove_RoundTrip(Form1.form1.stage_level1.pictureBox12, o1_53.start, o1_53.end, o1_53.world, o1_53.spd, o1_53.sign);
                }
                else if (l == 6) 
                {
                    Form1.form1.stage_level1.pictureBox10.Size = new Size(160, 30);
                    o1_61.sign = objects.ObjectMove_RoundTrip(Form1.form1.stage_level1.pictureBox10, o1_61.start, o1_61.end, o1_61.world, o1_61.spd, o1_61.sign);
                    Form1.form1.stage_level1.pictureBox11.Size = new Size(160, 30);
                    o1_62.sign = objects.ObjectMove_RoundTrip(Form1.form1.stage_level1.pictureBox11, o1_62.start, o1_62.end, o1_62.world, o1_62.spd, o1_62.sign);
                    Form1.form1.stage_level1.pictureBox12.Size = new Size(160, 30);
                    o1_63.sign = objects.ObjectMove_RoundTrip(Form1.form1.stage_level1.pictureBox12, o1_63.start, o1_63.end, o1_63.world, o1_63.spd, o1_63.sign);
                    Form1.form1.stage_level1.pictureBox13.Size = new Size(160, 30);
                    o1_64.sign = objects.ObjectMove_RoundTrip(Form1.form1.stage_level1.pictureBox13, o1_64.start, o1_64.end, o1_64.world, o1_64.spd, o1_64.sign);
                    Form1.form1.stage_level1.pictureBox14.Size = new Size(118, 30);
                    o1_65.sign = objects.ObjectMove_RoundTrip(Form1.form1.stage_level1.pictureBox14, o1_65.start, o1_65.end, o1_65.world, o1_65.spd, o1_65.sign);
                }
            }
            else if (s == 2)
            {
                if (l == 1) 
                {
                    Form1.form1.stage_level1.pictureBox10.Size = new Size(160, 30);
                    o2_11.sign = objects.ObjectMove_RoundTrip(Form1.form1.stage_level1.pictureBox10, o2_11.start, o2_11.end, o2_11.world, o2_11.spd, o2_11.sign);
                    Form1.form1.stage_level1.pictureBox11.Size = new Size(160, 30);
                    o2_12.sign = objects.ObjectMove_RoundTrip(Form1.form1.stage_level1.pictureBox11, o2_12.start, o2_12.end, o2_12.world, o2_12.spd, o2_12.sign);
                }
                else if (l == 2) 
                {
                    Form1.form1.stage_level1.pictureBox10.Size = new Size(80, 30);
                    o2_21.sign = objects.ObjectMove_RoundTrip(Form1.form1.stage_level1.pictureBox10, o2_21.start, o2_21.end, o2_21.world, o2_21.spd, o2_21.sign);
                    Form1.form1.stage_level1.pictureBox11.Size = new Size(71, 30);
                    o2_22.sign = objects.ObjectMove_RoundTrip(Form1.form1.stage_level1.pictureBox11, o2_22.start, o2_22.end, o2_22.world, o2_22.spd, o2_22.sign);
                    Form1.form1.stage_level1.pictureBox12.Size = new Size(70, 30);
                    o2_23.sign = objects.ObjectMove_RoundTrip(Form1.form1.stage_level1.pictureBox12, o2_23.start, o2_23.end, o2_23.world, o2_23.spd, o2_23.sign);
                }
                else if (l == 3) {}
                else if (l == 4)
                {
                    Form1.form1.stage_level1.pictureBox1.Size = new Size(200, 100);
                    Form1.form1.stage_level1.pictureBox2.Size = new Size(200, 100);
                    Form1.form1.stage_level1.pictureBox3.Size = new Size(200, 100);
                    Form1.form1.stage_level1.pictureBox4.Size = new Size(80, 100);
                    Form1.form1.stage_level1.pictureBox5.Size = new Size(80, 100);
                    Form1.form1.stage_level1.pictureBox6.Size = new Size(80, 94);
                    Form1.form1.stage_level1.pictureBox7.Size = new Size(800, 110);
                    Form1.form1.stage_level1.pictureBox7.Location = new Point(0,0);
                    o2_41.sign = objects.ObjectMove_RoundTrip(Form1.form1.stage_level1.pictureBox1, o2_41.start, o2_41.end, o2_41.world, o2_41.spd, o2_41.sign);
                    o2_42.sign = objects.ObjectMove_RoundTrip(Form1.form1.stage_level1.pictureBox2, o2_42.start, o2_42.end, o2_42.world, o2_42.spd, o2_42.sign);
                    o2_43.sign = objects.ObjectMove_RoundTrip(Form1.form1.stage_level1.pictureBox3, o2_43.start, o2_43.end, o2_43.world, o2_43.spd, o2_43.sign);
                    o2_44.sign = objects.ObjectMove_RoundTrip(Form1.form1.stage_level1.pictureBox4, o2_44.start, o2_44.end, o2_44.world, o2_44.spd, o2_44.sign);
                    o2_45.sign = objects.ObjectMove_RoundTrip(Form1.form1.stage_level1.pictureBox5, o2_45.start, o2_45.end, o2_45.world, o2_45.spd, o2_45.sign);
                    o2_46.sign = objects.ObjectMove_RoundTrip(Form1.form1.stage_level1.pictureBox6, o2_46.start, o2_46.end, o2_46.world, o2_46.spd, o2_46.sign);
                }
                else if (l == 5) 
                {
                    Form1.form1.stage_level1.pictureBox1.Size = new Size(700,30);
                    Form1.form1.stage_level1.pictureBox10.Size = new Size(100, 50);
                    Form1.form1.stage_level1.pictureBox11.Size = new Size(100, 50);
                    Form1.form1.stage_level1.pictureBox12.Size = new Size(100, 50);

                    o2_51.sign = objects.ObjectMove_RoundTrip(Form1.form1.stage_level1.pictureBox1, o2_51.start, o2_51.end, o2_51.world, o2_51.spd, o2_51.sign);
                    o2_52.sign = objects.ObjectMove_RoundTrip(Form1.form1.stage_level1.pictureBox10, o2_52.start, o2_52.end, o2_52.world, o2_52.spd, o2_52.sign);
                    o2_53.sign = objects.ObjectMove_RoundTrip(Form1.form1.stage_level1.pictureBox11, o2_53.start, o2_53.end, o2_53.world, o2_53.spd, o2_53.sign);
                    o2_54.sign = objects.ObjectMove_RoundTrip(Form1.form1.stage_level1.pictureBox12, o2_54.start, o2_54.end, o2_54.world, o2_54.spd, o2_54.sign);
                }
                else if (l == 6) {
                    angle = angle + 2;
                    angle1 = angle1 + 3;
                    Form1.form1.stage_level1.pictureBox15.Location = new Point(520, 35);
                    Form1.form1.stage_level1.pictureBox15.Size = new Size(120, 120);
                    Form1.form1.stage_level1.pictureBox20.Size = new Size(120, 12);
                    Form1.form1.stage_level1.pictureBox16.Location = new Point(520, 190);
                    Form1.form1.stage_level1.pictureBox16.Size = new Size(120, 120);
                    Form1.form1.stage_level1.pictureBox17.Location = new Point(500, 360);
                    Form1.form1.stage_level1.pictureBox17.Size = new Size(120, 120);
                    Form1.form1.stage_level1.pictureBox15.Image = objects.ObjectMove_Rotate(Form1.form1.stage_level1.pictureBox15, Form1.form1.stage_level1.pictureBox20.Image, new PointF(Form1.form1.stage_level1.pictureBox20.Width / 2, Form1.form1.stage_level1.pictureBox20.Height / 2), angle);
                    Form1.form1.stage_level1.pictureBox16.Image = objects.ObjectMove_Rotate(Form1.form1.stage_level1.pictureBox16, Form1.form1.stage_level1.pictureBox20.Image, new PointF(Form1.form1.stage_level1.pictureBox20.Width / 2, Form1.form1.stage_level1.pictureBox20.Height / 2), angle1);
                    Form1.form1.stage_level1.pictureBox17.Image = objects.ObjectMove_Rotate(Form1.form1.stage_level1.pictureBox17, Form1.form1.stage_level1.pictureBox20.Image, new PointF(Form1.form1.stage_level1.pictureBox20.Width / 2, Form1.form1.stage_level1.pictureBox20.Height / 2), angle);
                }
            }
            else if (s == 3)
            {
                if      (l == 1) { }
                else if (l == 2) { }
                else if (l == 3) { }
                else if (l == 4)
                {
                    Form1.form1.stage_level1.pictureBox1.Size = new Size(100, 150);
                    Form1.form1.stage_level1.pictureBox2.Size = new Size(100, 100);
                    Form1.form1.stage_level1.pictureBox7.Size = new Size(50, 50);
                    Form1.form1.stage_level1.pictureBox4.Size = new Size(80, 60);
                    Form1.form1.stage_level1.pictureBox5.Size = new Size(80, 60);
                    Form1.form1.stage_level1.pictureBox6.Size = new Size(80, 60);
                    o3_41.sign = objects.ObjectMove_RoundTrip(Form1.form1.stage_level1.pictureBox1, o3_41.start, o3_41.end, o3_41.world, o3_41.spd, o3_41.sign);
                    o3_42.sign = objects.ObjectMove_RoundTrip(Form1.form1.stage_level1.pictureBox2, o3_42.start, o3_42.end, o3_42.world, o3_42.spd, o3_42.sign);
                    o3_43.sign = objects.ObjectMove_RoundTrip(Form1.form1.stage_level1.pictureBox7, o3_43.start, o3_43.end, o3_43.world, o3_43.spd, o3_43.sign);
                    o3_44.sign = objects.ObjectMove_RoundTrip(Form1.form1.stage_level1.pictureBox4, o3_44.start, o3_44.end, o3_44.world, o3_44.spd, o3_44.sign);
                    o3_45.sign = objects.ObjectMove_RoundTrip(Form1.form1.stage_level1.pictureBox5, o3_45.start, o3_45.end, o3_45.world, o3_45.spd, o3_45.sign);
                    o3_46.sign = objects.ObjectMove_RoundTrip(Form1.form1.stage_level1.pictureBox6, o3_46.start, o3_46.end, o3_46.world, o3_46.spd, o3_46.sign);
                }
                else if (l == 5)
                {
                    Form1.form1.stage_level1.pictureBox1.Size = new Size(170, 70);
                    Form1.form1.stage_level1.pictureBox2.Size = new Size(160, 60);
                    Form1.form1.stage_level1.pictureBox7.Size = new Size(150, 50);
                    o3_51.sign = objects.ObjectMove_RoundTrip(Form1.form1.stage_level1.pictureBox1, o3_51.start, o3_51.end, o3_51.world, o3_51.spd, o3_51.sign);
                    o3_52.sign = objects.ObjectMove_RoundTrip(Form1.form1.stage_level1.pictureBox2, o3_52.start, o3_52.end, o3_52.world, o3_52.spd, o3_52.sign);
                    o3_53.sign = objects.ObjectMove_RoundTrip(Form1.form1.stage_level1.pictureBox7, o3_53.start, o3_53.end, o3_53.world, o3_53.spd, o3_53.sign);
                }
                else if (l == 6) {}
            }
        }



        public void StageLevels_Queez(int active)
        {
            if (active == 1)
            {
                int k = (Form1.form1.ClientSize.Width - Form1.form1.stage_level1.button3.Size.Width) / 2;

                Form1.form1.stage_level1.label1.Visible  = true;
                Form1.form1.stage_level1.label2.Visible  = true;
                Form1.form1.stage_level1.button1.Visible = true;
                Form1.form1.stage_level1.button2.Visible = true;
                Form1.form1.stage_level1.button3.Visible = true;
                Form1.form1.stage_level1.button4.Visible = true;
                Form1.form1.stage_level1.button5.Visible = true;

                Form1.form1.stage_level1.button1.Location = new Point(k - 300, 400);
                Form1.form1.stage_level1.button2.Location = new Point(k - 150, 400);
                Form1.form1.stage_level1.button3.Location = new Point(k, 400);
                Form1.form1.stage_level1.button4.Location = new Point(k + 150, 400);
                Form1.form1.stage_level1.button5.Location = new Point(k + 300, 400);
                Form1.form1.stage_level1.label1.Location  = new Point((Form1.form1.ClientSize.Width - Form1.form1.stage_level1.label1.Size.Width) / 2, 100);
                Form1.form1.stage_level1.label2.Location  = new Point((Form1.form1.ClientSize.Width - Form1.form1.stage_level1.label2.Size.Width) / 2, 250);

                Form1.form1.stage_level1.label1.Text = "문제\n\n대기업 그룹의 사장이 죽기 직전, 벽에 유언을 남겼다. 과연 범인은 누구일까?";
                Form1.form1.stage_level1.label2.Text = "유언 : ㄸ뚜ㅁ뜨뜨";
            }
            else
            {
                Form1.form1.stage_level1.label1.Visible  = false;
                Form1.form1.stage_level1.label2.Visible  = false;
                Form1.form1.stage_level1.button1.Visible = false;
                Form1.form1.stage_level1.button2.Visible = false;
                Form1.form1.stage_level1.button3.Visible = false;
                Form1.form1.stage_level1.button4.Visible = false;
                Form1.form1.stage_level1.button5.Visible = false;
            }
        }



        public int StageLevels_RandomBox(int active, int time)
        {
            Random r = new Random();

            if (active == 1)
            {
                int x    = r.Next(800 - Form1.form1.stage_level1.pictureBox1.Size.Width);
                int y    = r.Next(600 - Form1.form1.stage_level1.pictureBox1.Size.Height);
                int temp = r.Next(8);

                if (temp == 1 && time % 50 == 1)
                {
                    Form1.form1.stage_level1.pictureBox1.Location  = new Point(x, y);
                    Form1.form1.stage_level1.pictureBox1.BackColor = Color.FromArgb(255, 242, 0);
                }
                else if (time % 50 == 1)
                {
                    Form1.form1.stage_level1.pictureBox1.Location  = new Point(x, y);
                    Form1.form1.stage_level1.pictureBox1.BackColor = Color.FromArgb(237, 28, 36);
                }

                Form1.form1.stage_level1.pictureBox1.Size = new Size(100, 100);
            }
            else
            {
                Form1.form1.stage_level1.pictureBox1.BackColor = Color.White;
            }

            if (time == 50) { time = 0; }

            return time;
        }
    }
}

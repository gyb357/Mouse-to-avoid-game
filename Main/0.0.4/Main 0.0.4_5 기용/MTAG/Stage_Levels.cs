﻿using System;
using System.Drawing;



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
            public Point    start;
            public Point    end;
            public double   spd;
            public int      sign;
            public double[] world;
            public Object (Point p1, Point p2, double spd, int s)
            {
                this.start = p1;
                this.end   = p2;
                this.spd   = spd;
                this.sign  = s;
                this.world = new double[2];
            }
        }



        Objects objects = new Objects();
        Object o1_3 = new Object(new Point(300, 100), new Point(300, 400), 20, 1);
        Object o1_51 = new Object(new Point(0, 488), new Point(330, 488), 10, 1);
        Object o1_52 = new Object(new Point(180, 0), new Point(180, 570), 8, 1);
        Object o1_53 = new Object(new Point(425, 0), new Point(425, 570), 12, 1);
        Object o1_61 = new Object(new Point(0, 0), new Point(0, 570), 10, 1);
        Object o1_62 = new Object(new Point(160, 0), new Point(160, 570), 8, 1);
        Object o1_63 = new Object(new Point(320, 0), new Point(320, 570), 12, 1);
        Object o1_64 = new Object(new Point(480, 0), new Point(480, 570), 20, 1);
        Object o1_65 = new Object(new Point(640, 0), new Point(640, 570), 8, 1);
        Object o2_11 = new Object(new Point(270, 100), new Point(270, 450), 10, 1);
        Object o2_12 = new Object(new Point(430, 150), new Point(430, 400), 8, 1);
        Object o2_21 = new Object(new Point(0, 0), new Point(155, 180), 10, 1);
        Object o2_22 = new Object(new Point(456, 0), new Point(456, 570), 35, 1);
        Object o2_23 = new Object(new Point(310, 0), new Point(310, 570), 20, 1);
        Object o2_41 = new Object(new Point(30, 110), new Point(300, 110), 10, 1);
        Object o2_42 = new Object(new Point(30, 210), new Point(300, 210), 25, 1);
        Object o2_43 = new Object(new Point(30, 310), new Point(300, 310), 20, 1);
        Object o2_44 = new Object(new Point(550, 110), new Point(700, 110), 8, 1);
        Object o2_45 = new Object(new Point(550, 210), new Point(700, 210), 7, 1);
        Object o2_46 = new Object(new Point(550, 310), new Point(700, 310), 12, 1);
        Object o2_51 = new Object(new Point(50, 450), new Point(50, 560), 3, 1);
        Object o2_52 = new Object(new Point(400, 242), new Point(400, 380), 7, 1);
        Object o2_53 = new Object(new Point(510, 242), new Point(510, 380), 9, 1);
        Object o2_54 = new Object(new Point(620, 242), new Point(620, 380), 3, 1);
        Object o1 = new Object(new Point(100, 100), new Point(600, 100), 5, 1);
        Object o2 = new Object(new Point(100, 100), new Point(600, 400), 5, 1);
        Object o3 = new Object(new Point(100, 400), new Point(600, 400), 5, 1);



        /*
        Boolean[] b = { true, true, true, false, false, false, false, false, false };
        


        public void StageLevels_PictureBox_Visible(Boolean[] b)
        {
            // 한번만 실행
            do
            {
                for (int i = 0; i < b.Length; i++)
                {
                    Form1.form1.stage_level1.pictureBox1.Visible = b[i];
                }
            } while (false);
        }
        */


        public void StageLevels_Objects(int stage, int level)
        {
            if (stage == 1)
            {
                if      (level == 1) 
                {
                    Form1.form1.stage_level1.pictureBox1.Visible = false;
                    Form1.form1.stage_level1.pictureBox2.Visible = false;
                    Form1.form1.stage_level1.pictureBox3.Visible = false;
                    Form1.form1.stage_level1.pictureBox4.Visible = false;
                    Form1.form1.stage_level1.pictureBox5.Visible = false;
                    Form1.form1.stage_level1.pictureBox6.Visible = false;
                    Form1.form1.stage_level1.pictureBox7.Visible = false;
                    Form1.form1.stage_level1.pictureBox8.Visible = false;
                    Form1.form1.stage_level1.pictureBox9.Visible = false;
                    Form1.form1.stage_level1.pictureBox10.Visible = false;
                    Form1.form1.stage_level1.pictureBox11.Visible = false;
                    Form1.form1.stage_level1.pictureBox12.Visible = false;
                    Form1.form1.stage_level1.pictureBox13.Visible = false;
                    Form1.form1.stage_level1.pictureBox14.Visible = false;
                }
                else if (level == 2) 
                {
                    Form1.form1.stage_level1.pictureBox1.Visible = false;
                    Form1.form1.stage_level1.pictureBox2.Visible = false;
                    Form1.form1.stage_level1.pictureBox3.Visible = false;
                    Form1.form1.stage_level1.pictureBox4.Visible = false;
                    Form1.form1.stage_level1.pictureBox5.Visible = false;
                    Form1.form1.stage_level1.pictureBox6.Visible = false;
                    Form1.form1.stage_level1.pictureBox7.Visible = false;
                    Form1.form1.stage_level1.pictureBox8.Visible = false;
                    Form1.form1.stage_level1.pictureBox9.Visible = false;
                    Form1.form1.stage_level1.pictureBox10.Visible = true;
                    Form1.form1.stage_level1.pictureBox11.Visible = false;
                    Form1.form1.stage_level1.pictureBox12.Visible = false;
                    Form1.form1.stage_level1.pictureBox13.Visible = false;
                    Form1.form1.stage_level1.pictureBox14.Visible = false;

                    Form1.form1.stage_level1.pictureBox10.Size = new Size(50,450);

                    Form1.form1.stage_level1.pictureBox10.Location = new Point(375, 75);
                }
                else if (level == 3) 
                {
                    Form1.form1.stage_level1.pictureBox1.Visible = false;
                    Form1.form1.stage_level1.pictureBox2.Visible = false;
                    Form1.form1.stage_level1.pictureBox3.Visible = false;
                    Form1.form1.stage_level1.pictureBox4.Visible = false;
                    Form1.form1.stage_level1.pictureBox5.Visible = false;
                    Form1.form1.stage_level1.pictureBox6.Visible = false;
                    Form1.form1.stage_level1.pictureBox7.Visible = false;
                    Form1.form1.stage_level1.pictureBox8.Visible = false;
                    Form1.form1.stage_level1.pictureBox9.Visible = false;
                    Form1.form1.stage_level1.pictureBox10.Visible = true;
                    Form1.form1.stage_level1.pictureBox11.Visible = false;
                    Form1.form1.stage_level1.pictureBox12.Visible = false;
                    Form1.form1.stage_level1.pictureBox13.Visible = false;
                    Form1.form1.stage_level1.pictureBox14.Visible = false;
                    Form1.form1.stage_level1.pictureBox10.Size = new Size(200,100);
                    o1_3.sign = objects.ObjectMove_RoundTrip(Form1.form1.stage_level1.pictureBox10, o1_3.start, o1_3.end, o1_3.world, o1_3.spd, o1_3.sign);
                }
                else if (level == 4) { }
                else if (level == 5) 
                {
                    Form1.form1.stage_level1.pictureBox1.Visible = false;
                    Form1.form1.stage_level1.pictureBox2.Visible = false;
                    Form1.form1.stage_level1.pictureBox3.Visible = false;
                    Form1.form1.stage_level1.pictureBox4.Visible = false;
                    Form1.form1.stage_level1.pictureBox5.Visible = false;
                    Form1.form1.stage_level1.pictureBox6.Visible = false;
                    Form1.form1.stage_level1.pictureBox7.Visible = false;
                    Form1.form1.stage_level1.pictureBox8.Visible = false;
                    Form1.form1.stage_level1.pictureBox9.Visible = false;
                    Form1.form1.stage_level1.pictureBox10.Visible = true;
                    Form1.form1.stage_level1.pictureBox11.Visible = true;
                    Form1.form1.stage_level1.pictureBox12.Visible = true;
                    Form1.form1.stage_level1.pictureBox13.Visible = false;
                    Form1.form1.stage_level1.pictureBox14.Visible = false;
                    Form1.form1.stage_level1.pictureBox10.Size = new Size(30, 150);
                    o1_51.sign = objects.ObjectMove_RoundTrip(Form1.form1.stage_level1.pictureBox10, o1_51.start, o1_51.end, o1_51.world, o1_51.spd, o1_51.sign);
                    Form1.form1.stage_level1.pictureBox11.Size = new Size(180, 30);
                    o1_52.sign = objects.ObjectMove_RoundTrip(Form1.form1.stage_level1.pictureBox11, o1_52.start, o1_52.end, o1_52.world, o1_52.spd, o1_52.sign);
                    Form1.form1.stage_level1.pictureBox12.Size = new Size(200, 30);
                    o1_53.sign = objects.ObjectMove_RoundTrip(Form1.form1.stage_level1.pictureBox12, o1_53.start, o1_53.end, o1_53.world, o1_53.spd, o1_53.sign);
                }
                else if (level == 6) 
                {
                    Form1.form1.stage_level1.pictureBox1.Visible = false;
                    Form1.form1.stage_level1.pictureBox2.Visible = false;
                    Form1.form1.stage_level1.pictureBox3.Visible = false;
                    Form1.form1.stage_level1.pictureBox4.Visible = false;
                    Form1.form1.stage_level1.pictureBox5.Visible = false;
                    Form1.form1.stage_level1.pictureBox6.Visible = false;
                    Form1.form1.stage_level1.pictureBox7.Visible = false;
                    Form1.form1.stage_level1.pictureBox8.Visible = false;
                    Form1.form1.stage_level1.pictureBox9.Visible = false;
                    Form1.form1.stage_level1.pictureBox10.Visible = true;
                    Form1.form1.stage_level1.pictureBox11.Visible = true;
                    Form1.form1.stage_level1.pictureBox12.Visible = true;
                    Form1.form1.stage_level1.pictureBox13.Visible = true;
                    Form1.form1.stage_level1.pictureBox14.Visible = true;
                    Form1.form1.stage_level1.pictureBox10.Size = new Size(160, 30);
                    o1_61.sign = objects.ObjectMove_RoundTrip(Form1.form1.stage_level1.pictureBox10, o1_61.start, o1_61.end, o1_61.world, o1_61.spd, o1_61.sign);
                    Form1.form1.stage_level1.pictureBox11.Size = new Size(160, 30);
                    o1_62.sign = objects.ObjectMove_RoundTrip(Form1.form1.stage_level1.pictureBox11, o1_62.start, o1_62.end, o1_62.world, o1_62.spd, o1_62.sign);
                    Form1.form1.stage_level1.pictureBox12.Size = new Size(160, 30);
                    o1_63.sign = objects.ObjectMove_RoundTrip(Form1.form1.stage_level1.pictureBox12, o1_63.start, o1_63.end, o1_63.world, o1_63.spd, o1_63.sign);
                    Form1.form1.stage_level1.pictureBox13.Size = new Size(160, 30);
                    o1_64.sign = objects.ObjectMove_RoundTrip(Form1.form1.stage_level1.pictureBox13, o1_64.start, o1_64.end, o1_64.world, o1_64.spd, o1_64.sign);
                    Form1.form1.stage_level1.pictureBox14.Size = new Size(120, 30);
                    o1_65.sign = objects.ObjectMove_RoundTrip(Form1.form1.stage_level1.pictureBox14, o1_65.start, o1_65.end, o1_65.world, o1_65.spd, o1_65.sign);
                }
                else 
                {
                    
                };
            }
            else if (stage == 2)
            {
                if      (level == 1) 
                {
                    Form1.form1.stage_level1.pictureBox1.Visible = false;
                    Form1.form1.stage_level1.pictureBox2.Visible = false;
                    Form1.form1.stage_level1.pictureBox3.Visible = false;
                    Form1.form1.stage_level1.pictureBox4.Visible = false;
                    Form1.form1.stage_level1.pictureBox5.Visible = false;
                    Form1.form1.stage_level1.pictureBox6.Visible = false;
                    Form1.form1.stage_level1.pictureBox7.Visible = false;
                    Form1.form1.stage_level1.pictureBox8.Visible = false;
                    Form1.form1.stage_level1.pictureBox9.Visible = false;
                    Form1.form1.stage_level1.pictureBox10.Visible = true;
                    Form1.form1.stage_level1.pictureBox11.Visible = true;
                    Form1.form1.stage_level1.pictureBox12.Visible = false;
                    Form1.form1.stage_level1.pictureBox13.Visible = false;
                    Form1.form1.stage_level1.pictureBox14.Visible = false;
                    Form1.form1.stage_level1.pictureBox10.Size = new Size(160, 30);
                    o2_11.sign = objects.ObjectMove_RoundTrip(Form1.form1.stage_level1.pictureBox10, o2_11.start, o2_11.end, o2_11.world, o2_11.spd, o2_11.sign);
                    Form1.form1.stage_level1.pictureBox11.Size = new Size(160, 30);
                    o2_12.sign = objects.ObjectMove_RoundTrip(Form1.form1.stage_level1.pictureBox11, o2_12.start, o2_12.end, o2_12.world, o2_12.spd, o2_12.sign);
                }
                else if (level == 2) 
                {
                    Form1.form1.stage_level1.pictureBox1.Visible = false;
                    Form1.form1.stage_level1.pictureBox2.Visible = false;
                    Form1.form1.stage_level1.pictureBox3.Visible = false;
                    Form1.form1.stage_level1.pictureBox4.Visible = false;
                    Form1.form1.stage_level1.pictureBox5.Visible = false;
                    Form1.form1.stage_level1.pictureBox6.Visible = false;
                    Form1.form1.stage_level1.pictureBox7.Visible = false;
                    Form1.form1.stage_level1.pictureBox8.Visible = false;
                    Form1.form1.stage_level1.pictureBox9.Visible = false;
                    Form1.form1.stage_level1.pictureBox10.Visible = true;
                    Form1.form1.stage_level1.pictureBox11.Visible = true;
                    Form1.form1.stage_level1.pictureBox12.Visible = true;
                    Form1.form1.stage_level1.pictureBox13.Visible = false;
                    Form1.form1.stage_level1.pictureBox14.Visible = false;
                    Form1.form1.stage_level1.pictureBox10.Size = new Size(80, 30);
                    o2_21.sign = objects.ObjectMove_RoundTrip(Form1.form1.stage_level1.pictureBox10, o2_21.start, o2_21.end, o2_21.world, o2_21.spd, o2_21.sign);
                    Form1.form1.stage_level1.pictureBox11.Size = new Size(80, 30);
                    o2_22.sign = objects.ObjectMove_RoundTrip(Form1.form1.stage_level1.pictureBox11, o2_22.start, o2_22.end, o2_22.world, o2_22.spd, o2_22.sign);
                    Form1.form1.stage_level1.pictureBox12.Size = new Size(80, 30);
                    o2_23.sign = objects.ObjectMove_RoundTrip(Form1.form1.stage_level1.pictureBox12, o2_23.start, o2_23.end, o2_23.world, o2_23.spd, o2_23.sign);
                }
                else if (level == 3)
                {
                    Form1.form1.stage_level1.pictureBox1.Visible = false;
                    Form1.form1.stage_level1.pictureBox2.Visible = false;
                    Form1.form1.stage_level1.pictureBox3.Visible = false;
                    Form1.form1.stage_level1.pictureBox4.Visible = false;
                    Form1.form1.stage_level1.pictureBox5.Visible = false;
                    Form1.form1.stage_level1.pictureBox6.Visible = false;
                    Form1.form1.stage_level1.pictureBox7.Visible = false;
                    Form1.form1.stage_level1.pictureBox8.Visible = false;
                    Form1.form1.stage_level1.pictureBox9.Visible = false;
                    Form1.form1.stage_level1.pictureBox10.Visible = false;
                    Form1.form1.stage_level1.pictureBox11.Visible = false;
                    Form1.form1.stage_level1.pictureBox12.Visible = false;
                    Form1.form1.stage_level1.pictureBox13.Visible = false;
                    Form1.form1.stage_level1.pictureBox14.Visible = false;
                }
                else if (level == 4)
                {
                    Form1.form1.stage_level1.pictureBox1.Visible = true;
                    Form1.form1.stage_level1.pictureBox2.Visible = true;
                    Form1.form1.stage_level1.pictureBox3.Visible = true;
                    Form1.form1.stage_level1.pictureBox4.Visible = true;
                    Form1.form1.stage_level1.pictureBox5.Visible = true;
                    Form1.form1.stage_level1.pictureBox6.Visible = true;
                    Form1.form1.stage_level1.pictureBox7.Visible = true;
                    Form1.form1.stage_level1.pictureBox8.Visible = false;
                    Form1.form1.stage_level1.pictureBox9.Visible = false;
                    Form1.form1.stage_level1.pictureBox10.Visible = false;
                    Form1.form1.stage_level1.pictureBox11.Visible = false;
                    Form1.form1.stage_level1.pictureBox12.Visible = false;
                    Form1.form1.stage_level1.pictureBox13.Visible = false;
                    Form1.form1.stage_level1.pictureBox14.Visible = false;
                    Form1.form1.stage_level1.pictureBox1.Size = new Size(200, 100);
                    Form1.form1.stage_level1.pictureBox2.Size = new Size(200, 100);
                    Form1.form1.stage_level1.pictureBox3.Size = new Size(200, 100);
                    Form1.form1.stage_level1.pictureBox4.Size = new Size(80, 100);
                    Form1.form1.stage_level1.pictureBox5.Size = new Size(80, 100);
                    Form1.form1.stage_level1.pictureBox6.Size = new Size(80, 100);
                    Form1.form1.stage_level1.pictureBox7.Size = new Size(800, 110);
                    Form1.form1.stage_level1.pictureBox7.Location = new Point(0,0);
                    o2_41.sign = objects.ObjectMove_RoundTrip(Form1.form1.stage_level1.pictureBox1, o2_41.start, o2_41.end, o2_41.world, o2_41.spd, o2_41.sign);
                    o2_42.sign = objects.ObjectMove_RoundTrip(Form1.form1.stage_level1.pictureBox2, o2_42.start, o2_42.end, o2_42.world, o2_42.spd, o2_42.sign);
                    o2_43.sign = objects.ObjectMove_RoundTrip(Form1.form1.stage_level1.pictureBox3, o2_43.start, o2_43.end, o2_43.world, o2_43.spd, o2_43.sign);
                    o2_44.sign = objects.ObjectMove_RoundTrip(Form1.form1.stage_level1.pictureBox4, o2_44.start, o2_44.end, o2_44.world, o2_44.spd, o2_44.sign);
                    o2_45.sign = objects.ObjectMove_RoundTrip(Form1.form1.stage_level1.pictureBox5, o2_45.start, o2_45.end, o2_45.world, o2_45.spd, o2_45.sign);
                    o2_46.sign = objects.ObjectMove_RoundTrip(Form1.form1.stage_level1.pictureBox6, o2_46.start, o2_46.end, o2_46.world, o2_46.spd, o2_46.sign);


                }
                else if (level == 5) 
                {
                    Form1.form1.stage_level1.pictureBox1.Visible = true;
                    Form1.form1.stage_level1.pictureBox2.Visible = false;
                    Form1.form1.stage_level1.pictureBox3.Visible = false;
                    Form1.form1.stage_level1.pictureBox4.Visible = false;
                    Form1.form1.stage_level1.pictureBox5.Visible = false;
                    Form1.form1.stage_level1.pictureBox6.Visible = false;
                    Form1.form1.stage_level1.pictureBox7.Visible = false;
                    Form1.form1.stage_level1.pictureBox8.Visible = false;
                    Form1.form1.stage_level1.pictureBox9.Visible = false;
                    Form1.form1.stage_level1.pictureBox10.Visible = true;
                    Form1.form1.stage_level1.pictureBox11.Visible = true;
                    Form1.form1.stage_level1.pictureBox12.Visible = true;
                    Form1.form1.stage_level1.pictureBox13.Visible = false;
                    Form1.form1.stage_level1.pictureBox14.Visible = false;

                    Form1.form1.stage_level1.pictureBox1.Size = new Size(700,30);
                    Form1.form1.stage_level1.pictureBox10.Size = new Size(100, 50);
                    Form1.form1.stage_level1.pictureBox11.Size = new Size(100, 50);
                    Form1.form1.stage_level1.pictureBox12.Size = new Size(100, 50);

                    o2_51.sign = objects.ObjectMove_RoundTrip(Form1.form1.stage_level1.pictureBox1, o2_51.start, o2_51.end, o2_51.world, o2_51.spd, o2_51.sign);
                    o2_52.sign = objects.ObjectMove_RoundTrip(Form1.form1.stage_level1.pictureBox10, o2_52.start, o2_52.end, o2_52.world, o2_52.spd, o2_52.sign);
                    o2_53.sign = objects.ObjectMove_RoundTrip(Form1.form1.stage_level1.pictureBox11, o2_53.start, o2_53.end, o2_53.world, o2_53.spd, o2_53.sign);
                    o2_54.sign = objects.ObjectMove_RoundTrip(Form1.form1.stage_level1.pictureBox12, o2_54.start, o2_54.end, o2_54.world, o2_54.spd, o2_54.sign);
                }
                else if (level == 6) 
                {
                    Form1.form1.stage_level1.pictureBox1.Visible = false;
                    Form1.form1.stage_level1.pictureBox2.Visible = false;
                    Form1.form1.stage_level1.pictureBox3.Visible = false;
                    Form1.form1.stage_level1.pictureBox4.Visible = false;
                    Form1.form1.stage_level1.pictureBox5.Visible = false;
                    Form1.form1.stage_level1.pictureBox6.Visible = false;
                    Form1.form1.stage_level1.pictureBox7.Visible = false;
                    Form1.form1.stage_level1.pictureBox8.Visible = false;
                    Form1.form1.stage_level1.pictureBox9.Visible = false;
                    Form1.form1.stage_level1.pictureBox10.Visible = true;
                    Form1.form1.stage_level1.pictureBox11.Visible = true;
                    Form1.form1.stage_level1.pictureBox12.Visible = true;
                    Form1.form1.stage_level1.pictureBox13.Visible = false;
                    Form1.form1.stage_level1.pictureBox14.Visible = false;
                }
            }
            else if (stage == 3)
            {
                if      (level == 1) { }
                else if (level == 2) { }
                else if (level == 3) { }
                else if (level == 4) { }
                else if (level == 5)
                {
                    Form1.form1.stage_level1.pictureBox1.Visible = true;
                    Form1.form1.stage_level1.pictureBox2.Visible = true;
                    Form1.form1.stage_level1.pictureBox3.Visible = true;
                    //StageLevels_PictureBox_Visible(b);

                    o1.sign = objects.ObjectMove_RoundTrip(Form1.form1.stage_level1.pictureBox1, o1.start, o1.end, o1.world, o1.spd, o1.sign);
                    o2.sign = objects.ObjectMove_RoundTrip(Form1.form1.stage_level1.pictureBox2, o2.start, o2.end, o2.world, o2.spd, o2.sign);
                    o3.sign = objects.ObjectMove_RoundTrip(Form1.form1.stage_level1.pictureBox3, o3.start, o3.end, o3.world, o3.spd, o3.sign);
                }
                else if (level == 6) {}
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

                Form1.form1.stage_level1.pictureBox1.Visible = true;
                Form1.form1.stage_level1.pictureBox1.Size    = new Size(100, 100);
            }
            else { Form1.form1.stage_level1.pictureBox1.Visible = false; }

            if (time == 50) { time = 0; }

            return time;
        }
    }
}

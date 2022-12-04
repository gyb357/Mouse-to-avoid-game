using System;
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
                if      (level == 1) { }
                else if (level == 2) { }
                else if (level == 3) { }
                else if (level == 4) { }
                else if (level == 5) { }
                else if (level == 6) { }
            }
            else if (stage == 2)
            {
                if      (level == 1) { }
                else if (level == 2) { }
                else if (level == 3) { }
                else if (level == 4) { }
                else if (level == 5) { }
                else if (level == 6) { }
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

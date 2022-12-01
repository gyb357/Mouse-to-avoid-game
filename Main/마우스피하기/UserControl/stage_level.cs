using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace UserControl0
{
    public partial class stage_level : UserControl
    {
        public stage_level()
        {
            InitializeComponent();
        }



        private void stage_level_KeyDown(object sender, KeyEventArgs e)
        {
            // Ecs 키를 눌렀을 경우
            if (e.KeyCode == Keys.Escape)
            {
                // 마우스 위치 저장
                MTAG.form1.mousePoint = Cursor.Position;


                // game_pause1.cs (일시 정지 화면) 로 이동
                MTAG.form1.UserControlVisible(MTAG.form1.game_pause1, this);
            }
        }

        private void stage_level_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            string[] st = {"1-1.png", "1-2.png", "1-3.png", "1-4.png" , "1-5.png" , "1-6.png", "2-1.png", "2-2.png", "2-3.png" }; // 스테이지 png 파일
            Image img;
            TextureBrush b;
            if (MTAG.form1.stage == 1 && MTAG.form1.level == 1)// level이 1이면 1레벨 이미지가 띄워진 스테이지로 이동, stage까지 고려하면 좋을듯 조금 길어지긴 하는데, 마우스 포인터 강제 이동 필요 시작위치 정해서
            {
                MTAG.form1.stage_level1.label1.Text = "1-1";
                MTAG.form1.stage_level1.pictureBox2.Visible = false;
                img = new Bitmap(st[0]);
                b = new TextureBrush(img);
                g.FillRectangle(b, ClientRectangle);
            }
           else if (MTAG.form1.stage == 1 && MTAG.form1.level == 2)
            {
                MTAG.form1.stage_level1.label1.Text = "1-2";
                MTAG.form1.stage_level1.pictureBox2.Visible = true;
                MTAG.form1.stage_level1.pictureBox2.Location = new Point(300,300);
                MTAG.form1.stage_level1.pictureBox2.Size = new Size(200,100);
                img = new Bitmap(st[1]);
                b = new TextureBrush(img);
                g.FillRectangle(b, ClientRectangle);
            }
            else if (MTAG.form1.stage == 1 && MTAG.form1.level == 3)
            {
                MTAG.form1.stage_level1.label1.Text = "1-3";
                MTAG.form1.stage_level1.pictureBox2.Visible = true;
                //MTAG.form1.stage_level1.pictureBox2.Location = new Point(30, 100);
                MTAG.form1.stage_level1.pictureBox2.Size = new Size(100, 300);
                img = new Bitmap(st[2]);
                b = new TextureBrush(img);
                g.FillRectangle(b, ClientRectangle);
            }
            else if (MTAG.form1.stage == 1 && MTAG.form1.level == 4)
            {
                MTAG.form1.stage_level1.label1.Text = "1-4";
                MTAG.form1.stage_level1.pictureBox2.Visible = false;
                img = new Bitmap(st[3]);
                b = new TextureBrush(img);
                g.FillRectangle(b, ClientRectangle);
            }
            else if (MTAG.form1.stage == 1 && MTAG.form1.level == 5)
            {
                MTAG.form1.stage_level1.label1.Text = "1-5";
                img = new Bitmap(st[4]);
                b = new TextureBrush(img);
                g.FillRectangle(b, ClientRectangle);
            }
            else if (MTAG.form1.stage == 1 && MTAG.form1.level == 6)
            {
                MTAG.form1.stage_level1.label1.Text = "1-6";
                img = new Bitmap(st[5]);
                b = new TextureBrush(img);
                g.FillRectangle(b, ClientRectangle);
            }
            else if (MTAG.form1.stage == 2 && MTAG.form1.level == 1)
            {
                MTAG.form1.stage_level1.label1.Text = "2-1";
                img = new Bitmap(st[6]);
                b = new TextureBrush(img);
                g.FillRectangle(b, ClientRectangle);
            }
            else if (MTAG.form1.stage == 2 && MTAG.form1.level == 2)
            {
                MTAG.form1.stage_level1.label1.Text = "2-2";
                img = new Bitmap(st[7]);
                b = new TextureBrush(img);
                g.FillRectangle(b, ClientRectangle);
            }
            else if (MTAG.form1.stage == 2 && MTAG.form1.level == 3)
            {
                MTAG.form1.stage_level1.label1.Text = "2-3";
                img = new Bitmap(st[8]);
                b = new TextureBrush(img);
                g.FillRectangle(b, ClientRectangle);
            }
        }

        Boolean temp = false;
        private void timer1_Tick(object sender, EventArgs e)
        {
            int x = MTAG.form1.stage_level1.pictureBox2.Location.X;
            int y = MTAG.form1.stage_level1.pictureBox2.Location.Y;
            if (MTAG.form1.level == 3)
            {
                if (y >= 500)
                {
                    temp = false;
                }
                else if (y <= 0)
                {
                    temp = true;
                }
                if (temp == false)
                {
                    y -= 3;
                }
                else if (temp == true)
                {
                    y += 3;
                }
                MTAG.form1.stage_level1.pictureBox2.Location = new Point(x, y);
            }
        }
    }
}

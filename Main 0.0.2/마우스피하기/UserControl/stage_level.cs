using System;
using System.Drawing;
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
            Image img;
            TextureBrush b;
            string[] st = {"1-1.png", "1-2.png", "1-3.png", "1-4.png" , "1-5.png" , "1-6.png"
                           , "2-1.png", "2-2.png", "2-3.png", "2-4.png", "2-5.png", "2-6.png"
                           , "3-1.png", "3-2.png", "3-3.png", "3-4.png", "3-5.png", "3-6.png"}; // 스테이지 png 파일
            try
            {
                if (MTAG.form1.stage == 1 && MTAG.form1.level == 1) // level이 1이면 1레벨 이미지가 띄워진 스테이지로 이동, stage까지 고려하면 좋을듯 조금 길어지긴 하는데, 마우스 포인터 강제 이동 필요 시작위치 정해서
                {
                    MTAG.form1.stage_level1.label1.Text = "1-1";
                    img = new Bitmap(st[0]);
                    b = new TextureBrush(img);
                    g.FillRectangle(b, ClientRectangle);
                    b.Dispose();
                    img.Dispose();
                }
                else if (MTAG.form1.stage == 1 && MTAG.form1.level == 2)
                {
                    MTAG.form1.stage_level1.label1.Text = "1-2";
                    img = new Bitmap(st[1]);
                    b = new TextureBrush(img);
                    g.FillRectangle(b, ClientRectangle);
                    b.Dispose();
                    img.Dispose();
                }
                else if (MTAG.form1.stage == 1 && MTAG.form1.level == 3)
                {
                    MTAG.form1.stage_level1.label1.Text = "1-3";
                    img = new Bitmap(st[2]);
                    b = new TextureBrush(img);
                    g.FillRectangle(b, ClientRectangle);
                    b.Dispose();
                    img.Dispose();
                }
                else if (MTAG.form1.stage == 1 && MTAG.form1.level == 4)
                {
                    MTAG.form1.stage_level1.label1.Text = "1-4";
                    img = new Bitmap(st[3]);
                    b = new TextureBrush(img);
                    g.FillRectangle(b, ClientRectangle);
                    b.Dispose();
                    img.Dispose();
                }
                else if (MTAG.form1.stage == 1 && MTAG.form1.level == 5)
                {
                    MTAG.form1.stage_level1.label1.Text = "1-5";
                    img = new Bitmap(st[4]);
                    b = new TextureBrush(img);
                    g.FillRectangle(b, ClientRectangle);
                    b.Dispose();
                    img.Dispose();
                }
                else if (MTAG.form1.stage == 1 && MTAG.form1.level == 6)
                {
                    MTAG.form1.stage_level1.label1.Text = "1-6";
                    img = new Bitmap(st[5]);
                    b = new TextureBrush(img);
                    g.FillRectangle(b, ClientRectangle);
                    b.Dispose();
                    img.Dispose();
                }
                else if (MTAG.form1.stage == 2 && MTAG.form1.level == 1)
                {
                    MTAG.form1.stage_level1.label1.Text = "2-1";
                    img = new Bitmap(st[6]);
                    b = new TextureBrush(img);
                    g.FillRectangle(b, ClientRectangle);
                    b.Dispose();
                    img.Dispose();
                }
                else if (MTAG.form1.stage == 2 && MTAG.form1.level == 2)
                {
                    MTAG.form1.stage_level1.label1.Text = "2-2";
                    img = new Bitmap(st[7]);
                    b = new TextureBrush(img);
                    g.FillRectangle(b, ClientRectangle);
                    b.Dispose();
                    img.Dispose();
                }
                else if (MTAG.form1.stage == 2 && MTAG.form1.level == 3)
                {
                    MTAG.form1.stage_level1.label1.Text = "2-3";
                    img = new Bitmap(st[8]);
                    b = new TextureBrush(img);
                    g.FillRectangle(b, ClientRectangle);
                    b.Dispose();
                    img.Dispose();
                }
                else if (MTAG.form1.stage == 2 && MTAG.form1.level == 4)
                {
                    MTAG.form1.stage_level1.label1.Text = "2-4";
                    img = new Bitmap(st[9]);
                    b = new TextureBrush(img);
                    g.FillRectangle(b, ClientRectangle);
                    b.Dispose();
                    img.Dispose();
                }
                else if (MTAG.form1.stage == 2 && MTAG.form1.level == 5)
                {
                    MTAG.form1.stage_level1.label1.Text = "2-5";
                    img = new Bitmap(st[10]);
                    b = new TextureBrush(img);
                    g.FillRectangle(b, ClientRectangle);
                    b.Dispose();
                    img.Dispose();
                }
                else if (MTAG.form1.stage == 2 && MTAG.form1.level == 6)
                {
                    MTAG.form1.stage_level1.label1.Text = "2-6";
                    img = new Bitmap(st[11]);
                    b = new TextureBrush(img);
                    g.FillRectangle(b, ClientRectangle);
                    b.Dispose();
                    img.Dispose();
                }
                else if (MTAG.form1.stage == 3 && MTAG.form1.level == 1)
                {
                    MTAG.form1.stage_level1.label1.Text = "3-1";
                    img = new Bitmap(st[12]);
                    b = new TextureBrush(img);
                    g.FillRectangle(b, ClientRectangle);
                    b.Dispose();
                    img.Dispose();
                }
                else if (MTAG.form1.stage == 3 && MTAG.form1.level == 2)
                {
                    MTAG.form1.stage_level1.label1.Text = "3-2";
                    img = new Bitmap(st[13]);
                    b = new TextureBrush(img);
                    g.FillRectangle(b, ClientRectangle);
                    b.Dispose();
                    img.Dispose();
                }
                else if (MTAG.form1.stage == 3 && MTAG.form1.level == 3)
                {
                    MTAG.form1.stage_level1.label1.Text = "3-3";
                    img = new Bitmap(st[14]);
                    b = new TextureBrush(img);
                    g.FillRectangle(b, ClientRectangle);
                    b.Dispose();
                    img.Dispose();
                }
                else if (MTAG.form1.stage == 3 && MTAG.form1.level == 4)
                {
                    MTAG.form1.stage_level1.label1.Text = "3-4";
                    img = new Bitmap(st[15]);
                    b = new TextureBrush(img);
                    g.FillRectangle(b, ClientRectangle);
                    b.Dispose();
                    img.Dispose();
                }
                else if (MTAG.form1.stage == 3 && MTAG.form1.level == 5)
                {
                    MTAG.form1.stage_level1.label1.Text = "3-5";
                    img = new Bitmap(st[16]);
                    b = new TextureBrush(img);
                    g.FillRectangle(b, ClientRectangle);
                    b.Dispose();
                    img.Dispose();
                }
                else if (MTAG.form1.stage == 3 && MTAG.form1.level == 6)
                {
                    MTAG.form1.stage_level1.label1.Text = "3-6";
                    img = new Bitmap(st[17]);
                    b = new TextureBrush(img);
                    g.FillRectangle(b, ClientRectangle);
                    b.Dispose();
                    img.Dispose();
                }
            }
            catch{}
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MTAG.form1.UserControlVisible(MTAG.form1.game_over1, MTAG.form1.stage_level1);          
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MTAG.form1.UserControlVisible(MTAG.form1.game_success1, MTAG.form1.stage_level1);
        }
    }
}

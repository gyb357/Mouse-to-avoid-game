using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace MTAG
{
    public partial class Form1 : Form
    {
        public static Form1 form1;
        public Form1()
        {
            InitializeComponent();



            form1 = this;



            UserControl[] userControl = new UserControl[]
            {
                main1,
                how_to_play1,
                select_stage1, select_level1,
                stage_level1,
                game_success1, game_over1, game_pause1
            };

            int     offset     = 25;
            Point   point      = new Point(0, 0);
            Size    clientSize = new Size(ClientSize.Width, ClientSize.Height - offset);
            Color   backColor  = Color.White;
            Boolean visible    = false;

            for (int i = 0; i < userControl.Length; i++)
            {
                InitializeUserControl(userControl[i], point, clientSize, backColor, visible);
            }



            main1.Visible = true;
        }



        Mouse mouse = new Mouse();



        public int stage = 0;
        public int level = 0;
        public int state = 0; // stage_level 실행 여부

        public Point   mousePoint     = new Point();
        public Point[] initmousePoint = // 마우스 초기 위치
        {

        };

        public Color   mouseColor            = new Color();
        public Color[] game_SuccessAreaColor = // 클리어 판정 색상
        {
            Color.FromArgb(255, 242, 0)
        };
        public Color[] game_OverAreaColor    = // 게임오버 판정 색상
        {
            Color.FromArgb(237, 28, 36),
            Color.FromArgb(255, 241, 0),
            Color.FromArgb(255, 240, 0)
        };

        // 프로젝트 파일 경로 (select_level, stage_level 에서 배경 이미지 불러올 때 사용)
        public string fp_Project = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName;



        private void InitializeUserControl(UserControl uc, Point p, Size s, Color c, Boolean b)
        {
            uc.Location  = p;
            uc.Size      = s;
            uc.BackColor = c;
            uc.Visible   = b;
        }
        


        public void UserControlVisible(UserControl uc1, UserControl uc2)
        {
            uc1.Visible = true;
            uc2.Visible = false;

            state = ((uc1 == stage_level1) ? 1 : 0);
        }



        public void InitializeMousePosition() // Mouse.cs에 옮길 예정
        {
            int x = this.Location.X;
            int y = this.Location.Y;

            if      (stage_level1.temp != 1 && stage == 1 && level == 1) Cursor.Position = new Point(x + 100, y + 300);
            else if (stage_level1.temp != 1 && stage == 1 && level == 2) Cursor.Position = new Point(x + 100, y + 300);
            else if (stage_level1.temp != 1 && stage == 1 && level == 3) Cursor.Position = new Point(x + 100, y + 300);
            else if (stage_level1.temp != 1 && stage == 1 && level == 4) Cursor.Position = new Point(x + 100, y + 300);
            else if (stage_level1.temp != 1 && stage == 1 && level == 5) Cursor.Position = new Point(x + 50,  y + 50);
            else if (stage_level1.temp != 1 && stage == 1 && level == 6) Cursor.Position = new Point(x + 100, y + 300);
            else if (stage_level1.temp != 1 && stage == 2 && level == 1) Cursor.Position = new Point(x + 50,  y + 330);
            else if (stage_level1.temp != 1 && stage == 2 && level == 2) Cursor.Position = new Point(x + 30,  y + 500);
            else if (stage_level1.temp != 1 && stage == 2 && level == 3) Cursor.Position = new Point(x + 400, y + 300);
            else if (stage_level1.temp != 1 && stage == 2 && level == 4) Cursor.Position = new Point(x + 100, y + 500);
            else if (stage_level1.temp != 1 && stage == 2 && level == 5) Cursor.Position = new Point(x + 30,  y + 500);
            else if (stage_level1.temp != 1 && stage == 2 && level == 6) Cursor.Position = new Point(x + 350, y + 100);
            else if (stage_level1.temp != 1 && stage == 3 && level == 1) Cursor.Position = new Point(x + 230, y + 300);
            else if (stage_level1.temp != 1 && stage == 3 && level == 2) Cursor.Position = new Point(x + 120, y + 120);
            else if (stage_level1.temp != 1 && stage == 3 && level == 3) Cursor.Position = new Point(x + 400, y + 300);
            else if (stage_level1.temp != 1 && stage == 3 && level == 4) Cursor.Position = new Point(x + 100, y + 100);
            else if (stage_level1.temp != 1 && stage == 3 && level == 5) Cursor.Position = new Point(x + 100, y + 100);
            else if (stage_level1.temp != 1 && stage == 3 && level == 6) Cursor.Position = new Point(x + 30,  y + 50);
            else { stage_level1.temp = 0; }
        }


        int time = 0;
        private void Tick(object sender, EventArgs e)
        {
            // 마우스 활동영역 설정
            mouse.SetMouseActivityArea(this, state);

            // stage_level이 실행중일 때
            if (state == 1)
            {
                mouseColor = mouse.GetPointColor(Cursor.Position);

                // game_success, game_over 판정
                if (mouseColor == game_SuccessAreaColor[0])
                {
                    UserControlVisible(game_success1, stage_level1);
                }
                if (mouseColor == game_OverAreaColor[0] ||
                    mouseColor == game_OverAreaColor[1] ||
                    mouseColor == game_OverAreaColor[2])
                {
                    UserControlVisible(game_over1, stage_level1);
                }
            }

            //3-2 스테이지
            if (Form1.form1.stage == 2 && Form1.form1.level == 3)
            {
                int k = (ClientSize.Width - Form1.form1.stage_level1.button3.Size.Width) / 2;
                Form1.form1.stage_level1.label1.Visible = true;
                Form1.form1.stage_level1.label2.Visible = true;
                Form1.form1.stage_level1.button1.Visible = true;
                Form1.form1.stage_level1.button2.Visible = true;
                Form1.form1.stage_level1.button3.Visible = true;
                Form1.form1.stage_level1.button4.Visible = true;
                Form1.form1.stage_level1.button5.Visible = true;
                Form1.form1.stage_level1.button1.Location = new Point(k - 300, 400);
                Form1.form1.stage_level1.button2.Location = new Point(k - 150, 400);
                Form1.form1.stage_level1.button3.Location = new Point(k , 400);
                Form1.form1.stage_level1.button4.Location = new Point(k + 150, 400);
                Form1.form1.stage_level1.button5.Location = new Point(k + 300, 400);
                Form1.form1.stage_level1.label1.Location = new Point((ClientSize.Width - Form1.form1.stage_level1.label1.Size.Width)/2, 100);
                Form1.form1.stage_level1.label2.Location = new Point((ClientSize.Width - Form1.form1.stage_level1.label2.Size.Width)/2, 250);
                Form1.form1.stage_level1.label1.Text = "문제\n\n대기업 그룹의 사장이 죽기 직전, 벽에 유언을 남겼다. 과연 범인은 누구일까?";
                Form1.form1.stage_level1.label2.Text = "유언 : ㄸ뚜ㅁ뜨뜨";
            }
            else
            {
                Form1.form1.stage_level1.label1.Visible = false;
                Form1.form1.stage_level1.label2.Visible = false;
                Form1.form1.stage_level1.button1.Visible = false;
                Form1.form1.stage_level1.button2.Visible = false;
                Form1.form1.stage_level1.button3.Visible = false;
                Form1.form1.stage_level1.button4.Visible = false;
                Form1.form1.stage_level1.button5.Visible = false;
            }// 3-2 스테이지

            time++;
            Random rand = new Random();//3-3 스테이지
            if (Form1.form1.stage == 3 && Form1.form1.level == 3)
            {
                int x = rand.Next(800 - Form1.form1.stage_level1.pictureBox1.Size.Width);
                int y = rand.Next(600 - Form1.form1.stage_level1.pictureBox1.Size.Height);
                int temp = rand.Next(8);
                Form1.form1.stage_level1.pictureBox1.Size = new Size(100, 100);
                Form1.form1.stage_level1.pictureBox1.Visible = true;

                if (temp == 1 && time % 50 == 1)
                {
                    Form1.form1.stage_level1.pictureBox1.Location = new Point(x, y);
                    Form1.form1.stage_level1.pictureBox1.BackColor = Color.FromArgb(255, 242, 0);
                }
                else if (time % 50 == 1)
                {
                    Form1.form1.stage_level1.pictureBox1.Location = new Point(x, y);
                    Form1.form1.stage_level1.pictureBox1.BackColor = Color.FromArgb(237, 28, 36);
                }
            }
            else
            {
                Form1.form1.stage_level1.pictureBox1.Visible = false;
            }
            if (time == 50) time = 0;//3-3 스테이지

            label1.Text = "color: " + mouseColor.ToString();
            label2.Text = "stage: " + stage.ToString();
            label3.Text = "level: " + level.ToString();
            label4.Text = "state: " + state.ToString();
        }
    }
}

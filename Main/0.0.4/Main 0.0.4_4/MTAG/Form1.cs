﻿using System;
using System.Drawing;
using System.IO;
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

            int offset = 25;
            Point point = new Point(0, 0);
            Size clientSize = new Size(ClientSize.Width, ClientSize.Height - offset);
            Color backColor = Color.White;
            Boolean visible = false;

            for (int i = 0; i < userControl.Length; i++)
            {
                InitializeUserControl(userControl[i], point, clientSize, backColor, visible);
            }



            main1.Visible = true;
        }



        Mouse        mouse        = new Mouse();
        Stage_Levels stage_levels = new Stage_Levels();



        public int stage = 0;
        public int level = 0;
        public int state = 0;

        private int time    = 0;
        private int queez   = 0;
        private int randBox = 0;

        public Point    mousePoint     = new Point();
        public Point[,] initMousePoint =
        {
            // 스테이지 1
            { new Point(100, 300),
              new Point(100, 300),
              new Point(100, 300),
              new Point(100, 300),
              new Point(50, 50),
              new Point(100, 300) },
            // 스테이지 2
            { new Point(50, 330),
              new Point(30, 500),
              new Point(400, 300),
              new Point(100, 500),
              new Point(30, 500),
              new Point(350, 100) },
            // 스테이지 3
            { new Point(230, 300),
              new Point(120, 120),
              new Point(400, 300),
              new Point(100, 100),
              new Point(100, 100),
              new Point(30, 50) }
        };

        public Color   mouseColor            = new Color();
        public Color[] game_SuccessAreaColor =
        {
            Color.FromArgb(255, 242, 0)
        };
        public Color[] game_OverAreaColor =
        {
            Color.FromArgb(237, 28, 36),
            Color.FromArgb(255, 241, 0),
            Color.FromArgb(255, 240, 0)
        };

        public string fp_Project = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName;



        private void InitializeUserControl(UserControl uc, Point p, Size s, Color c, Boolean b)
        {
            uc.Location  = p;
            uc.Size      = s;
            uc.BackColor = c;
            uc.Visible   = b;
        }
        public void InitializeMousePosition()
        {
            Point offset = initMousePoint[stage - 1, level - 1];
            Point init   = new Point(
                this.Location.X + offset.X,
                this.Location.Y + offset.Y);

            mouse.SetMousePosition(init);
        }



        public void UserControlVisible(UserControl uc1, UserControl uc2)
        {
            uc1.Visible = true;
            uc2.Visible = false;

            state = ((uc1 == stage_level1) ? 1 : 0);
        }



        // AltTab, Window 키 이벤트
        // Form1이 비활성화 되면 일시정지 화면으로 전환
        private void Form1_Deactivate(object sender, EventArgs e)
        {
            if (stage_level1.Focus())
            {
                state             = 0;
                mousePoint        = Cursor.Position;
                stage_level1.temp = 1;

                UserControlVisible(game_pause1, stage_level1);
            }
        }


        private void Tick(object sender, EventArgs e)
        {
            // 마우스 활동영역 설정
            mouse.SetMouseActivityArea(this, state);


            // stage_level이 실행중일 때
            if (state == 1)
            {
                mouseColor = mouse.GetPointColor(Cursor.Position);

                // game_success, game_over 판정
                if (mouseColor == game_SuccessAreaColor[0]) { UserControlVisible(game_success1, stage_level1); }
                if (mouseColor == game_OverAreaColor[0] ||
                    mouseColor == game_OverAreaColor[1] ||
                    mouseColor == game_OverAreaColor[2])
                { UserControlVisible(game_over1, stage_level1); }
            }

            //1-2 스테이지 장애물
            if (stage == 1 && level == 2)
            {
                Form1.form1.stage_level1.pictureBox1.Visible = true;
                Form1.form1.stage_level1.pictureBox1.BackColor = Color.FromArgb(237, 28, 36);
                Form1.form1.stage_level1.pictureBox1.Size = new Size(100,400);
                Form1.form1.stage_level1.pictureBox1.Location = new Point(300,100);
            }
            else
            {
                Form1.form1.stage_level1.pictureBox1.Visible = false;
                Form1.form1.stage_level1.pictureBox1.BackColor = Color.White;
            }




            // 퀴즈 스테이지 레벨
            queez = ((stage == 2 && level == 3) ? 1 : 0);
            stage_levels.StageLevels_Queez(queez);


            // 랜덤박스 스테이지 레벨
            time   += 1;
            randBox = ((stage == 3 && level == 3) ? 1 : 0);
            time    = stage_levels.StageLevels_RandomBox(randBox, time);


            // 각 스테이지 레벨 오브젝트
            stage_levels.StageLevels_Objects(stage, level);


            // 디버그
            label1.Text = "color: " + mouseColor.ToString();
            label2.Text = "stage: " + stage.ToString();
            label3.Text = "level: " + level.ToString();
            label4.Text = "state: " + state.ToString();
        }
    }
}

using System;
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

            int     offset     = 0;
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



        Mouse        mouse        = new Mouse();
        Stage_Levels stage_levels = new Stage_Levels();


        public int stage_temp = 0;
        public int level_temp = 0;
        public int level_temp2 = 0;
        public int level_temp3 = 0;
        public int     stage   = 0;
        public int     level   = 0;
        public int     state   = 0;
        public int     time    = 0;
        private int    queez   = 0;
        private int    randBox = 0;
        public int[,,] pictureBox_Visible =
        {
            // 1  ~ 9  = white
            // 10 ~ 14 = red

            // 스테이지 1
            {
                //1  2  3  4  5  6  7  8  9  10 11 12 13 14 15 16 17 18
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, // 1-1
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0 }, // 1-2
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0 }, // 1-3
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 }, // 1-4
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 0, 0, 0, 0, 0, 0 }, // 1-5
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0 }  // 1-6
            },
            // 스테이지 2
            {
                //1  2  3  4  5  6  7  8  9  10 11 12 13 14 15 16 17 18
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0 }, // 2-1
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 0, 0, 0, 0, 0, 0 }, // 2-2
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, // 2-3
                { 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, // 2-4
                { 1, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 0, 0, 0, 0, 0, 0 }, // 2-5
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 0 }, // 2-6
            },
            // 스테이지 3
            {
                //1  2  3  4  5  6  7  8  9  10 11 12 13 14 15 16 17 18
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, // 3-1
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, // 3-2
                { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, // 3-3
                { 1, 1, 0, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, // 3-4
                { 1, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, // 3-5
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }  // 3-6
            }
        };

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
              new Point(400, 10),
              new Point(400, 300),
              new Point(700, 500),
              new Point(100, 500),
              new Point(50, 520) }
        };

        public Color   mouseColor            = new Color();
        public Color[] game_SuccessAreaColor =
        {
            Color.FromArgb(255, 242, 0),
            Color.FromArgb(254, 242, 0)
        };
        public Color[] game_OverAreaColor =
        {
            //Color.FromArgb(255, 255, 255),
            Color.FromArgb(237, 28, 36),
            Color.FromArgb(237, 27, 36),
            Color.FromArgb(0, 0, 0)
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
        public void InitializePictureBox_Visible(int[,,] b, int s, int l)
        {
            PictureBox[] p =
            {
                Form1.form1.stage_level1.pictureBox1,
                Form1.form1.stage_level1.pictureBox2,
                Form1.form1.stage_level1.pictureBox3,
                Form1.form1.stage_level1.pictureBox4,
                Form1.form1.stage_level1.pictureBox5,
                Form1.form1.stage_level1.pictureBox6,
                Form1.form1.stage_level1.pictureBox7,
                Form1.form1.stage_level1.pictureBox8,
                Form1.form1.stage_level1.pictureBox9,
                Form1.form1.stage_level1.pictureBox10,
                Form1.form1.stage_level1.pictureBox11,
                Form1.form1.stage_level1.pictureBox12,
                Form1.form1.stage_level1.pictureBox13,
                Form1.form1.stage_level1.pictureBox14,
                Form1.form1.stage_level1.pictureBox15,
                Form1.form1.stage_level1.pictureBox16,
                Form1.form1.stage_level1.pictureBox17,
                Form1.form1.stage_level1.pictureBox18
            };

            if (s != 0 && l != 0)
            {
                for (int i = 0; i < p.Length; i++)
                {
                    p[i].Visible = ((b[s - 1, l - 1, i] == 1) ? true : false);
                }
            }
        }

        public void UserControlVisible(UserControl uc1, UserControl uc2)
        {
            uc1.Visible = true;
            uc2.Visible = false;

            state = ((uc1 == stage_level1) ? 1 : 0);
        }

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

        public void buttonEnabled()//버튼 활성화 stage_temp가 증가하면 다음 stage 버튼 활성화, level_temp(1stage), level_temp2(2stage), level_temp3(3stage)가 증가하면 다음 스테이지 버튼 활성화
        {
            if (stage == 1 && Form1.form1.level_temp == 0)
            {
                Form1.form1.select_level1.button2.Enabled = false;
                Form1.form1.select_level1.button3.Enabled = false;
                Form1.form1.select_level1.button4.Enabled = false;
                Form1.form1.select_level1.button5.Enabled = false;
                Form1.form1.select_level1.button6.Enabled = false;
            }
            else if (stage == 1 && Form1.form1.level_temp == 1)
            {
                Form1.form1.select_level1.button2.Enabled = true;
                Form1.form1.select_level1.button3.Enabled = false;
                Form1.form1.select_level1.button4.Enabled = false;
                Form1.form1.select_level1.button5.Enabled = false;
                Form1.form1.select_level1.button6.Enabled = false;
            }
            else if (stage == 1 && Form1.form1.level_temp == 2)
            {
                Form1.form1.select_level1.button2.Enabled = true;
                Form1.form1.select_level1.button3.Enabled = true;
                Form1.form1.select_level1.button4.Enabled = false;
                Form1.form1.select_level1.button5.Enabled = false;
                Form1.form1.select_level1.button6.Enabled = false;
            }
            else if (stage == 1 && Form1.form1.level_temp == 3)
            {
                Form1.form1.select_level1.button2.Enabled = true;
                Form1.form1.select_level1.button3.Enabled = true;
                Form1.form1.select_level1.button4.Enabled = true;
                Form1.form1.select_level1.button5.Enabled = false;
                Form1.form1.select_level1.button6.Enabled = false;
            }
            else if (stage == 1 && Form1.form1.level_temp == 4)
            {
                Form1.form1.select_level1.button2.Enabled = true;
                Form1.form1.select_level1.button3.Enabled = true;
                Form1.form1.select_level1.button4.Enabled = true;
                Form1.form1.select_level1.button5.Enabled = true;
                Form1.form1.select_level1.button6.Enabled = false;
            }
            else if (stage == 1 && Form1.form1.level_temp == 5)
            {
                Form1.form1.select_level1.button2.Enabled = true;
                Form1.form1.select_level1.button3.Enabled = true;
                Form1.form1.select_level1.button4.Enabled = true;
                Form1.form1.select_level1.button5.Enabled = true;
                Form1.form1.select_level1.button6.Enabled = true;
                Form1.form1.select_stage1.button2.Enabled = true;
            }
            else if (stage == 2 && Form1.form1.level_temp2 == 0)
            {
                Form1.form1.select_level1.button2.Enabled = false;
                Form1.form1.select_level1.button3.Enabled = false;
                Form1.form1.select_level1.button4.Enabled = false;
                Form1.form1.select_level1.button5.Enabled = false;
                Form1.form1.select_level1.button6.Enabled = false;
            }
            else if (stage == 2 && Form1.form1.level_temp2 == 1)
            {
                Form1.form1.select_level1.button2.Enabled = true;
                Form1.form1.select_level1.button3.Enabled = false;
                Form1.form1.select_level1.button4.Enabled = false;
                Form1.form1.select_level1.button5.Enabled = false;
                Form1.form1.select_level1.button6.Enabled = false;
            }
            else if (stage == 2 && Form1.form1.level_temp2 == 2)
            {
                Form1.form1.select_level1.button2.Enabled = true;
                Form1.form1.select_level1.button3.Enabled = true;
                Form1.form1.select_level1.button4.Enabled = false;
                Form1.form1.select_level1.button5.Enabled = false;
                Form1.form1.select_level1.button6.Enabled = false;
            }
            else if (stage == 2 && Form1.form1.level_temp2 == 3)
            {
                Form1.form1.select_level1.button2.Enabled = true;
                Form1.form1.select_level1.button3.Enabled = true;
                Form1.form1.select_level1.button4.Enabled = true;
                Form1.form1.select_level1.button5.Enabled = false;
                Form1.form1.select_level1.button6.Enabled = false;
            }
            else if (stage == 2 && Form1.form1.level_temp2 == 4)
            {
                Form1.form1.select_level1.button2.Enabled = true;
                Form1.form1.select_level1.button3.Enabled = true;
                Form1.form1.select_level1.button4.Enabled = true;
                Form1.form1.select_level1.button5.Enabled = true;
                Form1.form1.select_level1.button6.Enabled = false;
            }
            else if (stage == 2 && Form1.form1.level_temp2 == 5)
            {
                Form1.form1.select_level1.button2.Enabled = true;
                Form1.form1.select_level1.button3.Enabled = true;
                Form1.form1.select_level1.button4.Enabled = true;
                Form1.form1.select_level1.button5.Enabled = true;
                Form1.form1.select_level1.button6.Enabled = true;
                Form1.form1.select_stage1.button3.Enabled = true;
            }
            else if (stage == 3 && Form1.form1.level_temp3 == 0)
            {
                Form1.form1.select_level1.button2.Enabled = false;
                Form1.form1.select_level1.button3.Enabled = false;
                Form1.form1.select_level1.button4.Enabled = false;
                Form1.form1.select_level1.button5.Enabled = false;
                Form1.form1.select_level1.button6.Enabled = false;
            }
            else if (stage == 3 && Form1.form1.level_temp3 == 1)
            {
                Form1.form1.select_level1.button2.Enabled = true;
                Form1.form1.select_level1.button3.Enabled = false;
                Form1.form1.select_level1.button4.Enabled = false;
                Form1.form1.select_level1.button5.Enabled = false;
                Form1.form1.select_level1.button6.Enabled = false;
            }
            else if (stage == 3 && Form1.form1.level_temp3 == 2)
            {
                Form1.form1.select_level1.button2.Enabled = true;
                Form1.form1.select_level1.button3.Enabled = true;
                Form1.form1.select_level1.button4.Enabled = false;
                Form1.form1.select_level1.button5.Enabled = false;
                Form1.form1.select_level1.button6.Enabled = false;
            }
            else if (stage == 3 && Form1.form1.level_temp3 == 3)
            {
                Form1.form1.select_level1.button2.Enabled = true;
                Form1.form1.select_level1.button3.Enabled = true;
                Form1.form1.select_level1.button4.Enabled = true;
                Form1.form1.select_level1.button5.Enabled = false;
                Form1.form1.select_level1.button6.Enabled = false;
            }
            else if (stage == 3 && Form1.form1.level_temp3 == 4)
            {
                Form1.form1.select_level1.button2.Enabled = true;
                Form1.form1.select_level1.button3.Enabled = true;
                Form1.form1.select_level1.button4.Enabled = true;
                Form1.form1.select_level1.button5.Enabled = true;
                Form1.form1.select_level1.button6.Enabled = false;
            }
            else if (stage == 3 && Form1.form1.level_temp3 == 5)
            {
                Form1.form1.select_level1.button2.Enabled = true;
                Form1.form1.select_level1.button3.Enabled = true;
                Form1.form1.select_level1.button4.Enabled = true;
                Form1.form1.select_level1.button5.Enabled = true;
                Form1.form1.select_level1.button6.Enabled = true;
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
                if (mouseColor == game_SuccessAreaColor[0] || mouseColor == game_SuccessAreaColor[1]) { 
                    UserControlVisible(game_success1, stage_level1);
                    if (stage == 1 && level == 1 && level_temp == 0) { level_temp++; buttonEnabled(); }
                    else if (stage == 1 && level == 2 && level_temp == 1) { level_temp++; buttonEnabled(); }
                    else if (stage == 1 && level == 3 && level_temp == 2) { level_temp++; buttonEnabled(); }
                    else if (stage == 1 && level == 4 && level_temp == 3) { level_temp++; buttonEnabled(); }
                    else if (stage == 1 && level == 5 && level_temp == 4) { level_temp++; buttonEnabled(); }
                    else if (stage == 1 && level == 6 && level_temp == 5) { stage_temp++; buttonEnabled(); }
                    else if (stage == 2 && level == 1 && level_temp2 == 0) { level_temp2++; buttonEnabled(); }
                    else if (stage == 2 && level == 2 && level_temp2 == 1) { level_temp2++; buttonEnabled(); }
                    else if (stage == 2 && level == 3 && level_temp2 == 2) { level_temp2++; buttonEnabled(); }
                    else if (stage == 2 && level == 4 && level_temp2 == 3) { level_temp2++; buttonEnabled(); }
                    else if (stage == 2 && level == 5 && level_temp2 == 4) { level_temp2++; buttonEnabled(); }
                    else if (stage == 2 && level == 6 && level_temp2 == 5) { stage_temp++; buttonEnabled(); }
                    else if (stage == 3 && level == 1 && level_temp3 == 0) { level_temp3++; buttonEnabled(); }
                    else if (stage == 3 && level == 2 && level_temp3 == 1) { level_temp3++; buttonEnabled(); }
                    else if (stage == 3 && level == 3 && level_temp3 == 2) { level_temp3++; buttonEnabled(); }
                    else if (stage == 3 && level == 4 && level_temp3 == 3) { level_temp3++; buttonEnabled(); }
                    else if (stage == 3 && level == 5 && level_temp3 == 4) { level_temp3++; buttonEnabled(); }
                    else if (stage == 3 && level == 6 && level_temp3 == 5) { buttonEnabled(); }
                }
                if (mouseColor == game_OverAreaColor[0] || mouseColor == game_OverAreaColor[1])
                { UserControlVisible(game_over1, stage_level1); }
            }
            else{buttonEnabled();}


            // 랜덤박스 스테이지 레벨
            time   += 1;
            randBox = ((stage == 3 && level == 3) ? 1 : 0);
            time    = stage_levels.StageLevels_RandomBox(randBox, time);


            // 각 스테이지 레벨 오브젝트
            stage_levels.StageLevels_Objects(stage, level);

            // 퀴즈 스테이지 레벨
            queez = ((stage == 2 && level == 3) ? 1 : 0);
            stage_levels.StageLevels_Queez(queez);


            // 디버그
            //label1.Text = "color: " + mouseColor.ToString();
            //label2.Text = "stage: " + stage.ToString();
            //label3.Text = "level: " + level.ToString();
            //label4.Text = "state: " + state.ToString();
            //label5.Text = "stage_temp" + stage_temp.ToString();
            //label6.Text = "level_temp" + level_temp.ToString() + "," + level_temp2.ToString() + "," + level_temp3.ToString();
        }
    }
}

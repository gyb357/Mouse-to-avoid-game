using System;
using System.Drawing;
using System.Windows.Forms;



namespace UserControl0
{
    public partial class MTAG : Form
    {
        public static MTAG form1;
        public MTAG()
        {
            InitializeComponent();


            form1 = this;

            form1.StartPosition = FormStartPosition.Manual;
            form1.Location = new Point((1920 - 800)/2,(1080 - 600)/2);

            // 유저 컨트롤 배열
            UserControl[] userControl = new UserControl[]
            {
                main1,         how_to_play1,
                select_stage1, select_level1, stage_level1,
                game_success1, game_over1,    game_pause1
            };


            // 유저 컨트롤 매개변수
            Point point = new Point(0, 0);
            Size clientSize = new Size(ClientSize.Width, ClientSize.Height - 25);
            Boolean visible = false;


            // 유저 컨트롤 초기화
            for (int i = 0; i < userControl.Length; i++)
            {
                InitializeUserControl(userControl[i], point, clientSize, visible);
            }


            // 첫 화면으로 main1.cs (메인 화면) 출력
            main1.Visible = true;
        }

        // 클래스 객체
        MouseEvent mouseEvent = new MouseEvent();



        // 요소
        public int stage_temp = 0;
        public int level_temp = 0;
        public int level_temp2 = 0;
        public int level_temp3 = 0;
        public int stage = 0; // 현재 스테이지
        public int level = 0; // 현재 레벨
        /*
         * 각 스테이지와 레벨을 차별화 할 수 있는 요소
         * -> 한개의 유저 컨트롤로 모두 다른 스테이지와 레벨 표현이 가능
         * 
         * 
         * ex)
         *     1. 스테이지 레벨마다 사용할 이미지를 참조에 삽입
         * 
         *     2. stage, level 값에 따라
         *        해당 스테이지와 레벨에 맞는 이미지를 출력
         */
        public int state = 0;           // 현재 게임 상태 (현재 화면이 stage_level1.cs (게임 화면) 일 때 1 : 0)
        public int stageCount = 3;           // 스테이지 개수
        public int levelCount = 6;           // 레벨 개수
        public Point mousePoint = new Point(); // 마우스 위치
        public Color mouseColor = new Color(); // 마우스 위치 색상
        // UserControl 초기화
        private void InitializeUserControl(UserControl uc, Point p, Size s, Boolean b)
        {
            uc.Location = p;
            uc.Size = s;
            uc.Visible = false;
        }

        int cx = (1920 - 800) / 2;
        int cy = (1080 - 600) / 2;
        // UserControl 이동
        public void UserControlVisible(UserControl uc1, UserControl uc2)
        {
            uc1.Visible = true;
            uc2.Visible = false;
        }
        
        public void cursorPosition()
        {
            if (MTAG.form1.stage_level1.temp != 1 && stage == 1 && level == 1) Cursor.Position = new Point(cx + 100, cy + 300);
            else if (MTAG.form1.stage_level1.temp != 1 && stage == 1 && level == 2) Cursor.Position = new Point(cx + 100, cy + 300);
            else if (MTAG.form1.stage_level1.temp != 1 && stage == 1 && level == 3) Cursor.Position = new Point(cx + 100, cy + 300);
            else if (MTAG.form1.stage_level1.temp != 1 && stage == 1 && level == 4) Cursor.Position = new Point(cx + 100, cy + 300);
            else if (MTAG.form1.stage_level1.temp != 1 && stage == 1 && level == 5) Cursor.Position = new Point(cx + 50, cy + 50);
            else if (MTAG.form1.stage_level1.temp != 1 && stage == 1 && level == 6) Cursor.Position = new Point(cx + 100, cy + 300);
            else if (MTAG.form1.stage_level1.temp != 1 && stage == 2 && level == 1) Cursor.Position = new Point(cx + 50, cy + 330);
            else if (MTAG.form1.stage_level1.temp != 1 && stage == 2 && level == 2) Cursor.Position = new Point(cx + 30, cy + 500);
            else if (MTAG.form1.stage_level1.temp != 1 && stage == 2 && level == 3) Cursor.Position = new Point(cx + 400, cy + 300);
            else if (MTAG.form1.stage_level1.temp != 1 && stage == 2 && level == 4) Cursor.Position = new Point(cx + 100, cy + 500);
            else if (MTAG.form1.stage_level1.temp != 1 && stage == 2 && level == 5) Cursor.Position = new Point(cx + 30, cy + 500);
            else if (MTAG.form1.stage_level1.temp != 1 && stage == 2 && level == 6) Cursor.Position = new Point(cx + 350, cy + 100);
            else if (MTAG.form1.stage_level1.temp != 1 && stage == 3 && level == 1) Cursor.Position = new Point(cx + 230, cy + 300);
            else if (MTAG.form1.stage_level1.temp != 1 && stage == 3 && level == 2) Cursor.Position = new Point(cx + 120, cy + 120);
            else if (MTAG.form1.stage_level1.temp != 1 && stage == 3 && level == 3) Cursor.Position = new Point(cx + 400, cy + 300);
            else if (MTAG.form1.stage_level1.temp != 1 && stage == 3 && level == 4) Cursor.Position = new Point(cx + 100, cy + 100);
            else if (MTAG.form1.stage_level1.temp != 1 && stage == 3 && level == 5) Cursor.Position = new Point(cx + 100, cy + 100);
            else if (MTAG.form1.stage_level1.temp != 1 && stage == 3 && level == 6) Cursor.Position = new Point(cx + 30, cy + 50);
            else { MTAG.form1.stage_level1.temp = 0; }
        }//스테이지 시작 위치 설정

        public void buttonEnabled()//버튼 활성화 stage_temp가 증가하면 다음 stage 버튼 활성화, level_temp(1stage), level_temp2(2stage), level_temp3(3stage)가 증가하면 다음 스테이지 버튼 활성화
        {
            if (stage == 1 && MTAG.form1.level_temp == 0)
            {
                MTAG.form1.select_level1.button2.Enabled = false;
                MTAG.form1.select_level1.button3.Enabled = false;
                MTAG.form1.select_level1.button4.Enabled = false;
                MTAG.form1.select_level1.button5.Enabled = false;
                MTAG.form1.select_level1.button6.Enabled = false;
            }
            else if (stage == 1 && MTAG.form1.level_temp == 1)
            {
                MTAG.form1.select_level1.button2.Enabled = true;
                MTAG.form1.select_level1.button3.Enabled = false;
                MTAG.form1.select_level1.button4.Enabled = false;
                MTAG.form1.select_level1.button5.Enabled = false;
                MTAG.form1.select_level1.button6.Enabled = false;
            }
            else if (stage == 1 && MTAG.form1.level_temp == 2)
            {
                MTAG.form1.select_level1.button2.Enabled = true;
                MTAG.form1.select_level1.button3.Enabled = true;
                MTAG.form1.select_level1.button4.Enabled = false;
                MTAG.form1.select_level1.button5.Enabled = false;
                MTAG.form1.select_level1.button6.Enabled = false;
            }
            else if (stage == 1 && MTAG.form1.level_temp == 3)
            {
                MTAG.form1.select_level1.button2.Enabled = true;
                MTAG.form1.select_level1.button3.Enabled = true;
                MTAG.form1.select_level1.button4.Enabled = true;
                MTAG.form1.select_level1.button5.Enabled = false;
                MTAG.form1.select_level1.button6.Enabled = false;
            }
            else if (stage == 1 && MTAG.form1.level_temp == 4)
            {
                MTAG.form1.select_level1.button2.Enabled = true;
                MTAG.form1.select_level1.button3.Enabled = true;
                MTAG.form1.select_level1.button4.Enabled = true;
                MTAG.form1.select_level1.button5.Enabled = true;
                MTAG.form1.select_level1.button6.Enabled = false;
            }
            else if (stage == 1 && MTAG.form1.level_temp == 5)
            {
                MTAG.form1.select_level1.button2.Enabled = true;
                MTAG.form1.select_level1.button3.Enabled = true;
                MTAG.form1.select_level1.button4.Enabled = true;
                MTAG.form1.select_level1.button5.Enabled = true;
                MTAG.form1.select_level1.button6.Enabled = true;
                MTAG.form1.select_stage1.button2.Enabled = true;
            }
            else if (stage == 2 && MTAG.form1.level_temp2 == 0)
            {
                MTAG.form1.select_level1.button2.Enabled = false;
                MTAG.form1.select_level1.button3.Enabled = false;
                MTAG.form1.select_level1.button4.Enabled = false;
                MTAG.form1.select_level1.button5.Enabled = false;
                MTAG.form1.select_level1.button6.Enabled = false;
            }
            else if (stage == 2 && MTAG.form1.level_temp2 == 1)
            {
                MTAG.form1.select_level1.button2.Enabled = true;
                MTAG.form1.select_level1.button3.Enabled = false;
                MTAG.form1.select_level1.button4.Enabled = false;
                MTAG.form1.select_level1.button5.Enabled = false;
                MTAG.form1.select_level1.button6.Enabled = false;
            }
            else if (stage == 2 && MTAG.form1.level_temp2 == 2)
            {
                MTAG.form1.select_level1.button2.Enabled = true;
                MTAG.form1.select_level1.button3.Enabled = true;
                MTAG.form1.select_level1.button4.Enabled = false;
                MTAG.form1.select_level1.button5.Enabled = false;
                MTAG.form1.select_level1.button6.Enabled = false;
            }
            else if (stage == 2 && MTAG.form1.level_temp2 == 3)
            {
                MTAG.form1.select_level1.button2.Enabled = true;
                MTAG.form1.select_level1.button3.Enabled = true;
                MTAG.form1.select_level1.button4.Enabled = true;
                MTAG.form1.select_level1.button5.Enabled = false;
                MTAG.form1.select_level1.button6.Enabled = false;
            }
            else if (stage == 2 && MTAG.form1.level_temp2 == 4)
            {
                MTAG.form1.select_level1.button2.Enabled = true;
                MTAG.form1.select_level1.button3.Enabled = true;
                MTAG.form1.select_level1.button4.Enabled = true;
                MTAG.form1.select_level1.button5.Enabled = true;
                MTAG.form1.select_level1.button6.Enabled = false;
            }
            else if (stage == 2 && MTAG.form1.level_temp2 == 5)
            {
                MTAG.form1.select_level1.button2.Enabled = true;
                MTAG.form1.select_level1.button3.Enabled = true;
                MTAG.form1.select_level1.button4.Enabled = true;
                MTAG.form1.select_level1.button5.Enabled = true;
                MTAG.form1.select_level1.button6.Enabled = true;
                MTAG.form1.select_stage1.button3.Enabled = true;
            }
            else if (stage == 3 && MTAG.form1.level_temp3 == 1)
            {
                MTAG.form1.select_level1.button2.Enabled = true;
                MTAG.form1.select_level1.button3.Enabled = false;
                MTAG.form1.select_level1.button4.Enabled = false;
                MTAG.form1.select_level1.button5.Enabled = false;
                MTAG.form1.select_level1.button6.Enabled = false;
            }
            else if (stage == 3 && MTAG.form1.level_temp3 == 2)
            {
                MTAG.form1.select_level1.button2.Enabled = true;
                MTAG.form1.select_level1.button3.Enabled = true;
                MTAG.form1.select_level1.button4.Enabled = false;
                MTAG.form1.select_level1.button5.Enabled = false;
                MTAG.form1.select_level1.button6.Enabled = false;
            }
            else if (stage == 3 && MTAG.form1.level_temp3 == 3)
            {
                MTAG.form1.select_level1.button2.Enabled = true;
                MTAG.form1.select_level1.button3.Enabled = true;
                MTAG.form1.select_level1.button4.Enabled = true;
                MTAG.form1.select_level1.button5.Enabled = false;
                MTAG.form1.select_level1.button6.Enabled = false;
            }
            else if (stage == 3 && MTAG.form1.level_temp3 == 4)
            {
                MTAG.form1.select_level1.button2.Enabled = true;
                MTAG.form1.select_level1.button3.Enabled = true;
                MTAG.form1.select_level1.button4.Enabled = true;
                MTAG.form1.select_level1.button5.Enabled = true;
                MTAG.form1.select_level1.button6.Enabled = false;
            }
            else if (stage == 3 && MTAG.form1.level_temp3 == 5)
            {
                MTAG.form1.select_level1.button2.Enabled = true;
                MTAG.form1.select_level1.button3.Enabled = true;
                MTAG.form1.select_level1.button4.Enabled = true;
                MTAG.form1.select_level1.button5.Enabled = true;
                MTAG.form1.select_level1.button6.Enabled = true; 
            }
        }

        int time = 0; // timer 지연
        // 타이머
        private void timer1_Tick(object sender, EventArgs e)
        {          
            time++;
            // state 값이 1일 때만 작동시켜 틱당 연산을 줄일 계획
            if (true)
            {
                // 커서 위치의 색상
                mouseColor = mouseEvent.GetCursorColor(Cursor.Position);


                // 노란색일 때
                if (mouseColor == Color.FromArgb(255, 242, 0))
                {
                    // game_success1.cs (클리어 화면) 로 이동
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
                }// 클리어 했을때 level_temp 증가


                // 빨간색일 때
                if (mouseColor == Color.FromArgb(237, 28, 36) 
                    || mouseColor == Color.FromArgb(255, 241, 0)
                    || mouseColor == Color.FromArgb(255, 240, 0))
                {
                    // game_over1.cs (게임 오버 화면) 로 이동
                    UserControlVisible(game_over1, stage_level1);
                }
            }


            // 디버그
            label1.Text = "color: " + mouseColor.ToString();
            label2.Text = "stage: " + stage.ToString();
            label3.Text = "level: " + level.ToString();
            label4.Text = "state: " + state.ToString();

            if (MTAG.form1.stage == 2 && MTAG.form1.level == 3)
            {
                MTAG.form1.stage_level1.label2.Visible = true;
                MTAG.form1.stage_level1.button1.Visible = true;
                MTAG.form1.stage_level1.button2.Visible = true;
                MTAG.form1.stage_level1.button3.Visible = true;
                MTAG.form1.stage_level1.button4.Visible = true;
                MTAG.form1.stage_level1.button5.Visible = true;
                MTAG.form1.stage_level1.label2.Location = new Point(350, 200);
                MTAG.form1.stage_level1.label2.Text = "다음중 배가 고픈것은?";
            }
            else
            {
                MTAG.form1.stage_level1.label2.Visible = false;
                MTAG.form1.stage_level1.button1.Visible = false;
                MTAG.form1.stage_level1.button2.Visible = false;
                MTAG.form1.stage_level1.button3.Visible = false;
                MTAG.form1.stage_level1.button4.Visible = false;
                MTAG.form1.stage_level1.button5.Visible = false;
            }// 3-2 스테이지

            Random rand = new Random();// pictureBox 랜덤으로 위치바꾸고 색바꿔서 깨는 스테이지 3-3
            if (MTAG.form1.stage == 3 && MTAG.form1.level == 3)
            {
                int x = rand.Next(800);
                int y = rand.Next(600);
                int temp = rand.Next(8);
                MTAG.form1.stage_level1.pictureBox2.Visible = true;

                if (temp == 1 && time % 50 == 1)
                {
                    MTAG.form1.stage_level1.pictureBox2.Location = new Point(x - MTAG.form1.stage_level1.pictureBox2.Width, y - MTAG.form1.stage_level1.pictureBox2.Height);
                    MTAG.form1.stage_level1.pictureBox2.BackColor = Color.FromArgb(255, 242, 0);
                }
                else if(time % 50 == 1)
                {
                    MTAG.form1.stage_level1.pictureBox2.Location = new Point(x - MTAG.form1.stage_level1.pictureBox2.Width, y - MTAG.form1.stage_level1.pictureBox2.Height);
                    MTAG.form1.stage_level1.pictureBox2.BackColor = Color.FromArgb(237, 28, 36);
                }
            }
            else
            {
                MTAG.form1.stage_level1.pictureBox2.Visible = false;
            }
            if(time == 50)time = 0;
        }
    }
}

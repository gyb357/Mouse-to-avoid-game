using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MouseEvent0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        // 마우스 관련 함수 정의
        public const UInt32 SPI_SETMOUSESPEED = 0x0071;
        [DllImport("User32.dll")]
        static extern Boolean SystemParametersInfo(
            UInt32 uiAction,
            UInt32 uiParam,
            UInt32 pvParam,
            UInt32 fWinIni);



        // 마우스 속도 조정
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                SystemParametersInfo(SPI_SETMOUSESPEED, 0, 1, 0);
            }
            else
            {
                SystemParametersInfo(SPI_SETMOUSESPEED, 0, 10, 0);
            }
        }
        /*
         * SystemParametersInfo(SPI_SETMOUSESPEED, 0, 속도, 0);
         * 
         * "속도" 매개변수에 정수 값 삽입
         * 
         * 기본속도 = 10
         */
        /*
         * 폼(Form1.cs Area) 위에서 마우스를 움직이면 이상하게 움직임
         * 유저 컨트롤(UserControl1.cs Area) 위에선 땐 잘 움직임
         * "마우스 활동 영역 제한" 함수와 뭔가 충돌이 있어서 그런 것 같음
         * 
         * 프로그램 종료 시 마우스 속도를 다시 원상복구 하는 기능이 있어야 함
         */



        // 마우스 위치 조정
        private void Form1_MouseLeave(object sender, EventArgs e)
        {
            /*
            int x = 100;
            int y = 100;

            Cursor.Position = new Point(x, y);
            */
        }



        // 마우스 활동 영역 제한
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            // 현재 마우스 xy좌표
            int x = Cursor.Position.X;
            int y = Cursor.Position.Y;


            // Handle, Clip, Rectangle 이용
            this.Cursor = new Cursor(Cursor.Current.Handle);
            Cursor.Position = new Point(x, y);
            Cursor.Clip = new Rectangle(this.Location, this.Size);


            // 마우스 위치 출력
            textBox1.Text = x.ToString();
            textBox2.Text = y.ToString();
        }



        // 종료 버튼
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        // 마우스 모양 변경
        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            Cursor.Current = Cursors.Hand;
        }



        // 화면 중앙값
        private void Form1_Load(object sender, EventArgs e)
        {
            // 사용자 화면 중앙 좌표값
            int x = Screen.PrimaryScreen.Bounds.Width / 2 - this.Size.Width / 2;
            int y = Screen.PrimaryScreen.Bounds.Height / 2 - this.Size.Height / 2;


            // 폼, 마우스를 화면 중앙에 위치
            this.Location = new Point(x, y);   // 폼
            Cursor.Position = new Point(x, y); // 마우스
        }
    }
}

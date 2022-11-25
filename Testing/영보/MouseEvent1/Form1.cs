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

namespace MouseEvent1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


            this.AutoScaleMode = AutoScaleMode.Dpi;


            point = Cursor.Position;
            color = GetColor(point);


            label1.Text = color.ToString();
            button1.BackColor = color;


            int r = color.R;
            int g = color.G;
            int b = color.B;

            if (r < 5 && g < 5 && b < 5)
            {
                label2.Text = "black";
            }
            else
            {
                label2.Text = "other";
            }
        }



        // Dll파일(user32.dll, gdi32.dll)을 import 하기 위한 작업
        [DllImport("user32.dll", SetLastError = true)]
        public static extern IntPtr GetDesktopWindow();
        [DllImport("user32.dll", SetLastError = true)]
        public static extern IntPtr GetWindowDC(IntPtr window);
        [DllImport("gdi32.dll", SetLastError = true)]
        public static extern uint GetPixel(IntPtr dc, int x, int y);
        [DllImport("user32.dll", SetLastError = true)]
        public static extern int ReleaseDC(IntPtr window, IntPtr dc);



        // 위치 p의 색상을 얻는 함수
        public Color GetColor(Point p)
        {
            // p의 xy값
            int x = p.X;
            int y = p.Y;


            IntPtr desk = GetDesktopWindow();
            IntPtr dc = GetWindowDC(desk);

            int pxl = (int)GetPixel(dc, x, y);

            ReleaseDC(desk, dc);

            // 정수형 GetPixel()값을 16진수로 변환, 리턴
            return Color.FromArgb(255, (byte)((pxl >> 0) & 0xff), (byte)((pxl >> 8) & 0xff), (byte)(pxl >> 16) & 0xff);
        }



        // 객체 생성
        public Point point = new Point();
        public Color color = new Color();



        // 틱마다 실행
        private void timer1_Tick(object sender, EventArgs e)
        {
           /* point = Cursor.Position;
            point = Cursor.Position;
            color = GetColor(point);


            label1.Text = color.ToString();
            button1.BackColor = color;


            int r = color.R;
            int g = color.G;
            int b = color.B;

            if (r < 5 && g < 5 && b < 5)
            {
                label2.Text = "black";
            }
            else
            {
                label2.Text = "other";
            }*/
        }
    }
}

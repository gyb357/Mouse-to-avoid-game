using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Drawing;
using System.Windows.Forms;



// 마우스, 커서 관련 메소드를 작성하는 클래스
namespace UserControl0
{
    internal class MouseEvent
    {
        public static MouseEvent mouseEvent;
        public MouseEvent()
        {
            mouseEvent = this;
        }



        // 커서 위치 색상 관련 Dll 파일 import
        [DllImport("user32.dll", SetLastError = true)]
        private static extern IntPtr GetDesktopWindow();
        [DllImport("user32.dll", SetLastError = true)]
        private static extern IntPtr GetWindowDC(IntPtr window);
        [DllImport("gdi32.dll", SetLastError = true)]
        private static extern uint GetPixel(IntPtr dc, int x, int y);



        // 마우스 속도 조절 관련 Dll 파일 import
        private const UInt32 SPI_SETMOUSESPEED = 0x0071;
        [DllImport("User32.dll")]
        private static extern Boolean SystemParametersInfo(
            UInt32 uiAction,
            UInt32 uiParam,
            UInt32 pvParam,
            UInt32 fWinIni);



        // 커서 위치 색상
        public Color GetCursorColor(Point p)
        {
            IntPtr desk = GetDesktopWindow();
            IntPtr dc   = GetWindowDC(desk);
            int    pxl  = (int)GetPixel(dc, p.X, p.Y);

            
            // 정수형 색상 값을 16진수 값으로 변환 후 리턴
            return Color.FromArgb(
                255,
                (byte)((pxl >> 0) & 0xff),
                (byte)((pxl >> 8) & 0xff),
                (byte)(pxl >> 16) & 0xff);
        }



        // 커서 모양 변경
        public void SetCursorModel()
        {
            Cursor.Current = Cursors.Hand;
        }



        // 마우스 위치 조정
        public void SetMousePosition(Point p)
        {
            Cursor.Position = p;
        }
        /*
         * 마우스 위치 조정이 필요한 상황들
         * 
         * 1. 레벨 선택 후 마우스가 시작 지점에 있어야 함
         * 
         * 2. 일시 정지 화면에서 back 을 눌러 다시 게임 화면으로 돌아왔을 때
         *    (일시 정지한 순간의 위치를 기억해야 함)
         *    
         * 3. 게임오버, 게임 클리어시 retry 를 눌렀을 때 시작지점에 있어야 함
         */



        // 마우스 속도 조정
        public void SetMouseSpeed(int s)
        {
            SystemParametersInfo(SPI_SETMOUSESPEED, 0, (uint)s, 0);
        }
        /*
         * 1. 아이템을 먹을 시 빨라지거나 느려지도록 속도 조정
         * 
         * 2. 난이도 선택 창을 만들어 난이도에 따라 속도 조정
         * 
         * 3. 난이도 선택 창을 만들지 않을 계획이면
         *    스테이지 레벨이 증가할 수록 플레이 하기 점점 어려워지도록 속도 조정
         */


        
        // 마우스 활동 영역 제한
        /*
        public void Form1_MouseMove()
        {
            this.Cursor = new Cursor(Cursor.Current.Handle);
            Cursor.Position = new Point(x, y);
            Cursor.Clip = new Rectangle(this.Location, this.Size);
        }
        */
    }
}
 
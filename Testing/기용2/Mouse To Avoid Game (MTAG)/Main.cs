using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Mouse_To_Avoid_Game__MTAG_
{
    public partial class Main : Form
    {
        public static Main m;
        public Main()
        {
            InitializeComponent();
            m = this;
            title1.Visible = true;
            title1.BringToFront();
        }

        private void title1_Load(object sender, EventArgs e)
        {
            title1.Location = new Point(0, 0);
            title1.Size = new Size(ClientSize.Width, ClientSize.Height);
        }

        private void how_to_play1_Load(object sender, EventArgs e)
        {
            how_to_play1.Location = new Point(0, 0);
            how_to_play1.Size = new Size(ClientSize.Width, ClientSize.Height);
        }

        private void episodeSel1_Load(object sender, EventArgs e)
        {
            episodeSel1.Location = new Point(0, 0);
            episodeSel1.Size = new Size(ClientSize.Width, ClientSize.Height);
        }

        private void episode1T1_Load(object sender, EventArgs e)
        {
            episode1T1.Location = new Point(0,0);
            episode1T1.Size = new Size(ClientSize.Width, ClientSize.Height);
        }

        private void stage_1_11_Load(object sender, EventArgs e)
        {
            stage_1_11.Location = new Point(0, 0);
            stage_1_11.Size = new Size(ClientSize.Width, ClientSize.Height);
        }

        private void stage_1_21_Load(object sender, EventArgs e)
        {
            stage_1_21.Location = new Point(0, 0);
            stage_1_21.Size = new Size(ClientSize.Width, ClientSize.Height);
        }

        private void stage_1_31_Load(object sender, EventArgs e)
        {
            stage_1_31.Location = new Point(0, 0);
            stage_1_31.Size = new Size(ClientSize.Width, ClientSize.Height);
        }

        private void stage_1_41_Load(object sender, EventArgs e)
        {
            stage_1_41.Location = new Point(0, 0);
            stage_1_41.Size = new Size(ClientSize.Width, ClientSize.Height);
        }

        private void stage_1_51_Load(object sender, EventArgs e)
        {
            stage_1_51.Location = new Point(0, 0);
            stage_1_51.Size = new Size(ClientSize.Width, ClientSize.Height);
        }

        private void stage_1_61_Load(object sender, EventArgs e)
        {
            stage_1_61.Location = new Point(0, 0);
            stage_1_61.Size = new Size(ClientSize.Width, ClientSize.Height);
        }

        private void stage_1_71_Load(object sender, EventArgs e)
        {
            stage_1_71.Location = new Point(0, 0);
            stage_1_71.Size = new Size(ClientSize.Width, ClientSize.Height);
        }

        private void episode21_Load(object sender, EventArgs e)
        {
            episode21.Location = new Point(0, 0);
            episode21.Size = new Size(ClientSize.Width, ClientSize.Height);
        }

        private void stage_2_11_Load(object sender, EventArgs e)
        {
            stage_2_11.Location = new Point(0, 0);
            stage_2_11.Size = new Size(ClientSize.Width, ClientSize.Height);
        }

        private void stage_2_21_Load(object sender, EventArgs e)
        {
            stage_2_21.Location = new Point(0, 0);
            stage_2_21.Size = new Size(ClientSize.Width, ClientSize.Height);
        }

        private void stage_2_31_Load(object sender, EventArgs e)
        {
            stage_2_31.Location = new Point(0, 0);
            stage_2_31.Size = new Size(ClientSize.Width, ClientSize.Height);
        }

        private void stage_2_41_Load(object sender, EventArgs e)
        {
            stage_2_41.Location = new Point(0, 0);
            stage_2_41.Size = new Size(ClientSize.Width, ClientSize.Height);
        }

        private void stage_2_51_Load(object sender, EventArgs e)
        {
            stage_2_51.Location = new Point(0, 0);
            stage_2_51.Size = new Size(ClientSize.Width, ClientSize.Height);
        }

        private void stage_2_61_Load(object sender, EventArgs e)
        {
            stage_2_61.Location = new Point(0, 0);
            stage_2_61.Size = new Size(ClientSize.Width, ClientSize.Height);
        }

        private void stage_2_71_Load(object sender, EventArgs e)
        {
            stage_2_71.Location = new Point(0, 0);
            stage_2_71.Size = new Size(ClientSize.Width, ClientSize.Height);
        }

        private void episode3T1_Load(object sender, EventArgs e)
        {
            episode3T1.Location = new Point(0, 0);
            episode3T1.Size = new Size(ClientSize.Width, ClientSize.Height);
        }

        private void stage_3_11_Load(object sender, EventArgs e)
        {
            stage_3_11.Location = new Point(0, 0);
            stage_3_11.Size = new Size(ClientSize.Width, ClientSize.Height);
        }

        private void stage_3_21_Load(object sender, EventArgs e)
        {
            stage_3_21.Location = new Point(0, 0);
            stage_3_21.Size = new Size(ClientSize.Width, ClientSize.Height);
        }

        private void stage_3_31_Load(object sender, EventArgs e)
        {
            stage_3_31.Location = new Point(0, 0);
            stage_3_31.Size = new Size(ClientSize.Width, ClientSize.Height);
        }

        private void stage_3_41_Load(object sender, EventArgs e)
        {
            stage_3_41.Location = new Point(0, 0);
            stage_3_41.Size = new Size(ClientSize.Width, ClientSize.Height);
        }

        private void stage_3_51_Load(object sender, EventArgs e)
        {
            stage_3_51.Location = new Point(0, 0);
            stage_3_51.Size = new Size(ClientSize.Width, ClientSize.Height);
        }

        private void stage_3_61_Load(object sender, EventArgs e)
        {
            stage_3_61.Location = new Point(0, 0);
            stage_3_61.Size = new Size(ClientSize.Width, ClientSize.Height);
        }

        private void stage_3_71_Load(object sender, EventArgs e)
        {
            stage_3_71.Location = new Point(0, 0);
            stage_3_71.Size = new Size(ClientSize.Width, ClientSize.Height);
        }

        private void pause1_Load(object sender, EventArgs e)
        {
            pause1.Location = new Point(0, 0);
            pause1.Size = new Size(ClientSize.Width, ClientSize.Height);
        }

        private void nextStage11_Load(object sender, EventArgs e)
        {
            nextStage11.Location = new Point(0, 0);
            nextStage11.Size = new Size(ClientSize.Width, ClientSize.Height);
        }

        public Point point = new Point();
        public Color color = new Color();

        [DllImport("user32.dll", SetLastError = true)]
        public static extern IntPtr GetDesktopWindow();
        [DllImport("user32.dll", SetLastError = true)]
        public static extern IntPtr GetWindowDC(IntPtr window);
        [DllImport("gdi32.dll", SetLastError = true)]
        public static extern uint GetPixel(IntPtr dc, int x, int y);
        [DllImport("user32.dll", SetLastError = true)]
        public static extern int ReleaseDC(IntPtr window, IntPtr dc);

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
    }
}

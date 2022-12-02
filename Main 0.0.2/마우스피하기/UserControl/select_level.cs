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
    public partial class select_level : UserControl
    {
        public select_level()
        {
            InitializeComponent();
            label1.BackColor = Color.Transparent;
            label1.Parent = this;
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Parent = this;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            // back 을 눌렀을 경우
            MTAG.form1.stage = 0;
            MTAG.form1.level = 0;
            // select_stage1.cs (스테이지 선택 화면) 로 이동
            MTAG.form1.UserControlVisible(MTAG.form1.select_stage1, this);
        }

        private void label_MouseMove(object sender, MouseEventArgs e)
        {
            MouseEvent.mouseEvent.SetCursorModel();
        }

        private void button_MouseMove(object sender, MouseEventArgs e)
        {
            Button button = sender as Button;
            if (button == button1 || button == button2 || button == button3 ||
                button == button4 || button == button5 || button == button6)
            {
                if (button == button1)
                {
                    button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(0, 255, 0);
                    button1.FlatAppearance.BorderSize = 2;
                } // 버튼 1위에 올라갔을때 테두리가 두꺼워지고 색이 변경
                if (button == button2)
                {
                    button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(0, 255, 0);
                    button2.FlatAppearance.BorderSize = 3;
                } // 버튼 2위에 올라갔을때 테두리가 두꺼워지고 색이 변경
                if (button == button3)
                {
                    button3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(0, 255, 0);
                    button3.FlatAppearance.BorderSize = 3;
                } // 버튼 3위에 올라갔을때 테두리가 두꺼워지고 색이 변경
                if (button == button4)
                {
                    button4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(0, 255, 0);
                    button4.FlatAppearance.BorderSize = 3;
                } // 버튼 3위에 올라갔을때 테두리가 두꺼워지고 색이 변경
                if (button == button5)
                {
                    button5.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(0, 255, 0);
                    button5.FlatAppearance.BorderSize = 3;
                } // 버튼 3위에 올라갔을때 테두리가 두꺼워지고 색이 변경
                if (button == button6)
                {
                    button6.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(0, 255, 0);
                    button6.FlatAppearance.BorderSize = 3;
                } // 버튼 3위에 올라갔을때 테두리가 두꺼워지고 색이 변경
            }
        }

        private void button_MouseLeave(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (button == button1 || button == button2 || button == button3 ||
                button == button4 || button == button5 || button == button6)
            {
                if (button == button1)
                {
                    button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(0, 0, 0);
                    button1.FlatAppearance.BorderSize = 0;
                } // 버튼 1위에 내려갔을때 원래대로 돌아옴.
                if (button == button2)
                {
                    button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(0, 0, 0);
                    button2.FlatAppearance.BorderSize = 0;
                } // 버튼 2위에 내려갔을때 원래대로 돌아옴.
                if (button == button3)
                {
                    button3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(0, 0, 0);
                    button3.FlatAppearance.BorderSize = 0;
                } // 버튼 3위에 내려갔을때 원래대로 돌아옴.
                if (button == button4)
                {
                    button4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(0, 0, 0);
                    button4.FlatAppearance.BorderSize = 0;
                } // 버튼 4위에 내려갔을때 원래대로 돌아옴.
                if (button == button5)
                {
                    button5.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(0, 0, 0);
                    button5.FlatAppearance.BorderSize = 0;
                } // 버튼 5위에 내려갔을때 원래대로 돌아옴.
                if (button == button6)
                {
                    button6.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(0, 0, 0);
                    button6.FlatAppearance.BorderSize = 0;
                } // 버튼 6위에 내려갔을때 원래대로 돌아옴.
            }
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (button == button1 || button == button2 || button == button3 ||
                button == button4 || button == button5 || button == button6)
            {
                if (button == button1) { MTAG.form1.level = 1;} // level1
                if (button == button2) { MTAG.form1.level = 2;} // level2
                if (button == button3) { MTAG.form1.level = 3;} // level3
                if (button == button4) { MTAG.form1.level = 4;} // level4
                if (button == button5) { MTAG.form1.level = 5;} // level5
                if (button == button6) { MTAG.form1.level = 6;} // level6

                // stage_level1.cs (게임 화면) 로 이동
                MTAG.form1.UserControlVisible(MTAG.form1.stage_level1, this);
            }
        }

        private void select_level_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Image img;
            TextureBrush b;

            try { 
            if (MTAG.form1.stage == 1)// stage가 1이면 1스테이지 배경
            {
                img = new Bitmap("Stage 1 (800)(600).jpg");
                b = new TextureBrush(img);
                g.FillRectangle(b, ClientRectangle);
                b.Dispose();
                img.Dispose();
            }
            else if (MTAG.form1.stage == 2)
            {
                img = new Bitmap("stage 2 (800)(600).jpg");
                b = new TextureBrush(img);
                g.FillRectangle(b, ClientRectangle);
                b.Dispose();
                img.Dispose();
            }
            else if (MTAG.form1.stage == 3)
            {
                img = new Bitmap("stage 3 (800)(600).jpg");
                b = new TextureBrush(img);
                g.FillRectangle(b, ClientRectangle);
                b.Dispose();
                img.Dispose();
            }
            }
            catch { }
        }
    }
}

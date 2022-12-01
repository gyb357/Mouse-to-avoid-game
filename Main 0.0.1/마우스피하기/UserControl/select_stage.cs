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
    public partial class select_stage : UserControl
    {
        public select_stage()
        {
            InitializeComponent();
        }



        private void label_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
                MTAG.form1.stage = 0;
                // main1.cs (메인 화면) 로 이동
                MTAG.form1.UserControlVisible(MTAG.form1.main1, this);
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void button_click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            // stage1, stage2, stage3 를 눌렀을 경우
            if (button == button1 || button == button2 || button == button3)
            {
                if (button == button1) { MTAG.form1.stage = 1; } // stage1
                if (button == button2) { MTAG.form1.stage = 2; } // stage2
                if (button == button3) { MTAG.form1.stage = 3; } // stage3

                MTAG.form1.UserControlVisible(MTAG.form1.select_level1, this);
            }
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            MouseEvent.mouseEvent.SetCursorModel();
            button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(255,0,0);
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(0, 0, 0);
        }

        private void button_MouseMove(object sender, MouseEventArgs e)
        {
            MouseEvent.mouseEvent.SetCursorModel();
            Button button = sender as Button;
            if (button == button1 || button == button2 || button == button3)
            {
                if (button == button1) { button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(255, 0, 0);
                    button1.FlatAppearance.BorderSize = 2;} // 버튼 1위에 올라갔을때 테두리가 두꺼워지고 색이 변경
                if (button == button2) { button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(255, 0, 0); 
                    button2.FlatAppearance.BorderSize = 3;} // 버튼 2위에 올라갔을때 테두리가 두꺼워지고 색이 변경
                if (button == button3) { button3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(255, 0, 0); 
                    button3.FlatAppearance.BorderSize = 3;} // 버튼 3위에 올라갔을때 테두리가 두꺼워지고 색이 변경
            }
        }

        private void button_MouseLeave(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (button == button1 || button == button2 || button == button3)
            {
                if (button == button1) { button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(0, 0, 0);
                    button1.FlatAppearance.BorderSize = 0;} // 버튼 1위에 내려갔을때 원래대로 돌아옴.
                if (button == button2) { button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(0, 0, 0); 
                    button2.FlatAppearance.BorderSize = 0;} // 버튼 1위에 내려갔을때 원래대로 돌아옴.
                if (button == button3) { button3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(0, 0, 0); 
                    button3.FlatAppearance.BorderSize = 0;} // 버튼 1위에 내려갔을때 원래대로 돌아옴.
            }
        }
    }
}

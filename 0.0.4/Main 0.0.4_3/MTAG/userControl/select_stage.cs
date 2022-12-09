using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace MTAG
{
    public partial class select_stage : UserControl
    {
        public select_stage()
        {
            InitializeComponent();


            
            // 스테이지 버튼 초기화
            Buttons buttons = new Buttons();
            Button[] button = new Button[]
            {
                button1, button2, button3
            };

            buttons.InitializeSelectButton(button);



            // 뒤로가기 버튼, 타이틀 투명화
            label1.BackColor      = Color.Transparent;
            pictureBox1.BackColor = Color.Transparent;
        }



        private string text       = "스테이지 "; // select_level 타이틀 텍스트
        private int    buttonIdx  = 6;           // "buttonN"에서 N이 위치한 인덱스
        private int    borderSize = 4;           // 스테이지 버튼 테두리 크기



        private void Button_Click(object sender, EventArgs e)
        {
            Button b     = sender as Button;
            int    stage = Convert.ToUInt16(b.Name[buttonIdx].ToString());
 
            if (stage == 1) { Form1.form1.select_level1.label1.Image = Properties.Resources.스테이지_1; }
            else if (stage == 2) { Form1.form1.select_level1.label1.Image = Properties.Resources.스테이지_2; }
            else if (stage == 3) { Form1.form1.select_level1.label1.Image = Properties.Resources.스테이지_3; }
            Form1.form1.stage = stage;
            Form1.form1.UserControlVisible(Form1.form1.select_level1, this);
        }
        private void PictureBox_Click(object sender, EventArgs e)
        {
            Form1.form1.UserControlVisible(Form1.form1.main1, this);
        }



        private void Button_Move(object sender, MouseEventArgs e)
        {
            Button b = sender as Button;

            b.FlatAppearance.BorderSize = borderSize;
        }
        private void Button_Leave(object sender, EventArgs e)
        {
            Button b = sender as Button;

            b.FlatAppearance.BorderSize = 0;
        }
    }
}

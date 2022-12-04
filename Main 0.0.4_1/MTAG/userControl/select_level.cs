using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace MTAG
{
    public partial class select_level : UserControl
    {
        public select_level()
        {
            InitializeComponent();



            // 레벨 버튼 초기화
            Buttons buttons = new Buttons();
            Button[] button = new Button[]
            {
                button1, button2, button3, button4, button5, button6
            };

            buttons.InitializeSelectButton(button);



            // 뒤로가기 버튼, 타이틀 투명화
            label1.BackColor      = Color.Transparent;
            pictureBox1.BackColor = Color.Transparent;
        }



        private int    buttonIdx  = 6;                                     // "buttonN"에서 N이 위치한 인덱스
        private int    borderSize = 4;                                     // 레벨 버튼 테두리 크기
        private string fp_folder  = "\\image\\backGround\\select_level\\"; // 배경 이미지 경로



        private void Button_Click(object sender, EventArgs e)
        {
            Button b = sender as Button;

            Form1.form1.level = Convert.ToUInt16(b.Name[buttonIdx].ToString());
            Form1.form1.UserControlVisible(Form1.form1.stage_level1, this);
            Form1.form1.InitializeMousePosition();
        }
        private void PictureBox_Click(object sender, EventArgs e)
        {
            Form1.form1.stage = 0;
            Form1.form1.UserControlVisible(Form1.form1.select_stage1, this);
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



        // 배경 이미지 호풀
        private void select_level_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                string fp_image = "Stage " + Form1.form1.stage + " (800)(600).jpg";

                Graphics     g = e.Graphics;
                Image        i = new Bitmap(Form1.form1.fp_Project + fp_folder + fp_image);
                TextureBrush b = new TextureBrush(i);

                i = new Bitmap(i);
                b = new TextureBrush(i);
                g.FillRectangle(b, ClientRectangle);
                b.Dispose();
                i.Dispose();
            }
            catch { }
        }
    }
}

using System;
using System.Windows.Forms;



namespace MTAG
{
    public partial class game_success : UserControl
    {
        public game_success()
        {
            InitializeComponent();
        }



        private string text = "스테이지 "; // select_level 타이틀 텍스트



        private void Label_Click(object sender, EventArgs e)
        {
            Label l = sender as Label;

            if (l == label2)
            {
                Form1.form1.level = 0;
                Form1.form1.UserControlVisible(Form1.form1.select_level1, this);
                Form1.form1.buttonEnabled();
            }
            else if (l == label3)
            {
                Form1.form1.UserControlVisible(Form1.form1.stage_level1, this);
                Form1.form1.InitializeMousePosition();
            }
            else if (l == label4)
            {
                if (Form1.form1.stage <= 3)
                {
                    if (Form1.form1.level > 5)
                    {
                        if (Form1.form1.stage < 3)
                        {
                            Form1.form1.stage += 1;
                            Form1.form1.level  = 1;
                            if (Form1.form1.stage == 1) { Form1.form1.select_level1.label1.Image = Properties.Resources.스테이지_1; }
                            else if (Form1.form1.stage == 2) { Form1.form1.select_level1.label1.Image = Properties.Resources.스테이지_2; }
                            else if (Form1.form1.stage == 3) { Form1.form1.select_level1.label1.Image = Properties.Resources.스테이지_3; }
                        }
                        else
                        {
                            MessageBox.Show("클리어");
                            Form1.form1.UserControlVisible(Form1.form1.main1, this);
                            Form1.form1.stage = 0;
                            Form1.form1.level = 0;

                            return;
                        }
                    }
                    else {Form1.form1.level++;}

                    Form1.form1.UserControlVisible(Form1.form1.stage_level1, this);
                    Form1.form1.InitializeMousePosition();
                    Form1.form1.InitializePictureBox_Visible(Form1.form1.pictureBox_Visible, Form1.form1.stage, Form1.form1.level);
                }
            }
        }



        private void Label_MouseMove(object sender, MouseEventArgs e)
        {
            Label l = sender as Label;

            if      (l == label2) {label2.Image = Properties.Resources.선택화면으로p;}
            else if (l == label3) {label3.Image = Properties.Resources.다시하기p;}
            else if (l == label4) {label4.Image = Properties.Resources.다음_단계로p;}
        }
        private void label4_MouseLeave(object sender, EventArgs e)
        {
            Label l = sender as Label;

            if      (l == label2) {label2.Image = Properties.Resources.선택화면으로n;}
            else if (l == label3) {label3.Image = Properties.Resources.다시하기n;}
            else if (l == label4) {label4.Image = Properties.Resources.다음_단계로n;}
        }
    }
}

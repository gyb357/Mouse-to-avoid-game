using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            }
            if (l == label3)
            {
                Form1.form1.UserControlVisible(Form1.form1.stage_level1, this);
                Form1.form1.InitializeMousePosition();
            }
            if (l == label4)
            {
                if (Form1.form1.stage <= 3)
                {
                    if (Form1.form1.level > 5)
                    {
                        if (Form1.form1.stage < 3)
                        {
                            Form1.form1.stage += 1;
                            Form1.form1.level  = 1;
                            Form1.form1.select_level1.label1.Text = text + Form1.form1.stage;
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
                    else
                    {
                        Form1.form1.level++;
                    }

                    Form1.form1.UserControlVisible(Form1.form1.stage_level1, this);
                    Form1.form1.InitializeMousePosition();
                }
            }
        }



        private void Label_MouseMove(object sender, MouseEventArgs e)
        {
            Label l = sender as Label;
            if (l == label2)
            {
                label2.Image = Properties.Resources.선택화면으로p;
            }
            else if (l == label3)
            {
                label3.Image = Properties.Resources.다시하기p;
            }
            else if (l == label4)
            {
                label4.Image = Properties.Resources.다음_단계로p;
            }
        }

        private void label4_MouseLeave(object sender, EventArgs e)
        {
            Label l = sender as Label;
            if (l == label2)
            {
                label2.Image = Properties.Resources.선택화면으로n;
            }
            else if (l == label3)
            {
                label3.Image = Properties.Resources.다시하기n;
            }
            else if (l == label4)
            {
                label4.Image = Properties.Resources.다음_단계로n;
            }
        }
    }
}

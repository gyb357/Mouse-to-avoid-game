using System;
using System.Windows.Forms;



namespace MTAG
{
    public partial class game_over : UserControl
    {
        public game_over()
        {
            InitializeComponent();
        }



        private void Label_Click(object sender, EventArgs e)
        {
            Label l = sender as Label;

            if (l == label2)
            {
                Form1.form1.UserControlVisible(Form1.form1.stage_level1, this);
                Form1.form1.InitializeMousePosition();
            }
            else if (l == label3)
            {
                Form1.form1.level = 0;
                Form1.form1.UserControlVisible(Form1.form1.select_level1, this);
            }
        }



        private void Label_MouseMove(object sender, MouseEventArgs e)
        {
            Label l = sender as Label;

            if      (l == label2) {label2.Image = Properties.Resources.다시하기p;}
            else if (l == label3) {label3.Image = Properties.Resources.선택화면으로p;}
        }
        private void label3_MouseLeave(object sender, EventArgs e)
        {
            Label l = sender as Label;

            if      (l == label2) {label2.Image = Properties.Resources.다시하기n;}
            else if (l == label3) {label3.Image = Properties.Resources.선택화면으로n;}
        }
    }
}

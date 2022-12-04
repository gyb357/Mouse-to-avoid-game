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
    public partial class main : UserControl
    {
        public main()
        {
            InitializeComponent();
        }



        private void Label_Click(object sender, EventArgs e)
        {
            Label l = sender as Label;

            if (l == label2) { Form1.form1.UserControlVisible(Form1.form1.select_stage1, this); }
            if (l == label3) { Form1.form1.UserControlVisible(Form1.form1.how_to_play1, this); }
            if (l == label4) { Form1.form1.Close(); }
        }



        private void Label_MouseMove(object sender, MouseEventArgs e)
        {
            Label l = sender as Label;
            //Cursor.Current = Cursors.Hand;
            if (l == label2)
            {
                label2.Image = Properties.Resources.게임_시작_p;
            }
            else if (l == label3)
            {
                label3.Image = Properties.Resources.게임_방법_p;
            }
            else if (l == label4)
            {
                label4.Image = Properties.Resources.끝내기_p;
            }
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            Label l = sender as Label;
            if (l == label2)
            {
                label2.Image = Properties.Resources.게임_시작_n;
            }
            else if (l == label3)
            {
                label3.Image = Properties.Resources.게임_방법_n;
            }
            else if (l == label4)
            {
                label4.Image = Properties.Resources.끝내기_n;
            }
        }
    }
}

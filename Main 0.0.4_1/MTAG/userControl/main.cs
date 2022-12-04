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
            Cursor.Current = Cursors.Hand;
        }
    }
}

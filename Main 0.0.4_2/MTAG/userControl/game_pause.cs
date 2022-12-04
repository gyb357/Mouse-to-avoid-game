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
    public partial class game_pause : UserControl
    {
        public game_pause()
        {
            InitializeComponent();
        }



        private void Label_Click(object sender, EventArgs e)
        {
            Label l = sender as Label;

            if (l == label2)
            {
                Mouse.mouse.SetMousePosition(Form1.form1.mousePoint);

                Form1.form1.UserControlVisible(Form1.form1.stage_level1, this);
            }
            if (l == label3)
            {
                Form1.form1.level= 0;
                Form1.form1.UserControlVisible(Form1.form1.select_level1, this);
            }
            Form1.form1.stage_level1.temp = 0;
        }



        private void Label_MouseMove(object sender, MouseEventArgs e)
        {
            Cursor.Current = Cursors.Hand;
        }
    }
}

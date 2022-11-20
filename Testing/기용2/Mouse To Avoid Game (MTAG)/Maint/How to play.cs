using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mouse_To_Avoid_Game__MTAG_
{
    public partial class How_to_play : UserControl
    {
        public How_to_play()
        {
            InitializeComponent();
        }

        private void 뒤로가기_Click(object sender, EventArgs e)
        {
            Main.m.how_to_play1.Visible = false;
            Main.m.title1.Visible = true;
        }

        private void 뒤로가기_MouseMove(object sender, MouseEventArgs e)
        {
            Cursor.Current = Cursors.Hand;
        }
    }
}

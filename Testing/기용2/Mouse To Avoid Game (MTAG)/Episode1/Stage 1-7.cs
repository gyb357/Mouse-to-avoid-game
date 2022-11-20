using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mouse_To_Avoid_Game__MTAG_.Stage1
{
    public partial class Stage_1_7 : UserControl
    {
        public Stage_1_7()
        {
            InitializeComponent();
        }

        private void Stage_1_7_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Main.m.pause1.Visible = true;
                Main.m.pause1.BringToFront();
                Main.m.pause1.Focus();
            }
        }
    }
}

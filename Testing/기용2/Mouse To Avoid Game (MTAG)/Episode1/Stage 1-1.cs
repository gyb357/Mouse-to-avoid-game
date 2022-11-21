using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Mouse_To_Avoid_Game__MTAG_.Stage1
{
    public partial class Stage_1_1 : UserControl
    {
        public Stage_1_1()
        {
            InitializeComponent();
        }


        private void Stage_1_1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Main.m.pause1.Visible = true;
                Main.m.pause1.BringToFront();
                Main.m.pause1.Focus();
            }
        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            Main.m.point = Cursor.Position;
            Main.m.color = Main.m.GetColor(Main.m.point);

            int r = Main.m.color.R;
            int g = Main.m.color.G;
            int b = Main.m.color.B;

            if (r == 255 && g == 255 && b == 0)
            {
                Main.m.nextStage11.i = 1;
                Main.m.nextStage11.Visible = true;
                Main.m.stage_1_11.Visible = false;
                Main.m.nextStage11.Focus();
                Main.m.nextStage11.BringToFront();
            }
            else
            {
            }
        }
    }
}

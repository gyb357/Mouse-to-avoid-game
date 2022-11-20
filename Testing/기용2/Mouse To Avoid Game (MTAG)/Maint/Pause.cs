using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mouse_To_Avoid_Game__MTAG_.Maint
{
    public partial class Pause : UserControl
    {
        public Pause()
        {
            InitializeComponent();
        }

        private void Pause_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Main.m.pause1.Visible = false;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Main.m.pause1.Visible = false;
            Main.m.episodeSel1.Visible = true;
            Main.m.episodeSel1.BringToFront();
            Main.m.episodeSel1.Focus();
        }
    }
}

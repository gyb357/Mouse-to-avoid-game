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
    public partial class EpisodeSel : UserControl
    {
        public EpisodeSel()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Main.m.episodeSel1.Visible= false;
            Main.m.title1.Visible = true;
            Main.m.title1.BringToFront();
            Main.m.title1.Focus();
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            Cursor.Current = Cursors.Hand;
        }

        private void episode1_Click(object sender, EventArgs e)
        {
            Main.m.episode1T1.Visible= true;
            Main.m.episodeSel1.Visible = false;
            Main.m.episode1T1.BringToFront();
            Main.m.episode1T1.Focus();
        }

        private void episode2_Click(object sender, EventArgs e)
        {
            Main.m.episode21.Visible = true;
            Main.m.episodeSel1.Visible = false; 
            Main.m.episode21.BringToFront();
            Main.m.episode21.Focus();
        }

        private void episode3_Click(object sender, EventArgs e)
        {
            Main.m.episode3T1.Visible = true;
            Main.m.episodeSel1.Visible = false;
            Main.m.episode3T1.BringToFront();
            Main.m.episode3T1.Focus();
        }

        private void episode1_MouseMove(object sender, MouseEventArgs e)
        {
            Cursor.Current = Cursors.Hand;
        }
    }
}

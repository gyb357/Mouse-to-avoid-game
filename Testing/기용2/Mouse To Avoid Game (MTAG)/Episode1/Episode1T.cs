using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mouse_To_Avoid_Game__MTAG_.Episode1
{
    public partial class Episode1T : UserControl
    {
        public Episode1T()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Main.m.episode1T1.Visible = false;
            Main.m.stage_1_11.Visible = true;
            Main.m.stage_1_11.BringToFront();
            Main.m.stage_1_11.Focus();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Main.m.episode1T1.Visible = false;
            Main.m.stage_1_21.Visible = true;
            Main.m.stage_1_21.BringToFront();
            Main.m.stage_1_21.Focus();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Main.m.episode1T1.Visible = false;
            Main.m.stage_1_31.Visible = true;
            Main.m.stage_1_31.BringToFront();
            Main.m.stage_1_31.Focus();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Main.m.episode1T1.Visible = false;
            Main.m.stage_1_41.Visible = true;
            Main.m.stage_1_41.BringToFront();
            Main.m.stage_1_41.Focus();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Main.m.episode1T1.Visible = false;
            Main.m.stage_1_51.Visible = true;
            Main.m.stage_1_51.BringToFront();
            Main.m.stage_1_51.Focus();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Main.m.episode1T1.Visible = false;
            Main.m.stage_1_61.Visible = true;
            Main.m.stage_1_61.BringToFront();
            Main.m.stage_1_61.Focus();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Main.m.episode1T1.Visible = false;
            Main.m.stage_1_71.Visible = true;
            Main.m.stage_1_71.BringToFront();
            Main.m.stage_1_71.Focus();
        }

        private void pictureBox6_MouseMove(object sender, MouseEventArgs e)
        {
            Cursor.Current = Cursors.Hand;
        }
    }
}

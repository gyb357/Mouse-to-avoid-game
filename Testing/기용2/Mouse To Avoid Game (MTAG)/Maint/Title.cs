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
    public partial class Title : UserControl
    {
        public Title()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Main.m.episodeSel1.Visible = true;
            Main.m.title1.Visible = false;
            Main.m.episodeSel1.BringToFront();
            Main.m.episodeSel1.Focus();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Main.m.how_to_play1.Visible = true;
            Main.m.title1.Visible = false;
            Main.m.how_to_play1.BringToFront();
            Main.m.how_to_play1.Focus();
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            Cursor.Current = Cursors.Hand;
        }

        private void label2_MouseMove(object sender, MouseEventArgs e)
        {
            Cursor.Current = Cursors.Hand;
        }

        private void label3_MouseMove(object sender, MouseEventArgs e)
        {
            Cursor.Current = Cursors.Hand;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Main.m.Close();
        }
    }
}

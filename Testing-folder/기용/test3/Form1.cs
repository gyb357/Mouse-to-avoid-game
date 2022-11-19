using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test3
{
    public partial class Main : Form
    {
        int i = 0;
        EpisodeSel epsel = new EpisodeSel();
        public Main()
        {
            InitializeComponent();

        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Controls.Add(epsel);
            label1.Location = new Point(10, 10);
            _21.Visible = true;
        }

        public void backcolor()
        {
           label1.BackColor = Color.Transparent;
           label1.Parent = this;
        }

        private void _21_Click(object sender, EventArgs e)
        {

        }

        private void Main_KeyDown(object sender, KeyEventArgs e) // esc 눌렀을때 옵션화면 들어가게 하기.
        {
            if (e.KeyCode == Keys.Escape)
            {
                episodeSel1.Visible = true;
                /*i = i + 1;
                if (i % 2 == 1)
                {
                    episodeSel1.Visible = true;
                }
                else
                {
                    episodeSel1.Visible = false;
                }*/
             }
        }

        private void episodeSel1_KeyDown(object sender, KeyEventArgs e)
        {
            MessageBox.Show("HI");
            if (e.KeyCode == Keys.Escape)
            {
                episodeSel1.Visible = false;
                i = 0;
            }
        }

        private void episodeSel1_Layout(object sender, LayoutEventArgs e)
        {

        }
    }
}

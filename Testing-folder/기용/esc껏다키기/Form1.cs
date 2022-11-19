using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace esc껏다키기
{
    public partial class Form1 : Form
    {
        int keycount;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                if (keycount % 2 == 1)
                {
                    userControl11.Visible = false;
                    userControl11.Enabled = false;
                    keycount++;
                }
                else if (keycount % 2 == 0)
                {
                    userControl11.Visible = true;
                    userControl11.Enabled = true;
                    keycount++;
                }
                else
                {
                    MessageBox.Show("알수없는 오류가 발생하였습니다.");
                }
            }
        }// esc 껏다키는건데 usercontrol이 보일때 만지면 esc키가 안먹힘.

        private void userControl11_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
               userControl11.Enabled = false;
               userControl11.Visible = false;
            }
        }

        private void userControl11_Load(object sender, EventArgs e)
        {
            userControl11.Location = new Point(0,0);
            userControl11.Size = new Size(816, 489);
        }
    }
}

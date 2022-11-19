using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 다중지정폼
{
    public partial class Form1 : Form
    {
        public static Form1 f;
        public Form1()
        {
            InitializeComponent();
            f = this;
            userControl11.Visible = true;
        }

        private void userControl11_Load(object sender, EventArgs e)
        {
            userControl11.Location = new Point(0,0);
            userControl11.Size = new Size(816, 489);
        }

        private void userControl21_Load(object sender, EventArgs e)
        {
            userControl21.Location = new Point(0, 0);
            userControl21.Size = new Size(816, 489);
        }

        private void userControl31_Load(object sender, EventArgs e)
        {
            userControl31.Location = new Point(0, 0);
            userControl31.Size = new Size(816, 489);
        }

        private void userControl41_Load(object sender, EventArgs e)
        {
            userControl41.Location = new Point(0, 0);
            userControl41.Size = new Size(816, 489);
        }
    }
}

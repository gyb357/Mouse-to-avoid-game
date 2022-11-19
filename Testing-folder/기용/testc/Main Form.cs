using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testc
{
    public partial class Main : Form
    {
        epsel ep = new epsel(this);
        public Main()
        {
            InitializeComponent();
            labeltrans();
        }

        private void Form_Load_Title(object sender, EventArgs e)
        {

        }
        public void labeltrans()
        {
            label1.Parent = this;
            label1.BackColor = Color.Transparent;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Controls.Add(ep);

        }
    }
}

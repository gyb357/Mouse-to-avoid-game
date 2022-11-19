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
    public partial class epsel : UserControl
    {
        Main epsel;
        public epsel(Main form)
        {
            InitializeComponent();
            epsel = form;
            epsel.labeltrans();
        }

        private void 게임Episode_Load(object sender, EventArgs e)
        {

        }
    }
}

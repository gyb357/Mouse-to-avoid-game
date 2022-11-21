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
    public partial class NextStage1 : UserControl
    {
        public int i = 0;
        public NextStage1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            switch (i)
            {
                case 1: 
                    Main.m.stage_1_21.Visible = true;
                    Main.m.stage_1_21.Focus();
                    Main.m.stage_1_21.BringToFront();
                    Main.m.nextStage11.Visible = false;
                    break;
                case 2:
                    Main.m.stage_1_31.Visible = true;
                    Main.m.stage_1_31.Focus();
                    Main.m.stage_1_31.BringToFront();
                    Main.m.nextStage11.Visible = false;
                    break;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

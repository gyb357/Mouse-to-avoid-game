using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace MTAG
{
    public partial class how_to_play : UserControl
    {
        public how_to_play()
        {
            InitializeComponent();



            label1.BackColor      = Color.Transparent;
            pictureBox1.BackColor = Color.Transparent;
        }



        private void PictureBox_Click(object sender, EventArgs e)
        {
            Form1.form1.UserControlVisible(Form1.form1.main1, this);
        }
    }
}

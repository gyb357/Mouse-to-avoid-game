using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace UserControl0
{
    public partial class how_to_play : UserControl
    {
        public how_to_play()
        {
            InitializeComponent();
        }



        private void label_Click(object sender, EventArgs e)
        {
            // back 을 눌렀을 경우 main1.cs (메인 화면) 로 이동
            Form1.form1.UserControlVisible(Form1.form1.main1, this);
        }



        private void label_MouseMove(object sender, MouseEventArgs e)
        {
            MouseEvent.mouseEvent.SetCursorModel();
        }
    }
}

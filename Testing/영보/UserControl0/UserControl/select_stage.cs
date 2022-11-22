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
    public partial class select_stage : UserControl
    {
        public select_stage()
        {
            InitializeComponent();
        }



        private void label_Click(object sender, EventArgs e)
        {
            Label label = sender as Label;


            // stage1, stage2, stage3 를 눌렀을 경우
            if (label == label2 || label == label3 || label == label4) {
                if (label == label2) { Form1.form1.stage = 1; } // stage1
                if (label == label3) { Form1.form1.stage = 2; } // stage2
                if (label == label4) { Form1.form1.stage = 3; } // stage3


                // select_level1.cs (레벨 선택 화면) 로 이동
                Form1.form1.UserControlVisible(Form1.form1.select_level1, this);
            }


            // back 을 눌렀을 경우
            if (label == label5) {
                Form1.form1.stage = 0;


                // main1.cs (메인 화면) 로 이동
                Form1.form1.UserControlVisible(Form1.form1.main1, this); 
            }
        }



        private void label_MouseMove(object sender, MouseEventArgs e)
        {
            MouseEvent.mouseEvent.SetCursorModel();
        }
    }
}

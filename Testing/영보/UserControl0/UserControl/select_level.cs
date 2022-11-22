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
    public partial class select_level : UserControl
    {
        public select_level()
        {
            InitializeComponent();
        }



        private void label_Click(object sender, EventArgs e)
        {
            Label label = sender as Label;


            // level1, level2, level3 ... level6 를 눌렀을 경우
            if (label == label2 || label == label3 || label == label4 ||
                label == label5 || label == label6 || label == label7)
            {
                if (label == label2) { Form1.form1.level = 1; } // level1
                if (label == label3) { Form1.form1.level = 2; } // level2
                if (label == label4) { Form1.form1.level = 3; } // level3
                if (label == label5) { Form1.form1.level = 4; } // level4
                if (label == label6) { Form1.form1.level = 5; } // level5
                if (label == label7) { Form1.form1.level = 6; } // level6


                // stage_level1.cs (게임 화면) 로 이동
                Form1.form1.UserControlVisible(Form1.form1.stage_level1, this);
            }


            // back 을 눌렀을 경우
            if (label == label8) {
                Form1.form1.stage = 0;
                Form1.form1.level = 0;


                // select_stage1.cs (스테이지 선택 화면) 로 이동
                Form1.form1.UserControlVisible(Form1.form1.select_stage1, this);
            }
        }



        private void label_MouseMove(object sender, MouseEventArgs e)
        {
            MouseEvent.mouseEvent.SetCursorModel();
        }
    }
}

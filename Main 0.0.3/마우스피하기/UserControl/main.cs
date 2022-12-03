using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace UserControl0
{
    public partial class main : UserControl
    {
        public main()
        {
            InitializeComponent();
        }



        private void label_Click(object sender, EventArgs e)
        {
            Label label = sender as Label;


            if (label == label2) { MTAG.form1.UserControlVisible(MTAG.form1.select_stage1, this); } // game start  를 눌렀을 경우 select_stage1.cs (스테이지 선택 화면) 로 이동
            if (label == label3) { MTAG.form1.UserControlVisible(MTAG.form1.how_to_play1, this); }  // how to play 를 눌렀을 경우 how_to_play1.cs  (게입 방법 화면)     로 이동
            if (label == label4) { MTAG.form1.Close(); }                                             // exit        를 눌렀을 경우 프로그램 종료
        }



        private void label_MouseMove(object sender, MouseEventArgs e)
        {
            MouseEvent.mouseEvent.SetCursorModel();
        }
    }
}

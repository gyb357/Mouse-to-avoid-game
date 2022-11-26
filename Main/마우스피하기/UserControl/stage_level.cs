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
    public partial class stage_level : UserControl
    {
        public stage_level()
        {
            InitializeComponent();
        }



        private void stage_level_KeyDown(object sender, KeyEventArgs e)
        {
            // Ecs 키를 눌렀을 경우
            if (e.KeyCode == Keys.Escape)
            {
                // 마우스 위치 저장
                MTAG.form1.mousePoint = Cursor.Position;


                // game_pause1.cs (일시 정지 화면) 로 이동
                MTAG.form1.UserControlVisible(MTAG.form1.game_pause1, this);
            }
        }
    }
}

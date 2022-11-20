namespace Mouse_To_Avoid_Game__MTAG_
{
    partial class How_to_play
    {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.뒤로가기 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // 뒤로가기
            // 
            this.뒤로가기.AutoSize = true;
            this.뒤로가기.Location = new System.Drawing.Point(28, 16);
            this.뒤로가기.Name = "뒤로가기";
            this.뒤로가기.Size = new System.Drawing.Size(53, 12);
            this.뒤로가기.TabIndex = 0;
            this.뒤로가기.Text = "뒤로가기";
            this.뒤로가기.Click += new System.EventHandler(this.뒤로가기_Click);
            this.뒤로가기.MouseMove += new System.Windows.Forms.MouseEventHandler(this.뒤로가기_MouseMove);
            // 
            // How_to_play
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.뒤로가기);
            this.Name = "How_to_play";
            this.Size = new System.Drawing.Size(814, 432);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label 뒤로가기;
    }
}

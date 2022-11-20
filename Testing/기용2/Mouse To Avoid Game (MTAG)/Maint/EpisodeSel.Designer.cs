namespace Mouse_To_Avoid_Game__MTAG_.Maint
{
    partial class EpisodeSel
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
            this.episode1 = new System.Windows.Forms.PictureBox();
            this.episode2 = new System.Windows.Forms.PictureBox();
            this.episode3 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.episode1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.episode2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.episode3)).BeginInit();
            this.SuspendLayout();
            // 
            // episode1
            // 
            this.episode1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.episode1.Cursor = System.Windows.Forms.Cursors.Default;
            this.episode1.Location = new System.Drawing.Point(78, 120);
            this.episode1.Name = "episode1";
            this.episode1.Size = new System.Drawing.Size(189, 185);
            this.episode1.TabIndex = 0;
            this.episode1.TabStop = false;
            this.episode1.Click += new System.EventHandler(this.episode1_Click);
            this.episode1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.episode1_MouseMove);
            // 
            // episode2
            // 
            this.episode2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.episode2.Location = new System.Drawing.Point(306, 120);
            this.episode2.Name = "episode2";
            this.episode2.Size = new System.Drawing.Size(181, 185);
            this.episode2.TabIndex = 1;
            this.episode2.TabStop = false;
            this.episode2.Click += new System.EventHandler(this.episode2_Click);
            this.episode2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.episode1_MouseMove);
            // 
            // episode3
            // 
            this.episode3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.episode3.Location = new System.Drawing.Point(552, 120);
            this.episode3.Name = "episode3";
            this.episode3.Size = new System.Drawing.Size(181, 185);
            this.episode3.TabIndex = 2;
            this.episode3.TabStop = false;
            this.episode3.Click += new System.EventHandler(this.episode3_Click);
            this.episode3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.episode1_MouseMove);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "뒤로 가기";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label1_MouseMove);
            // 
            // EpisodeSel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.episode3);
            this.Controls.Add(this.episode2);
            this.Controls.Add(this.episode1);
            this.Name = "EpisodeSel";
            this.Size = new System.Drawing.Size(806, 461);
            ((System.ComponentModel.ISupportInitialize)(this.episode1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.episode2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.episode3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox episode1;
        private System.Windows.Forms.PictureBox episode2;
        private System.Windows.Forms.PictureBox episode3;
        private System.Windows.Forms.Label label1;
    }
}

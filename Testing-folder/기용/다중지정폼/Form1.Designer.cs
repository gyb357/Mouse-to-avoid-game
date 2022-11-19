namespace 다중지정폼
{
    partial class Form1
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

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.userControl41 = new 다중지정폼.UserControl4();
            this.userControl31 = new 다중지정폼.UserControl3();
            this.userControl21 = new 다중지정폼.UserControl2();
            this.userControl11 = new 다중지정폼.UserControl1();
            this.SuspendLayout();
            // 
            // userControl41
            // 
            this.userControl41.BackColor = System.Drawing.SystemColors.ControlDark;
            this.userControl41.Location = new System.Drawing.Point(147, 228);
            this.userControl41.Name = "userControl41";
            this.userControl41.Size = new System.Drawing.Size(210, 137);
            this.userControl41.TabIndex = 3;
            this.userControl41.Visible = false;
            this.userControl41.Load += new System.EventHandler(this.userControl41_Load);
            // 
            // userControl31
            // 
            this.userControl31.BackColor = System.Drawing.Color.Red;
            this.userControl31.Location = new System.Drawing.Point(476, 46);
            this.userControl31.Name = "userControl31";
            this.userControl31.Size = new System.Drawing.Size(150, 150);
            this.userControl31.TabIndex = 2;
            this.userControl31.Visible = false;
            this.userControl31.Load += new System.EventHandler(this.userControl31_Load);
            // 
            // userControl21
            // 
            this.userControl21.BackColor = System.Drawing.Color.Coral;
            this.userControl21.ForeColor = System.Drawing.SystemColors.Control;
            this.userControl21.Location = new System.Drawing.Point(281, 46);
            this.userControl21.Name = "userControl21";
            this.userControl21.Size = new System.Drawing.Size(150, 150);
            this.userControl21.TabIndex = 1;
            this.userControl21.Visible = false;
            this.userControl21.Load += new System.EventHandler(this.userControl21_Load);
            // 
            // userControl11
            // 
            this.userControl11.BackColor = System.Drawing.Color.Blue;
            this.userControl11.Location = new System.Drawing.Point(111, 46);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(150, 150);
            this.userControl11.TabIndex = 0;
            this.userControl11.Visible = false;
            this.userControl11.Load += new System.EventHandler(this.userControl11_Load);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.userControl41);
            this.Controls.Add(this.userControl31);
            this.Controls.Add(this.userControl21);
            this.Controls.Add(this.userControl11);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        public UserControl1 userControl11;
        public UserControl2 userControl21;
        public UserControl3 userControl31;
        public UserControl4 userControl41;
    }
}


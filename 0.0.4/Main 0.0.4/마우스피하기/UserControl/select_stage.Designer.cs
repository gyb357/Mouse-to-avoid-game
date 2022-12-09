namespace UserControl0
{
    partial class select_stage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(select_stage));
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("굴림", 15F);
            this.label1.Location = new System.Drawing.Point(100, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "Stage 1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(100, 200);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 150);
            this.button1.TabIndex = 5;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button_click);
            this.button1.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            this.button1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button_MouseMove);
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = global::UserControl0.Properties.Resources.stage_2__150__150_;
            this.button2.Location = new System.Drawing.Point(325, 200);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 150);
            this.button2.TabIndex = 6;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button_click);
            this.button2.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            this.button2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button_MouseMove);
            // 
            // button3
            // 
            this.button3.Enabled = false;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Image = global::UserControl0.Properties.Resources.stage_3__150__150_;
            this.button3.Location = new System.Drawing.Point(550, 200);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(150, 150);
            this.button3.TabIndex = 7;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button_click);
            this.button3.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            this.button3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button_MouseMove);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::UserControl0.Properties.Resources.뒤로가기___복사본;
            this.pictureBox1.Location = new System.Drawing.Point(20, 470);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("굴림", 15F);
            this.label2.Location = new System.Drawing.Point(325, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 48);
            this.label2.TabIndex = 0;
            this.label2.Text = "Stage 2";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("굴림", 15F);
            this.label3.Location = new System.Drawing.Point(550, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 48);
            this.label3.TabIndex = 0;
            this.label3.Text = "Stage 3";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // select_stage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "select_stage";
            this.Size = new System.Drawing.Size(800, 600);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.Button button2;
        public System.Windows.Forms.Button button3;
    }
}

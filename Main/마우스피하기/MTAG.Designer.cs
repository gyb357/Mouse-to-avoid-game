namespace UserControl0
{
    partial class MTAG
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.game_pause1 = new UserControl0.game_pause();
            this.game_over1 = new UserControl0.game_over();
            this.game_success1 = new UserControl0.game_success();
            this.stage_level1 = new UserControl0.stage_level();
            this.select_level1 = new UserControl0.select_level();
            this.select_stage1 = new UserControl0.select_stage();
            this.how_to_play1 = new UserControl0.how_to_play();
            this.main1 = new UserControl0.main();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 540);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 12);
            this.label1.TabIndex = 8;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(279, 540);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 12);
            this.label2.TabIndex = 9;
            this.label2.Text = "label2";
            // 
            // game_pause1
            // 
            this.game_pause1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.game_pause1.Location = new System.Drawing.Point(324, 324);
            this.game_pause1.Name = "game_pause1";
            this.game_pause1.Size = new System.Drawing.Size(150, 150);
            this.game_pause1.TabIndex = 7;
            // 
            // game_over1
            // 
            this.game_over1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.game_over1.Location = new System.Drawing.Point(168, 324);
            this.game_over1.Name = "game_over1";
            this.game_over1.Size = new System.Drawing.Size(150, 150);
            this.game_over1.TabIndex = 6;
            // 
            // game_success1
            // 
            this.game_success1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.game_success1.Location = new System.Drawing.Point(12, 324);
            this.game_success1.Name = "game_success1";
            this.game_success1.Size = new System.Drawing.Size(150, 150);
            this.game_success1.TabIndex = 5;
            // 
            // stage_level1
            // 
            this.stage_level1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.stage_level1.Location = new System.Drawing.Point(324, 168);
            this.stage_level1.Name = "stage_level1";
            this.stage_level1.Size = new System.Drawing.Size(150, 150);
            this.stage_level1.TabIndex = 4;
            // 
            // select_level1
            // 
            this.select_level1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.select_level1.Location = new System.Drawing.Point(168, 168);
            this.select_level1.Name = "select_level1";
            this.select_level1.Size = new System.Drawing.Size(150, 150);
            this.select_level1.TabIndex = 3;
            // 
            // select_stage1
            // 
            this.select_stage1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.select_stage1.Location = new System.Drawing.Point(12, 168);
            this.select_stage1.Name = "select_stage1";
            this.select_stage1.Size = new System.Drawing.Size(150, 150);
            this.select_stage1.TabIndex = 2;
            // 
            // how_to_play1
            // 
            this.how_to_play1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.how_to_play1.Location = new System.Drawing.Point(168, 12);
            this.how_to_play1.Name = "how_to_play1";
            this.how_to_play1.Size = new System.Drawing.Size(150, 150);
            this.how_to_play1.TabIndex = 1;
            // 
            // main1
            // 
            this.main1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.main1.Location = new System.Drawing.Point(12, 12);
            this.main1.Name = "main1";
            this.main1.Size = new System.Drawing.Size(150, 150);
            this.main1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(435, 540);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 12);
            this.label3.TabIndex = 10;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(606, 540);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 12);
            this.label4.TabIndex = 11;
            this.label4.Text = "label4";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.game_pause1);
            this.Controls.Add(this.game_over1);
            this.Controls.Add(this.game_success1);
            this.Controls.Add(this.stage_level1);
            this.Controls.Add(this.select_level1);
            this.Controls.Add(this.select_stage1);
            this.Controls.Add(this.how_to_play1);
            this.Controls.Add(this.main1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public main main1;
        public how_to_play how_to_play1;
        public select_stage select_stage1;
        public select_level select_level1;
        public stage_level stage_level1;
        public game_success game_success1;
        public game_over game_over1;
        public game_pause game_pause1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}


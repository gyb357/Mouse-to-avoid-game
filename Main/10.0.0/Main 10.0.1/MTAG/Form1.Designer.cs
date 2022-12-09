namespace MTAG
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.game_pause1 = new MTAG.game_pause();
            this.game_over1 = new MTAG.game_over();
            this.game_success1 = new MTAG.game_success();
            this.stage_level1 = new MTAG.stage_level();
            this.select_level1 = new MTAG.select_level();
            this.select_stage1 = new MTAG.select_stage();
            this.how_to_play1 = new MTAG.how_to_play();
            this.main1 = new MTAG.main();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 579);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 12);
            this.label1.TabIndex = 8;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(314, 579);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 12);
            this.label2.TabIndex = 9;
            this.label2.Text = "label2";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(414, 579);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 12);
            this.label3.TabIndex = 10;
            this.label3.Text = "label3";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(514, 579);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 12);
            this.label4.TabIndex = 11;
            this.label4.Text = "label4";
            this.label4.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(618, 579);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 12);
            this.label5.TabIndex = 12;
            this.label5.Text = "label5";
            this.label5.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(715, 579);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 12);
            this.label6.TabIndex = 13;
            this.label6.Text = "label6";
            this.label6.Visible = false;
            // 
            // game_pause1
            // 
            this.game_pause1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.game_pause1.Location = new System.Drawing.Point(216, 418);
            this.game_pause1.Margin = new System.Windows.Forms.Padding(1);
            this.game_pause1.Name = "game_pause1";
            this.game_pause1.Size = new System.Drawing.Size(100, 100);
            this.game_pause1.TabIndex = 7;
            // 
            // game_over1
            // 
            this.game_over1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.game_over1.Location = new System.Drawing.Point(114, 418);
            this.game_over1.Margin = new System.Windows.Forms.Padding(1);
            this.game_over1.Name = "game_over1";
            this.game_over1.Size = new System.Drawing.Size(100, 100);
            this.game_over1.TabIndex = 6;
            // 
            // game_success1
            // 
            this.game_success1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.game_success1.Location = new System.Drawing.Point(12, 418);
            this.game_success1.Margin = new System.Windows.Forms.Padding(1);
            this.game_success1.Name = "game_success1";
            this.game_success1.Size = new System.Drawing.Size(100, 100);
            this.game_success1.TabIndex = 5;
            // 
            // stage_level1
            // 
            this.stage_level1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.stage_level1.Location = new System.Drawing.Point(12, 316);
            this.stage_level1.Margin = new System.Windows.Forms.Padding(1);
            this.stage_level1.Name = "stage_level1";
            this.stage_level1.Size = new System.Drawing.Size(100, 100);
            this.stage_level1.TabIndex = 4;
            // 
            // select_level1
            // 
            this.select_level1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.select_level1.Location = new System.Drawing.Point(114, 214);
            this.select_level1.Margin = new System.Windows.Forms.Padding(1);
            this.select_level1.Name = "select_level1";
            this.select_level1.Size = new System.Drawing.Size(100, 100);
            this.select_level1.TabIndex = 3;
            // 
            // select_stage1
            // 
            this.select_stage1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.select_stage1.Location = new System.Drawing.Point(12, 214);
            this.select_stage1.Margin = new System.Windows.Forms.Padding(1);
            this.select_stage1.Name = "select_stage1";
            this.select_stage1.Size = new System.Drawing.Size(100, 100);
            this.select_stage1.TabIndex = 2;
            // 
            // how_to_play1
            // 
            this.how_to_play1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.how_to_play1.Location = new System.Drawing.Point(12, 112);
            this.how_to_play1.Margin = new System.Windows.Forms.Padding(1);
            this.how_to_play1.Name = "how_to_play1";
            this.how_to_play1.Size = new System.Drawing.Size(100, 100);
            this.how_to_play1.TabIndex = 1;
            // 
            // main1
            // 
            this.main1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.main1.Location = new System.Drawing.Point(12, 10);
            this.main1.Margin = new System.Windows.Forms.Padding(1);
            this.main1.Name = "main1";
            this.main1.Size = new System.Drawing.Size(100, 100);
            this.main1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Deactivate += new System.EventHandler(this.Form1_Deactivate);
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
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}


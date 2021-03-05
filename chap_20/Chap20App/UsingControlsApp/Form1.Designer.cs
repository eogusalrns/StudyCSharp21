
namespace UsingControlsApp
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
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TrackBar_ProgressBar = new System.Windows.Forms.GroupBox();
            this.TrB1 = new System.Windows.Forms.TrackBar();
            this.PrG1 = new System.Windows.Forms.ProgressBar();
            this.groupBox1.SuspendLayout();
            this.TrackBar_ProgressBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrB1)).BeginInit();
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(133, 41);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(86, 16);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(142, 64);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(86, 16);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "checkBox2";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(6, 37);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 20);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(18, 62);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 21);
            this.textBox1.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Location = new System.Drawing.Point(28, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(256, 112);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // TrackBar_ProgressBar
            // 
            this.TrackBar_ProgressBar.Controls.Add(this.PrG1);
            this.TrackBar_ProgressBar.Controls.Add(this.TrB1);
            this.TrackBar_ProgressBar.Location = new System.Drawing.Point(28, 162);
            this.TrackBar_ProgressBar.Name = "TrackBar_ProgressBar";
            this.TrackBar_ProgressBar.Size = new System.Drawing.Size(256, 133);
            this.TrackBar_ProgressBar.TabIndex = 5;
            this.TrackBar_ProgressBar.TabStop = false;
            this.TrackBar_ProgressBar.Text = "groupBox2";
            // 
            // TrB1
            // 
            this.TrB1.Location = new System.Drawing.Point(18, 30);
            this.TrB1.Maximum = 20;
            this.TrB1.Name = "TrB1";
            this.TrB1.Size = new System.Drawing.Size(219, 45);
            this.TrB1.TabIndex = 0;
            this.TrB1.Scroll += new System.EventHandler(this.TrB1_Scroll);
            // 
            // PrG1
            // 
            this.PrG1.Location = new System.Drawing.Point(18, 97);
            this.PrG1.Maximum = 20;
            this.PrG1.Name = "PrG1";
            this.PrG1.Size = new System.Drawing.Size(219, 23);
            this.PrG1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 411);
            this.Controls.Add(this.TrackBar_ProgressBar);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.TrackBar_ProgressBar.ResumeLayout(false);
            this.TrackBar_ProgressBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrB1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox TrackBar_ProgressBar;
        private System.Windows.Forms.ProgressBar PrG1;
        private System.Windows.Forms.TrackBar TrB1;
    }
}


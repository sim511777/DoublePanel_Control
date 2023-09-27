namespace DoublePanel_example {
    partial class Form1 {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent() {
            this.doublePanel1 = new DoublePanel.DoublePanel();
            this.doublePanel2 = new DoublePanel.DoublePanel();
            this.button1 = new System.Windows.Forms.Button();
            this.doublePanel1.InnerPanel1.SuspendLayout();
            this.doublePanel1.SuspendLayout();
            this.doublePanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // doublePanel1
            // 
            this.doublePanel1.BackColor = System.Drawing.Color.Coral;
            this.doublePanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            // 
            // doublePanel1.InnerPanel1
            // 
            this.doublePanel1.InnerPanel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.doublePanel1.InnerPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.doublePanel1.InnerPanel1.Controls.Add(this.button1);
            this.doublePanel1.InnerPanel1.Location = new System.Drawing.Point(23, 50);
            this.doublePanel1.InnerPanel1.Name = "InnerPanel1";
            this.doublePanel1.InnerPanel1.Size = new System.Drawing.Size(50, 50);
            this.doublePanel1.InnerPanel1.TabIndex = 0;
            // 
            // doublePanel1.InnerPanel2
            // 
            this.doublePanel1.InnerPanel2.BackColor = System.Drawing.Color.Cyan;
            this.doublePanel1.InnerPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.doublePanel1.InnerPanel2.Location = new System.Drawing.Point(126, 42);
            this.doublePanel1.InnerPanel2.Name = "InnerPanel2";
            this.doublePanel1.InnerPanel2.Size = new System.Drawing.Size(50, 50);
            this.doublePanel1.InnerPanel2.TabIndex = 1;
            this.doublePanel1.Location = new System.Drawing.Point(86, 63);
            this.doublePanel1.Name = "doublePanel1";
            this.doublePanel1.Size = new System.Drawing.Size(265, 175);
            this.doublePanel1.TabIndex = 0;
            // 
            // doublePanel2
            // 
            this.doublePanel2.BackColor = System.Drawing.Color.Coral;
            this.doublePanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            // 
            // doublePanel2.InnerPanel1
            // 
            this.doublePanel2.InnerPanel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.doublePanel2.InnerPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.doublePanel2.InnerPanel1.Location = new System.Drawing.Point(23, 50);
            this.doublePanel2.InnerPanel1.Name = "InnerPanel1";
            this.doublePanel2.InnerPanel1.Size = new System.Drawing.Size(50, 50);
            this.doublePanel2.InnerPanel1.TabIndex = 0;
            // 
            // doublePanel2.InnerPanel2
            // 
            this.doublePanel2.InnerPanel2.BackColor = System.Drawing.Color.Cyan;
            this.doublePanel2.InnerPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.doublePanel2.InnerPanel2.Location = new System.Drawing.Point(126, 42);
            this.doublePanel2.InnerPanel2.Name = "InnerPanel2";
            this.doublePanel2.InnerPanel2.Size = new System.Drawing.Size(50, 50);
            this.doublePanel2.InnerPanel2.TabIndex = 1;
            this.doublePanel2.Location = new System.Drawing.Point(386, 63);
            this.doublePanel2.Name = "doublePanel2";
            this.doublePanel2.Size = new System.Drawing.Size(265, 175);
            this.doublePanel2.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(48, 48);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.doublePanel2);
            this.Controls.Add(this.doublePanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.doublePanel1.InnerPanel1.ResumeLayout(false);
            this.doublePanel1.ResumeLayout(false);
            this.doublePanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DoublePanel.DoublePanel doublePanel1;
        private DoublePanel.DoublePanel doublePanel2;
        private System.Windows.Forms.Button button1;
    }
}


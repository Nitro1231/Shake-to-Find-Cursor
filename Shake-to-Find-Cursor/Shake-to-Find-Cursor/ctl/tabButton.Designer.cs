namespace Shake_to_Find_Cursor.ctl
{
    partial class tabButton
    {
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

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent() {
            this.BG = new System.Windows.Forms.Panel();
            this.textLabel = new System.Windows.Forms.Label();
            this.icon = new System.Windows.Forms.PictureBox();
            this.BG.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icon)).BeginInit();
            this.SuspendLayout();
            // 
            // BG
            // 
            this.BG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(203)))), ((int)(((byte)(196)))));
            this.BG.Controls.Add(this.textLabel);
            this.BG.Controls.Add(this.icon);
            this.BG.Location = new System.Drawing.Point(2, 2);
            this.BG.Name = "BG";
            this.BG.Size = new System.Drawing.Size(36, 36);
            this.BG.TabIndex = 0;
            this.BG.Click += new System.EventHandler(this.BG_Click);
            // 
            // textLabel
            // 
            this.textLabel.AutoSize = true;
            this.textLabel.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textLabel.ForeColor = System.Drawing.Color.White;
            this.textLabel.Location = new System.Drawing.Point(40, 2);
            this.textLabel.Name = "textLabel";
            this.textLabel.Size = new System.Drawing.Size(47, 26);
            this.textLabel.TabIndex = 1;
            this.textLabel.Text = "text";
            // 
            // icon
            // 
            this.icon.Location = new System.Drawing.Point(2, 2);
            this.icon.Name = "icon";
            this.icon.Size = new System.Drawing.Size(32, 32);
            this.icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.icon.TabIndex = 0;
            this.icon.TabStop = false;
            this.icon.Click += new System.EventHandler(this.BG_Click);
            // 
            // tabButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BG);
            this.Name = "tabButton";
            this.Size = new System.Drawing.Size(40, 40);
            this.Resize += new System.EventHandler(this.TabButton_Resize);
            this.BG.ResumeLayout(false);
            this.BG.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel BG;
        private System.Windows.Forms.Label textLabel;
        private System.Windows.Forms.PictureBox icon;
    }
}

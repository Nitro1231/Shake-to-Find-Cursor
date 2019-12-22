namespace Shake_to_Find_Cursor {
    partial class Cursor {
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
            this.cursorBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.cursorBox)).BeginInit();
            this.SuspendLayout();
            // 
            // cursorBox
            // 
            this.cursorBox.Image = global::Shake_to_Find_Cursor.Properties.Resources.Cursor;
            this.cursorBox.Location = new System.Drawing.Point(0, 0);
            this.cursorBox.Name = "cursorBox";
            this.cursorBox.Size = new System.Drawing.Size(80, 80);
            this.cursorBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cursorBox.TabIndex = 0;
            this.cursorBox.TabStop = false;
            // 
            // Cursor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(80, 80);
            this.Controls.Add(this.cursorBox);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Cursor";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Shake to Find Cursor";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Load += new System.EventHandler(this.Cursor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cursorBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox cursorBox;
    }
}


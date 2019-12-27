namespace Shake_to_Find_Cursor
{
    partial class CursorForm
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

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.EventHandler = new System.Windows.Forms.Timer(this.components);
            this.MouseFollower = new System.Windows.Forms.Timer(this.components);
            this.CursorBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.CursorBox)).BeginInit();
            this.SuspendLayout();
            // 
            // EventHandler
            // 
            this.EventHandler.Enabled = true;
            this.EventHandler.Interval = 150;
            this.EventHandler.Tick += new System.EventHandler(this.EventHandler_Tick);
            // 
            // MouseFollower
            // 
            this.MouseFollower.Interval = 10;
            this.MouseFollower.Tick += new System.EventHandler(this.MouseFollower_Tick);
            // 
            // CursorBox
            // 
            this.CursorBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CursorBox.Image = global::Shake_to_Find_Cursor.Properties.Resources.Cursor;
            this.CursorBox.Location = new System.Drawing.Point(0, 0);
            this.CursorBox.Name = "CursorBox";
            this.CursorBox.Size = new System.Drawing.Size(32, 32);
            this.CursorBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CursorBox.TabIndex = 0;
            this.CursorBox.TabStop = false;
            this.CursorBox.MouseEnter += new System.EventHandler(this.CursorBox_MouseEnter);
            this.CursorBox.MouseLeave += new System.EventHandler(this.CursorBox_MouseLeave);
            this.CursorBox.MouseHover += new System.EventHandler(this.CursorBox_MouseHover);
            // 
            // CursorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(60, 60);
            this.Controls.Add(this.CursorBox);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CursorForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Cursor";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            ((System.ComponentModel.ISupportInitialize)(this.CursorBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox CursorBox;
        private System.Windows.Forms.Timer EventHandler;
        private System.Windows.Forms.Timer MouseFollower;
    }
}


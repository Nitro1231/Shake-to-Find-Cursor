namespace Shake_to_Find_Cursor
{
    partial class Monitor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.Handler = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.testTimer = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.topPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.min = new System.Windows.Forms.Panel();
            this.close = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.topPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Handler
            // 
            this.Handler.Enabled = true;
            this.Handler.Interval = 10;
            this.Handler.Tick += new System.EventHandler(this.Handler_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mouse Position";
            // 
            // testTimer
            // 
            this.testTimer.Enabled = true;
            this.testTimer.Interval = 150;
            this.testTimer.Tick += new System.EventHandler(this.TestTimer_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "Status";
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.topPanel.Controls.Add(this.min);
            this.topPanel.Controls.Add(this.close);
            this.topPanel.Controls.Add(this.label3);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(701, 24);
            this.topPanel.TabIndex = 2;
            this.topPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ctlMouseMove);
            // 
            // min
            // 
            this.min.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.min.Location = new System.Drawing.Point(4, 4);
            this.min.Margin = new System.Windows.Forms.Padding(4, 4, 2, 0);
            this.min.Name = "min";
            this.min.Size = new System.Drawing.Size(16, 16);
            this.min.TabIndex = 4;
            // 
            // close
            // 
            this.close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(159)))), ((int)(((byte)(31)))));
            this.close.Location = new System.Drawing.Point(24, 4);
            this.close.Margin = new System.Windows.Forms.Padding(2, 4, 0, 0);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(16, 16);
            this.close.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 6);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 6, 3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "Setting";
            // 
            // tabPanel
            // 
            this.tabPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabPanel.Location = new System.Drawing.Point(0, 24);
            this.tabPanel.Name = "tabPanel";
            this.tabPanel.Size = new System.Drawing.Size(701, 44);
            this.tabPanel.TabIndex = 4;
            this.tabPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ctlMouseMove);
            // 
            // Monitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(701, 370);
            this.Controls.Add(this.tabPanel);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Monitor";
            this.Text = "Monitor";
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ctlMouseMove);
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.Timer Handler;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer testTimer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel topPanel;
        private System.Windows.Forms.Panel min;
        private System.Windows.Forms.Panel close;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.FlowLayoutPanel tabPanel;
    }
}
﻿using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace Shake_to_Find_Cursor.ctl {
    public partial class tabButton : UserControl {
        private int w = 0;
        private bool selected = false;
        public tabButton(Image img, string text, bool select) {
            InitializeComponent();
            Utils.smoothBorder(BG, BG.Height);
            Utils.smoothBorder(icon, icon.Height);
            textLabel.Text = text;
            textLabel.Location = new Point(icon.Left + icon.Width + 4, BG.Height / 2 - textLabel.Height / 2);
            w = BG.Left + textLabel.Left + textLabel.Width + 6;
            changeTo(select);
        }

        private void TabButton_Resize(object sender, EventArgs e) {
            BG.Width = Width - 2;
            Utils.smoothBorder(BG, BG.Height);
            Refresh();
        }

        public void changeTo(bool select) {
            selected = select;
            int a = w - Width, b = Width - Height;
            if (select) {
                while (Width <= w) {
                    Width += 4;
                    Thread.Sleep(2);
                }
            } else {
                while(Width >= Height) {
                    Width -= 4;
                    Thread.Sleep(2);
                }
            }
        }

        public bool getSelected() { return selected; }
        private void BG_Click(object sender, EventArgs e) {
            Monitor.closeTab();
            changeTo(true);
            CursorForm.mt.closeAnimation(true);
        }
    }
}

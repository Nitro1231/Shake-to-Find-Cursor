using System;
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
            icon.Image = img;
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
            if (select) {
                while (Setting.animation && Width <= w - Setting.animationSpeed) {
                    Width += Setting.animationSpeed;
                    Thread.Sleep(2);
                }
                Width = w;
            } else {
                while(Setting.animation && Width >= Height + Setting.animationSpeed) {
                    Width -= Setting.animationSpeed;
                    Thread.Sleep(2);
                }
                Width = Height;
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

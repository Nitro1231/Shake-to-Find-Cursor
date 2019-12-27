using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shake_to_Find_Cursor {
    public partial class CursorForm : Form {
        private int minRange = 100, maxRange = 500, trigger = 3;
        private int x, y, x1, y1, sumX, sumY, count;
        private bool checkX, checkY;
        public CursorForm() {
            InitializeComponent();
            Monitor m = new Monitor();
            m.Show();
            x = MousePosition.X;
            y = MousePosition.Y;
        }

        private void EventHandler_Tick(object sender, EventArgs e) {
            x1 = MousePosition.X;
            y1 = MousePosition.Y;

            sumX = Math.Abs(x - x1);
            sumY = Math.Abs(y - y1);

            if (sumX > minRange && sumX < maxRange) checkX = true; else checkX = false;
            if (sumY > minRange && sumY < maxRange) checkY = true; else checkY = false;
            if (checkX && checkY) count++; else count = 0;
            if (count >= trigger) {
                MouseFollower.Enabled = true;
                Opacity = 1;
                while (CursorBox.Width <= 60) {
                    CursorBox.Width++;
                    CursorBox.Height++;
                    Location = new Point(MousePosition.X - 5, MousePosition.Y - 5);
                    Refresh();
                    System.Threading.Thread.Sleep(10);
                }
                while (CursorBox.Width >= 32) {
                    CursorBox.Width--;
                    CursorBox.Height--;
                    Location = new Point(MousePosition.X - 5, MousePosition.Y - 5);
                    Refresh();
                    System.Threading.Thread.Sleep(10);
                }
                Opacity = 0;
                MouseFollower.Enabled = false;
                Location = new Point(0, 0);
                count = 0;
            }

            x = MousePosition.X;
            y = MousePosition.Y;
        }

        private void MouseFollower_Tick(object sender, EventArgs e) { Location = new Point(MousePosition.X - 12, MousePosition.Y- 8); }

        private void CursorBox_MouseEnter(object sender, EventArgs e) { Cursor.Hide(); }
        private void CursorBox_MouseHover(object sender, EventArgs e) { Cursor.Hide(); }
        private void CursorBox_MouseLeave(object sender, EventArgs e) { Cursor.Show(); }
    }
}

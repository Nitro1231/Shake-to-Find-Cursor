using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace Shake_to_Find_Cursor {
    public partial class CursorForm : Form {
        private int minRange = 30, maxRange = 150, trigger = 3;
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
                Cursor.Hide();
                Opacity = 1;
                while (CursorBox.Width <= 80) {
                    CursorBox.Width++;
                    CursorBox.Height++;
                    Location = new Point(MousePosition.X - (15 + 15 * CursorBox.Width / 80), MousePosition.Y - (10 + 10 * CursorBox.Height / 80));
                    Refresh();
                    Thread.Sleep(10);
                }
                while (CursorBox.Width >= 32) {
                    CursorBox.Width--;
                    CursorBox.Height--;
                    Location = new Point(MousePosition.X - (15 + 15 * CursorBox.Width / 80), MousePosition.Y - (10 + 10 * CursorBox.Height / 80));
                    Refresh();
                    Thread.Sleep(10);
                }
                Cursor.Show();
                Opacity = 0;
                Location = new Point(0, 0);
                count = 0;
            }

            x = MousePosition.X;
            y = MousePosition.Y;
        }
    }
}

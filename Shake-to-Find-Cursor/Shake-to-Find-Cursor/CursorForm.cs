using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace Shake_to_Find_Cursor {
    public partial class CursorForm : Form {
        public bool functionEnabled = true;
        public int maxSize = 80, minRange = 30, maxRange = 150, trigger = 3;
        public int x, y, x1, y1, sumX, sumY, count;
        public bool checkX, checkY;

        public CursorForm() {
            InitializeComponent();
            Location = new Point(0, 0);
            Opacity = 0;
            x = MousePosition.X;
            y = MousePosition.Y;

            Icon.ContextMenu = setMenu();
        }

        private ContextMenu setMenu() {
            ContextMenu ctx = new ContextMenu();
            if (functionEnabled)
                ctx.MenuItems.Add(new MenuItem("Disable", funcDisable));
            else
                ctx.MenuItems.Add(new MenuItem("Enable", funcEnable));
            ctx.MenuItems.Add(new MenuItem("Setting"));
            ctx.MenuItems.Add(new MenuItem("Exit", new EventHandler((sender, ex) => Close())));
            return ctx;
        } 

        private void funcDisable(object sender, EventArgs e) {
            EventHandler.Enabled = false;
            functionEnabled = false;
            Icon.ContextMenu = setMenu();
        }

        private void funcEnable(object sender, EventArgs e) {
            EventHandler.Enabled = true;
            functionEnabled = true;
            Icon.ContextMenu = setMenu();
        }

        private void CursorForm_FormClosing(object sender, FormClosingEventArgs e) {
            Icon.Visible = false;
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
                while (CursorBox.Width <= maxSize) {
                    CursorBox.Width++;
                    CursorBox.Height++;
                    Location = new Point(MousePosition.X - (15 + 15 * CursorBox.Width / maxSize), MousePosition.Y - (10 + 10 * CursorBox.Height / maxSize));
                    Refresh();
                    Thread.Sleep(10);
                }
                while (CursorBox.Width >= 32) {
                    CursorBox.Width--;
                    CursorBox.Height--;
                    Location = new Point(MousePosition.X - (15 + 15 * CursorBox.Width / maxSize), MousePosition.Y - (10 + 10 * CursorBox.Height / maxSize));
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

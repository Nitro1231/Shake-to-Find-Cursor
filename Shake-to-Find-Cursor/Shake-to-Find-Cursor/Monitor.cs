using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shake_to_Find_Cursor
{
    public partial class Monitor : Form
    {
        public static ctl.tabButton monitorTab, settingTab, infoTab;
        public Monitor() {
            InitializeComponent();
            Utils.smoothBorder(this, 10);
            Utils.smoothBorder(close, close.Width);
            Utils.smoothBorder(min, min.Width);
            monitorTab = new ctl.tabButton(Properties.Resources.Cursor, "Monitor", true);
            settingTab = new ctl.tabButton(Properties.Resources.Cursor, "Setting", false);
            infoTab = new ctl.tabButton(Properties.Resources.Cursor, "Information", false);
            tabPanel.Controls.Add(monitorTab);
            tabPanel.Controls.Add(settingTab);
            tabPanel.Controls.Add(infoTab);
        }

        public static void closeTab() {
            monitorTab.changeTo(false);
            settingTab.changeTo(false);
            infoTab.changeTo(false);
            CursorForm.mt.closeAnimation(false);
        }

        public void closeAnimation(bool close) {
            if (close) {
                while (CursorForm.mt.Height <= 350) {
                    CursorForm.mt.Height += 10;
                    Thread.Sleep(2);
                    CursorForm.mt.Refresh();
                }
            } else {
                while(CursorForm.mt.Height >= CursorForm.mt.tabPanel.Height + CursorForm.mt.tabPanel.Top + 4) {
                    CursorForm.mt.Height -= 10;
                    Thread.Sleep(2);
                    CursorForm.mt.Refresh();
                }
            }
        }

        private void Handler_Tick(object sender, EventArgs e) {
            label1.Text = $"Mouse Position \nX: {MousePosition.X}\nY: {MousePosition.Y}";
        }

        private int minRange = 100, maxRange = 500;
        private int x, y, x1, y1, sumX, sumY, count = 0;
        private bool checkX, checkY;
        private void TestTimer_Tick(object sender, EventArgs e) {
            x1 = MousePosition.X;
            y1 = MousePosition.Y;

            sumX = Math.Abs(x - x1);
            sumY = Math.Abs(y - y1);

            if (sumX > minRange && sumX < maxRange) checkX = true; else checkX = false;
            if (sumY > minRange && sumY < maxRange) checkY = true; else checkY = false;
            if (checkX && checkY) count++; else count = 0;

            label2.Text = $"x: {x}\ny: {y}\nx1: {x1}\ny1: {y1}\nsumX: {sumX}\nsumY: {sumY}\ncX: {checkX}\ncY: {checkY}\nc:{count}";

            x = MousePosition.X;
            y = MousePosition.Y;
        }

        private void close_Click(object sender, EventArgs e) { Close(); }
        private void Min_Click(object sender, EventArgs e) { WindowState = FormWindowState.Minimized; }
        private void ctlMouseMove(object sender, MouseEventArgs e) { Utils.mouseMove(Handle); }
        private void Monitor_Resize(object sender, EventArgs e) {
            Utils.smoothBorder(this, 10);
            Refresh();
        }
    }
}

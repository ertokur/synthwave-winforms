using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace synthwave_winforms {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e) {
            Graphics g = e.Graphics;
            Random rand = new Random();
            g.Clear(Color.Black);

            //Звёзды
            for (int i = 0; i < 80; i++) {
                g.FillEllipse(new SolidBrush(Color.White), rand.Next(800), rand.Next(290), 2, 2);
            }

            //Градиeнты
            LinearGradientBrush linGrBrush = new LinearGradientBrush(
                new Point(0, 50),
                new Point(0, 225),
                Color.FromArgb(255, 255, 211, 25),
                Color.FromArgb(255, 140, 30, 255));

            LinearGradientBrush linGrBrush2 = new LinearGradientBrush(
                new Point(0, 250),
                new Point(0, 300),
                Color.FromArgb(255, 0, 0, 0),
                Color.FromArgb(255, 140, 30, 255));

            //Солнце
            g.FillEllipse(linGrBrush, 310, 50, 175, 175);

            //Градиент под зданиями
            g.FillRectangle(linGrBrush2, 0, 250, 800, 50);

            //Здания
            for (int i = 0; i < 100; i++) {
                g.FillRectangle(new SolidBrush(Color.Black), rand.Next(800), rand.Next(40) + 260, rand.Next(10) + 10, rand.Next(30) + 40);
            }

            //Линии
            g.FillRectangle(new SolidBrush(Color.Black), 0, 300, 800, 300);

            for (int i = 0; i < 30; i++) {
                g.DrawLine(new Pen(Brushes.Purple, 1), 0, 300 + (i * 3) + (i * i), 800, 300 + (i * 3) + (i * i));
            }

            g.DrawLine(new Pen(Brushes.Purple, 1), 400, 300, 400, 600);

            for (int i = 1; i < 40; i++) {
                g.DrawLine(new Pen(Brushes.Purple, 1), i * 10 + 400, 300, i * 80 + 400, 600);
            }

            for (int i = 40; i > 0; i--) {
                g.DrawLine(new Pen(Brushes.Purple, 1), 400 - i * 10, 300, 400 - i * 80, 600);
            }
        }

        private void Form1_Load(object sender, EventArgs e) {
            this.Width = 800;
            this.Height = 600;
            this.Text = "Synthwave";
        }
    }
}

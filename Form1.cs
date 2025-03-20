using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Управляемое_движение_KeyDown
{ 
    public partial class Form1 : Form
    {
        private Image Bit;
        int x = 300, y = 100, w = 100, h = 100;
        Graphics g;
        Rectangle rct;
        int ScreenW, ScreenH;
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            g.Clear(Color.White);
            g.DrawImage(Bit, x, y, w, h);
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            rct.X = x;
            rct.Y = y;
            rct.Width = w;
            rct.Height = h;
            Invalidate(rct);
            //Обработка кодов клавиш
            if (e.KeyCode == Keys.Down && rct.Location.Y + h + 40 <= ScreenH) y += 10;
            if (e.KeyCode == Keys.Up && rct.Location.Y + -10 >= 0) y -= 10;
            if (e.KeyCode == Keys.Left && rct.Location.X - 10 >= 0) x -= 10;
            if (e.KeyCode == Keys.Right && rct.Location.X + w +20 <= ScreenW) x += 10;
            g.DrawImage(Bit, x, y, w, h);

        }
        public Form1()
        {
            InitializeComponent();            
            g = this.CreateGraphics();
            Bit = new Bitmap("F://Programming/Other users/Dima/C#/Управляемое_движение_KeyDown/image.png");
            ScreenW = this.Width;
            ScreenH = this.Height;
        }
    }
}

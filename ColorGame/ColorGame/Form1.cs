using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColorGame
{
    public partial class Form1 : Form
    {
        private const int ChooseColorSize = 30;

        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            base.OnPaint(e);
            using (Graphics g = e.Graphics)
            {
                DrowChooseBox(g, new Point(0, 0), Color.Black);
            }
        }

        private void DrowChooseBox(Graphics g, Point p, Color color)
        {
            Pen blackpen = new Pen(color, 3);

            var brush = new SolidBrush(color);

            var rectangle = new Rectangle(p, new Size(ChooseColorSize, ChooseColorSize) );

            g.DrawRectangle(blackpen, rectangle);
            g.FillRectangle(brush, rectangle);
        
        }

        private void numericUpDownColors_ValueChanged(object sender, EventArgs e)
        {
            //clear

            //drow
        }
    }
}

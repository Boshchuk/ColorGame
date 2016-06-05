using System.Drawing;

namespace ColorGame
{
    public static class DrawHelper
    {
        public static void DrowBox(Graphics g, Point p, Color color, int size)
        {
            var blackpen = new Pen(color, 0);

            var brush = new SolidBrush(color);

            var rectangle = new Rectangle(p, new Size(size, size));

            g.DrawRectangle(blackpen, rectangle);
            g.FillRectangle(brush, rectangle);

        }
    }
}

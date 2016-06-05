using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GamePlayCore;

namespace ColorGame
{
    public partial class FormGameScreen : Form
    {
        private Field _field;

        public FormGameScreen(int width, int height, int colorsCount)
        {
            InitializeComponent();

            _field = new Field(width, height, colorsCount);

            panel1.Refresh();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

            using (Graphics g = e.Graphics)
            {
           
                var size = 20;
                g.Clear(Color.AliceBlue);
                for (int i = 0; i < _field.Height; i++)
                {
                    for (int j = 0; j < _field.Width; j++)
                    {
                        var point = new Point(j * size+20, i * size+20);

                        DrawHelper.DrowBox(g, point, _field.Grid[i, j].Color, size);
                    }
                }
            }
          
        }
    }
}

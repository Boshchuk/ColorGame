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

        private void panelAvalible1_Paint(object sender, PaintEventArgs e)
        {
            var list = _field.GetPlayer_1_NearestElementsBrute();

            var colors = list.GroupBy(element => element.Color).ToList();
            using (Graphics g = e.Graphics)
            {
                for (var i = 0; i < colors.Count(); i++)
                {
                    var point = new Point(0, i * (30 + 5));
                    DrawHelper.DrowBox(g, point, colors[i].Key, 30);
                }
            }
        }

        private void panel_AvalibleMove_forPlayer_2_Paint(object sender, PaintEventArgs e)
        {
            var list = _field.GetPlayer_2_NearestElementsBrute();

            var colors = list.GroupBy(element => element.Color).ToList();
            using (Graphics g = e.Graphics)
            {
                for (var i = 0; i < colors.Count(); i++)
                {
                    var point = new Point(0, i * (30 + 5));
                    DrawHelper.DrowBox(g, point, colors[i].Key, 30);
                }
            }
        }

        private void player1Moves_Click(object sender, EventArgs e)
        {
            // find index of clicked move
        }
    }
}

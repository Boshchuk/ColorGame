using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using GamePlayCore;

namespace ColorGame
{
    public partial class FormGameScreen : Form
    {
        const int PlayerMoveBoxSize = 30;

        private Field _field;

        public FormGameScreen(int width, int height, int colorsCount)
        {
            InitializeComponent();

            _field = new Field(width, height, colorsCount);

            panelGameFields.Refresh();
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
            var list = _field.GetPlayerNearestElementsBrute(Player.Player1);

            var colors = list.GroupBy(element => element.Color).ToList();
            var count = colors.Count();
            using (Graphics g = e.Graphics)
            {
                for (var i = 0; i < count; i++)
                {
                    var point = new Point(0, i * (PlayerMoveBoxSize + 5));
                    DrawHelper.DrowBox(g, point, colors[i].Key, PlayerMoveBoxSize);
                }
            }
        }

        private void panel_AvalibleMove_forPlayer_2_Paint(object sender, PaintEventArgs e)
        {
            var list = _field.GetPlayerNearestElementsBrute(Player.Player2);

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
            playerMoves_Click(e, Player.Player1);

            panelPlayer1Moves.Refresh();
            panelPlayer2Moves.Refresh();
            panelGameFields.Refresh();
        }

        private void playerMoves_Click(EventArgs e, Player player)
        {
            // find index of clicked move
            var list = _field.GetPlayerNearestElementsBrute(player);

            var colors = list.GroupBy(element => element.Color).ToList();

            var args = e as MouseEventArgs;

            if (args.X > PlayerMoveBoxSize)
            {
                return;
            }

            var index = args.Y / (PlayerMoveBoxSize + 5);

            var addedIndex = (args.Y + 5) / (PlayerMoveBoxSize + 5);

            if (index != addedIndex)
            {
                return;
            }

            var colorToFindStartPosition = colors[index].Key;

            var coloringStartPosition = new List<Element>();

            foreach (var element in list)
            {
                if (element.Color == colorToFindStartPosition)
                {
                    coloringStartPosition.Add(element);
                }
            }
            // TODO: start coloring areas

            PlayerColoringGrid(coloringStartPosition, colorToFindStartPosition, player);

            
        }

        private void PlayerColoringGrid(List<Element> startElements, Color areaColor, Player player)
        {
            var state = PlayerHelper.GetStateForPlayer(player);

            foreach (var element in startElements)
            {
                if (element.Color == areaColor && element.State == FieldState.Neutral)
                {
                    element.Color = AvalibleColors.GetPlayerColor(player);
                    element.State = state;
                }

                var nextItteration = new List<Element>();
                var positionsToCheck = element.NearestPositions();

                foreach (var point in positionsToCheck)
                {
                    if (_field.IsPositionInFeeld(point))
                    {
                        if (_field.Grid[point.Y, point.X].Color == areaColor && _field.Grid[point.Y, point.X].State == FieldState.Neutral)
                        {
                            nextItteration.Add(_field.Grid[point.Y, point.X]);
                        }
                    }
                }

                PlayerColoringGrid(nextItteration, areaColor, player);
            }
        }

        private void panel_Player2_Moves_Click(object sender, EventArgs e)
        {
            playerMoves_Click(e, Player.Player2);

            panelPlayer1Moves.Refresh();
            panelPlayer2Moves.Refresh();
            panelGameFields.Refresh();
        }
    }
}

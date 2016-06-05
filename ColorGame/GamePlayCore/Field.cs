using System.Drawing;

namespace GamePlayCore
{
    public class Field
    {
        public Element[,] Grid { get; set; }

        public int Width { get; set; }
        public int Height { get; set; }

        public Field(int width, int height, int usedColorsCount)
        {
            Width = width;
            Height = height;

            Grid = new Element[Height, Width];
            GenereateColors(usedColorsCount);

            SetUpPlayersStartPoints();
        }

        private void GenereateColors( int usedColorsCount)
        {
            for (int j = 0; j < Height; j++)
            {
                for (int i = 0; i < Width; i++)
                {
                    var color = AvalibleColors.GetRandomColor(usedColorsCount);

                    Grid[j, i] = new Element
                    {
                        Color = color,
                        Point = new Point(i,j),
                        State = FieldState.Neutral
                    };  
                }
            }
        }

        
        private void SetUpPlayersStartPoints()
        {
            Grid[0,0] = new Element()
            {
                Color = AvalibleColors.GetPlayer1Color(),
                Point = new Point(0,0),
                State = FieldState.Player1
            };

            var rightDown = new Point( Width-1, Height-1);

            Grid[rightDown.Y, rightDown.X] = new Element()
            {
                Color = AvalibleColors.GetPlayer2Color(),
                Point = rightDown,
                State = FieldState.Player2
            };
        }

    }
}
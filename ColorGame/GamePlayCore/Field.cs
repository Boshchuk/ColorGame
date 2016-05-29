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
        }

        

        private void GenereateColors( int usedColorsCount)
        {
            for (int j = 0; j < Height; j++)
            {
                for (int i = 0; i < Width; i++)
                {
                    Grid[j, i] = new Element
                    {
                        Color = AvalibelColors.GetRandomColor(usedColorsCount),
                        Point = new Point(i,j)
                    };  
                }
            }
        }

    }
}
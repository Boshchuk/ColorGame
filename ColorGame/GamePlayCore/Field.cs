using System.Drawing;

namespace GamePlayCore
{
    public class Field
    {
        public Element[,] Grid;

        private int _width;
        private int _height;

        public Field(int width, int height, int usedColorsCount)
        {
            _width = width;
            _height = height;

            Grid = new Element[_height, _width];
            GenereateColors(usedColorsCount);
        }

        

        private void GenereateColors( int usedColorsCount)
        {
            for (int j = 0; j < _height; j++)
            {
                for (int i = 0; i < _width; i++)
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
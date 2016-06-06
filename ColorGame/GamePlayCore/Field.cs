using System;
using System.Collections.Generic;
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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="state">Use only p1 or p2 state </param>
        public void GetNearestColorsGroup(FieldState state)
        {
            if (state == FieldState.Neutral)
            {
                throw new ArgumentException("state");
            }


        }

        private List<Element> GetPlayerNearestElementsBrute(FieldState state)
        {
            var list = new List<Element>();
            for (int j = 0; j < Height; j++)
            {
                for (int i = 0; i < Width; i++)
                {
                    if (HasNearestState(Grid[j, i], state))
                    {
                        list.Add(Grid[j, i]);
                    }

                }
            }
            return list;
        }

        public List<Element> GetPlayer_1_NearestElementsBrute()
        {
            return GetPlayerNearestElementsBrute(FieldState.Player1);
        }

        public List<Element> GetPlayer_2_NearestElementsBrute()
        {
            return GetPlayerNearestElementsBrute(FieldState.Player2);
        }

        public bool HasNearestState(Element element, FieldState state)
        {
            if (state == FieldState.Neutral)
            {
                throw new AggregateException("state");
            }

            var positionsToCheck = element.NearestPositions();

            foreach (var point in positionsToCheck)
            {
                if (IsPositionInFeeld(point))
                {
                    if (Grid[point.Y, point.X].State == state)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        private bool IsPositionInFeeld(Point point)
        {
            if (point.X < 0 || point.X >= Width)
            {
                return false;
            }
            if (point.Y < 0 || point.Y >= Height)
            {
                return false;
            }
            return true;
        }
    }

    
}
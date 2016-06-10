using System;
using System.Collections.Generic;
using System.Drawing;

namespace GamePlayCore
{
    public class Field
    {
        private readonly bool _useAllDirections;
        public Element[,] Grid { get; set; }

        public int Width { get; set; }
        public int Height { get; set; }

        public Field(int width, int height, int usedColorsCount, bool useAllDirections)
        {
            _useAllDirections = useAllDirections;
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

        public List<Element> GetPlayerNearestElementsBrute(Player player)
        {
            var state = PlayerHelper.GetStateForPlayer(player);

            var list = new List<Element>();
            for (int j = 0; j < Height; j++)
            {
                for (int i = 0; i < Width; i++)
                {
                    if (HasNearestState(Grid[j, i], state) &&
                        Grid[j, i].State ==FieldState.Neutral)
                    {
                        list.Add(Grid[j, i]);
                    }
                }
            }
            return list;
        }

        public bool HasNearestState(Element element, FieldState state)
        {
            if (state == FieldState.Neutral)
            {
                throw new AggregateException("state");
            }

            var positionsToCheck = element.NearestPositions(_useAllDirections);

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

        public bool IsPositionInFeeld(Point point)
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

        public FieldInfo GetFieldInfo()
        {
            var result = new FieldInfo();
            for (int j = 0; j < Height; j++)
            {
                for (int i = 0; i < Width; i++)
                {
                    switch (Grid[j, i].State)
                    {
                        case FieldState.Neutral:
                            {
                                result.NeutralCount++;
                                break;
                            }

                        case FieldState.Player1:
                            {
                                result.Player1Score++;
                                break;
                            }

                        case FieldState.Player2:
                            {
                                result.Player2Score++;
                                break;
                            }

                        default:
                            throw new ArgumentOutOfRangeException();
                    }
                }
            }

            return result;
        }
    }
}
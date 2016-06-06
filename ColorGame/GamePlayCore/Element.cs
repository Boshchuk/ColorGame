using System;
using System.Collections.Generic;
using System.Drawing;

namespace GamePlayCore
{
    public class Element
    {
        public Point Point { get; set; }

        public Color Color { get; set; }

        public FieldState State { get; set; }

        public Point GetNearestPointPosition(NearstPoint nearstPoint)
        {
            switch (nearstPoint)
            {
                case NearstPoint.Top:
                    {
                        return new Point(Point.X, Point.Y - 1);
                    }
                case NearstPoint.TopLeft:
                    {
                        return new Point(Point.X - 1, Point.Y - 1);
                    }

                case NearstPoint.Left:
                    {
                        return new Point(Point.X - 1, Point.Y);
                    }

                case NearstPoint.BottomLeft:
                {
                        return new Point(Point.X - 1, Point.Y + 1);
                    }
                    
                case NearstPoint.Bottom:
                    { return new Point(Point.X, Point.Y + 1); }
                case NearstPoint.BottomRight:
                    { return new Point(Point.X+ 1, Point.Y + 1); }
                case NearstPoint.Right:
                    return new Point(Point.X + 1, Point.Y);
                case NearstPoint.TopRight:
                    return new Point(Point.X + 1, Point.Y + 1);
                default:
                    throw new ArgumentOutOfRangeException(nameof(nearstPoint), nearstPoint, null);
            }
        }

        public List<Point> NearestPositions()
        {
            var positions = new List<Point>
            {
                GetNearestPointPosition(NearstPoint.Top),
                GetNearestPointPosition(NearstPoint.TopLeft),
                GetNearestPointPosition(NearstPoint.TopRight),
                GetNearestPointPosition(NearstPoint.Bottom),
                GetNearestPointPosition(NearstPoint.BottomLeft),
                GetNearestPointPosition(NearstPoint.BottomRight),
                GetNearestPointPosition(NearstPoint.Left),
                GetNearestPointPosition(NearstPoint.Right)
            };

            return positions;
        }
    }
}

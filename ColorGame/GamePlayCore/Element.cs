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
                    {
                        return new Point(Point.X, Point.Y + 1);
                    }
                case NearstPoint.BottomRight:
                    {
                        return new Point(Point.X + 1, Point.Y + 1);
                    }
                case NearstPoint.Right:
                    {
                        return new Point(Point.X + 1, Point.Y);
                    }

                case NearstPoint.TopRight:
                    {
                        return new Point(Point.X + 1, Point.Y -1);
                    }
            }
            return Point;
        }

        public List<Point> NearestPositions(bool useAllDirections)
        {
            var positions = new List<Point>();
            positions.Add(GetNearestPointPosition(NearstPoint.Top));
            positions.Add(GetNearestPointPosition(NearstPoint.Bottom));
            positions.Add(GetNearestPointPosition(NearstPoint.Left));
            positions.Add(GetNearestPointPosition(NearstPoint.Right));

            if (useAllDirections)
            {
                positions.Add(GetNearestPointPosition(NearstPoint.TopLeft));
                positions.Add(GetNearestPointPosition(NearstPoint.TopRight));
                positions.Add(GetNearestPointPosition(NearstPoint.BottomLeft));
                positions.Add(GetNearestPointPosition(NearstPoint.BottomRight));
            }

            return positions;
        }
    }
}

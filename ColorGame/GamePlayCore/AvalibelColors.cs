using System;
using System.Collections.Generic;
using System.Drawing;

namespace GamePlayCore
{
    public static class AvalibelColors
    {
        public static  Color GetColorByIndex(int index)
        {
            var gameColors = new List<Color>
            {
                Color.Black,
                Color.Aqua,
                Color.Blue,
                Color.BlueViolet,
                Color.Brown,
                Color.Chartreuse,
                Color.CornflowerBlue,
                Color.DarkGreen,
                Color.Red,
                Color.DimGray,
                Color.Lime
            };

            return gameColors[index];
        }

        public static Color GetRandomColor(int max)
        {
            var r = new Random();
            var index = r.Next(max);

            return GetColorByIndex(index);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Drawing;

namespace GamePlayCore
{
    public static class AvalibelColors
    {
        private static readonly Random random = new Random();
        private static readonly object syncLock = new object();

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
            lock (syncLock)
            {
                var index = random.Next(max);

                return GetColorByIndex(index);
            }
      
        }
    }
}
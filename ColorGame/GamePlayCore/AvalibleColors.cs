using System;
using System.Collections.Generic;
using System.Drawing;

namespace GamePlayCore
{
    public static class AvalibleColors
    {
        private static readonly Random Random = new Random();
        private static readonly object SyncLock = new object();

        public static  Color GetColorByIndex(int index)
        {
            var gameColors = new List<Color>
            {
                Color.Black,
                Color.Aqua,
                Color.CadetBlue,
                Color.BlueViolet,
                Color.Brown,
                Color.Chartreuse,
                Color.CornflowerBlue,
                Color.DarkGreen,
                Color.DarkGoldenrod,
                Color.DimGray,
                Color.Lime,
                // reserved for player 1
                Color.Blue,
                // reserved for player 2
                Color.Red,
            };

            return gameColors[index];
        }

        public static Color GetRandomColor(int max)
        {
            lock (SyncLock)
            {
                var index = Random.Next(max);

                return GetColorByIndex(index);
            }
        }

        public static Color GetPlayer1Color()
        {
            // TODO make constatns
            return GetColorByIndex(11);
        }

        public static Color GetPlayer2Color()
        {
            // TODO make constatns
            return GetColorByIndex(12);
        }
    }
}
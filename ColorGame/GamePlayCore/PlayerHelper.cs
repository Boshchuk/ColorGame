using System;
using System.CodeDom;

namespace GamePlayCore
{
    public static class PlayerHelper
    {
        public static FieldState GetStateForPlayer(Player player)
        {
            var state = FieldState.Neutral;
            switch (player)
            {
                case Player.Player1:
                {
                    state = FieldState.Player1;
                    break;
                }

                case Player.Player2:
                {
                    state = FieldState.Player2;
                    break;
                }
               
            }
            return state;
        }
    }
}
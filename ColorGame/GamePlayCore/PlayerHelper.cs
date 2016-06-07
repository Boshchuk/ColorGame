using System;

namespace GamePlayCore
{
    public static class PlayerHelper
    {
        public static FieldState GetStateForPlayer(Player player)
        {
            FieldState state;
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
                default:
                    throw new ArgumentOutOfRangeException(nameof(player), player, null);
            }
            return state;
        }
    }
}
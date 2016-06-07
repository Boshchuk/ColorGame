namespace GamePlayCore
{
    public class StateMachine
    {
        public Player CurrentPlayer { get; set; }

        public StateMachine()
        {
            CurrentPlayer = Player.Player1;
        }

        public void PlayerMoved()
        {
            CurrentPlayer = CurrentPlayer == Player.Player1 ? Player.Player2 : Player.Player1;
        }
        
    }
}
namespace BoardGame.Core.Interfaces
{
    public interface IBoardHole
    {
        public void EnterBall(IBall ball);
        public void ReleaseLastBall();
    }
}
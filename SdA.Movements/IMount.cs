namespace SdA.Movements
{
    public interface IMount
    {
        void Move();

        int MovePoint { get; set; }
    }
}

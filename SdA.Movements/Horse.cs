namespace SdA.Movements
{
    public class Horse : IMount
    {
        public int MovePoint { get; set; }

        public void Move()
        {
            Console.WriteLine("Huhuhu je me déplace de  {0}", this.MovePoint);
        }
    }
}

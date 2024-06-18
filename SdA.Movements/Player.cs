namespace SdA.Movements
{
    public class Player
    {
        public void Ride(IMount mount)
        {
            Console.WriteLine("Je me déplace");
            mount.Move();
        }
    }
}

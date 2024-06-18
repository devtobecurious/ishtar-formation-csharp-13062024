namespace ApprentissagePOO
{
    internal class Bat : Animal, IFlying
    {
        public void Fly()
        {
            Console.WriteLine("Je vole avec des ailes en peau");
        }

        public override void Miam(string food)
        {
            throw new NotImplementedException();
        }
    }
}

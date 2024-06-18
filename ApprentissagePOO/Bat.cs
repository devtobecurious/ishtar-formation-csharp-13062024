namespace ApprentissagePOO
{
    internal class Bat : Animal, IFlying, IUltraSoundEmitter
    {
        public int Emit()
        {
            return 10000;
        }

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

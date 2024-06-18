namespace ApprentissagePOO
{
    internal class Sparrow : Bird
    {
        public override void Sleep()
        {
            Console.WriteLine("je dors en volant");
        }

        public override void Miam(string food)
        {
            Console.WriteLine("Je surfe sur l'eau en mangeant des insectes");
        }

        public override void Fly()
        {
            Console.WriteLine("I'm flying !");
        }
    }
}

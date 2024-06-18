namespace ApprentissagePOO
{
    /// <summary>
    /// Ce que fait mon panda dans un zoo
    /// </summary>
    internal class Panda : Animal
    {
        public override void Miam(string food)
        {
            Console.WriteLine("Je mange des bamboos");
        }

        public override void Sleep()
        {
            Console.WriteLine("Je pose des feuilles de bamboo");
            base.Sleep(); // ici c'est le comportement du parent
            Console.WriteLine("Ah je suis bien !");
        }
    }

    internal class RedPanda : Panda
    {
    }
}

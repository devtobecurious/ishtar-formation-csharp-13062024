namespace ApprentissagePOO
{
    // abstract = contrat de classe
    internal abstract class Animal
    {
        public string Surname;
        public DateTime BirthDay;

        /// <summary>
        /// Fait dormir le panda
        /// </summary>
        public virtual void Sleep()
        {
            Console.WriteLine($"{this.Surname}, Je dors");
        }

        public abstract void Miam(string food);
    }

}

namespace ApprentissagePOO
{
    internal class Animal
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
    }

}

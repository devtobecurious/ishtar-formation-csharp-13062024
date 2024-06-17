namespace ApprentissagePOO
{
    /// <summary>
    /// Ce que fait mon panda dans un zoo
    /// </summary>
    internal class Panda
    {
        public string Surname;
        public DateTime BirthDay;

        /// <summary>
        /// Fait dormir le panda
        /// </summary>
        public void Sleep()
        {
            Console.WriteLine($"{this.Surname}, Je dors");
        }
    }
}

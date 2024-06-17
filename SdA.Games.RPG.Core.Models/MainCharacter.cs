namespace SdA.Games.RPG.Core.Models
{
    public class MainCharacter : Character
    {
        #region Fields
        private Power[] powers;
        #endregion

        #region Constructors
        public MainCharacter(string surname, Power[] powers) : base(surname)
        {
            this.powers = powers;
        }
        #endregion

        #region Public methods
        public override void Attack(Character enemy)
        {
            base.Attack(enemy);
            Console.WriteLine("Je suis le main character");
        }
        #endregion 
    }
}

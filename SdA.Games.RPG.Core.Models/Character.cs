namespace SdA.Games.RPG.Core.Models
{
    public abstract class Character // on ne peut instancier que par les enfants
    {
        #region Fields
        private static Random RANDOM = new Random(); // variable globale appartenant au type Character => présent qu'une seule fois par jeu / application
        private LifePoint lifePoint = new LifePoint() { Value = 100 };
        #endregion

        #region Constructors
        public Character(string surname)
        {
            this.Surname = surname;
        }
        #endregion

        #region Public methods
        /// <summary>
        /// virtual va avec override dans l'enfant
        /// j'autorise l'enfant à modifier mon comportement
        /// </summary>
        /// <param name="enemy"></param>
        public virtual void Attack(Character enemy)
        {
            if (this.Surname == enemy.Surname) // A priori c'est le même perso ...
            {
                return;
            }

            int strength = Character.RANDOM.Next(0, this.Strength);
            int handicap = Character.RANDOM.Next(0, this.Handicap);

            //var lifePointValue = enemy.LifePoint.Value;
            //lifePointValue = lifePointValue + strength - handicap;

            enemy.LifePoint = new LifePoint() // obligé de créer une nouvelle instance, car c'est une structure
            {
                Value = enemy.LifePoint.Value + strength - handicap
            };

            Console.WriteLine($"{this.Surname} has attacked. Enemy got {enemy.LifePoint.Value}");
        }
        #endregion

        #region Properties
        public string Surname { get; private set; } // le set est privé => on ne peut pas mettre à jour à l'extérieur de notre classe

        public LifePoint LifePoint
        {
            get => this.lifePoint;
            set
            {
                if (value.Value < 0)
                {
                    value.Value = 0;
                }
                this.lifePoint = value;
            }
        }

        public bool IsAlive { get => this.LifePoint.Value > 0; }

        public int Strength { get; set; }

        public int Handicap { get; set; }
        #endregion
    }
}

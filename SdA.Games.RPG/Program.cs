using SdA.Games.RPG.Core.Models.UI;
using System.Globalization;

System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("fr-FR");

string title = "Seigneurs des anneaux - Un RPG revisité !";
var subTitle = "Sam Gamgi remplace Frodo"; // prend le type de mon contenu, pour tout jamais !

int ageLimit = 13;
string[] characters = new string[] { "Aragorn", "Sam", "Gandalf", "Golum" };
string[,] map = new string[10, 10];
// string[,,] map3 = new string[10, 10, 5];


decimal forceMax = 11111150.5M;
Console.WriteLine(forceMax.ToString("C")); // # pas obligatoire, 0 => obligatoire // ici le C laisse dotnet gérer l'affichage selon les règle de la culture en cours



#region Execute game
Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine(title.PadLeft(title.Length + 3, '=').PadRight(title.Length + 6, '='));
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine(subTitle);
Console.ForegroundColor = ConsoleColor.White;

PrepareMap();

SelectBirthDay();
ProposeMenuToUser();

#endregion


#region Class libraries
#region Birthday
void SelectBirthDay()
{
    bool dateValid = false;
    string dateNaissanceSaisie = string.Empty;

    while (!dateValid)
    {
        System.Console.WriteLine("Date de naissance ?");
        dateNaissanceSaisie = Console.ReadLine();

        string format = "Tu as saisi cette date : {0} (format attendu DD/MM/YYYY)";
        string result = string.Format(format, dateNaissanceSaisie);

        //System.Console.WriteLine("Tu as saisi cette date : {0}", ageSaisie);
        System.Console.WriteLine(result);

        // DateTime dateAPrioriDeNaissance = DateTime.Parse(dateNaissanceSaisie);
        DateTime dateARecuperer = DateTime.MinValue;

        dateValid = TryDetectAgeValid(dateNaissanceSaisie, out dateARecuperer);
    }
}


bool TryDetectAgeValid(string saisieDate, out DateTime dateARetourner)
{
    bool aReussiLaConversion = DateTime.TryParse(saisieDate, out DateTime dateNaissance); // le try parse est impacté par la culture (donc la langue) en cours !
    dateARetourner = DateTime.MinValue;

    if (!aReussiLaConversion)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Mauvaise date !");
        Console.ForegroundColor = ConsoleColor.White;

        return false;
    }

    var ageCalculeSpan = DateTime.Now - dateNaissance;
    var ageCalcule = (decimal)ageCalculeSpan.Days / 365;

    bool estValid = ageCalcule >= ageLimit;

    if (estValid)
    {
        dateARetourner = dateNaissance;
        Console.WriteLine("j'ai bien reconnu ta date de naissance : {0}", dateNaissance.ToString("dddd dd MMMM yyyy", new CultureInfo("en-US")));
    }

    return estValid;
}
#endregion

#region Around menu
void DisplayMenu()
{
    var listItems = Enum.GetNames<MenuType>();

    foreach (var item in listItems) // foreach fonctionne sur tout ce qui est enumerable (table, list, array, ...)
    {
        var currentValue = Enum.Parse<MenuType>(item); // convertit la chaine en valeur de l'enum
        string displayItem = $"{(int)currentValue}. {item}";

        Console.WriteLine(displayItem);
    }
}

void ProposeMenuToUser()
{
    bool quit = false;

    while (!quit)
    {
        DisplayMenu();

        bool optionIsValid = false;
        while (!optionIsValid)
        {
            Console.WriteLine("Quel option ? (choisir le chiffre)");
            string inputValue = Console.ReadLine();

            optionIsValid = Enum.TryParse(typeof(MenuType), inputValue, out object inputToEnum);
            MenuType menuSelected;
            if (optionIsValid)
            {
                menuSelected = (MenuType)inputToEnum; // passer de object à l'enum du point de vue compilation

                switch (menuSelected)
                {
                    case MenuType.New:
                        {
                            Console.WriteLine("Prépare toi pour le démarrage du jeu");
                            ProposeCharacterToUser();
                        }
                        break;
                    case MenuType.Quit:
                        {
                            Environment.Exit(0);
                        }
                        break;
                }
            }
        }
    }
}
#endregion

#region Around characters
void DisplayCharacters()
{
    //string[] characters = new string[4];

    //characters[0] = "Aragorn";
    //characters[1] = "Sam";
    //characters[2] = "Gandalf";
    //characters[3] = "Golum";

    for (int i = 0; i < characters.Length; i++)
    {
        string displayValue = $"{i}. {characters[i]}";
        Console.WriteLine(displayValue);
    }
}

void ProposeCharacterToUser()
{
    DisplayCharacters();

    Console.WriteLine("Choisis ton perso (entier) : ");
    int selectedIndex = int.Parse(Console.ReadLine());

    var selectedCharacter = characters[selectedIndex];

    Console.WriteLine("C'est parti pour jouer avec {0}", selectedCharacter);
}
#endregion

#region Map
void PrepareMap()
{
    for (int i = 0; i < 10; i++) // chaque ligne
    {
        for (int j = 0; j < 10; j++) // chaque colonne
        {
            map[i, j] = "_"; // une cellule sur 2 dimension
        }
    }
}

void DisplayMap()
{
    for (int i = 0; i < 10; i++) // chaquee ligne
    {
        for (int j = 0; j < 10; j++) // chaque colonne
        {
            Console.WriteLine(map[i, j]);
        }
    }
}
#endregion
#endregion


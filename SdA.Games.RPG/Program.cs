string title = "Seigneurs des anneaux - Un RPG revisité !";
var subTitle = "Sam Gamgi remplace Frodo"; // prend le type de mon contenu, pour tout jamais !

int ageLimit = 13;

Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine(title.PadLeft(title.Length + 3, '=').PadRight(title.Length + 6, '='));
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine(subTitle);
Console.ForegroundColor = ConsoleColor.White;

#region Date de naissance
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


bool TryDetectAgeValid(string saisieDate, out DateTime dateARetourner)
{
    bool aReussiLaConversion = DateTime.TryParse(saisieDate, out DateTime dateNaissance);
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
    }

    return estValid;
}
#endregion



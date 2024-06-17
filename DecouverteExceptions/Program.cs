using DecouverteExceptions;

Console.WriteLine("Donne moi une valeur");
var saisie = Console.ReadLine();

decimal resultat = 0;

// variable locale aux accolades.
//{
//    var test = 1;
//}

// throw new Exception("ça plante");
throw new WTFException();

try
{
    string.Format("{1}", 1);

}
catch (FormatException ex)
{
    Console.WriteLine("Oops erreur de formattage");
}
//catch (Exception ex)
//{
//    throw; // ça fait proposer ton erreur
//}



try
{

    resultat = 10 / int.Parse(saisie); // si je mets 0, le prog s'arrête ici !
}
catch (Exception ex)
{
    Console.WriteLine("L'erreur est la suivante {0}", ex.Message);

}
finally // guardien avant plantage
{
    // ex: on ferme l'accès à un fichier, même si ça a planté

    Console.WriteLine("Même si on a eu une erreur cette ligne s'exécute");
}

Console.WriteLine("Ici, je peux afficher la valeur résultante : {0}", resultat);
using DecouverteDelegates;

void Display(string message)
{
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.WriteLine(message);
    Console.ForegroundColor = ConsoleColor.White;
}



UseDisplay use = Display; // je pointe vers la méthode Display
// NotDisplay use2 = Display; // Display ne respecte pas le contrat

use("test");


//void Calculer(int a, int b)
//{
//    var result = a * b;
//    Display(result.ToString());
//}

void Calculer(int a, int b, UseDisplay useDisplay)
{
    var result = a * b;
    // Afficher le resultat
    useDisplay(result.ToString());
}

Calculer(2, 3, use);

Calculer(2, 3, Console.WriteLine);





void DisplayTest(string message)
{
    Console.WriteLine("Mon message {0}", message);
}
UseDisplay display3 = DisplayTest;

/// Fonction anonyme => expression lambda
UseDisplay display2 = message =>
{
    Console.WriteLine("Mon message {0}", message);
};

Calculer(2, 3, display2);

Calculer(2, 3, message =>
{
    Console.WriteLine("Mon message {0}", message);
});

Calculer(2, 3, mess => Console.WriteLine("Mon message {0}", mess));
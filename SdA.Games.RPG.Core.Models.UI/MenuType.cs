namespace SdA.Games.RPG.Core.Models.UI
{
    /// <summary>
    /// Type dédié pour générer le menu
    /// </summary>
    public enum MenuType // internal = interne dans le projet
    {
        New = 1,
        Load = 2,
        Options = 3,
        Credits = -50,
        Quit = 0
    }
}

// Si deux espaces de noms différents : on peut avoir le même nom de type
// du point de vue compilation, ce n'est pas le même type !!
//namespace SdA.Games.RPG.Core.Models.UI2
//{
//    public enum MenuType // internal = interne dans le projet
//    {
//        New = 1,
//        Load = 2,
//        Options = 3,
//        Credits = -50,
//    }
//}


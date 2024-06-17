namespace SdA.Games.RPG.Core.Models
{
    // réfléchir à : est-ce que je compare les instances (donc la ref) ou bien la valeur ? qu'est ce qui est important
    /*
     * si valeur à comparer : struct
     * si ref à comparer : class
     */
    public struct LifePoint
    {
        public int Value { get; set; }
    }
}

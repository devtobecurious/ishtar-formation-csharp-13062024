
// règle 01 : définir le contexte d'utilisation

// règle 02 : définir attributs et comportements par entité

// Animal
// attributs => caractéristiques
//  - pattes
//  - yeux
//  - queue
//  - sexe
//  - mouche


// actions => méthodes (function, procedure) / comportements
//  + deplacer (-courir, -marcher, ...)
//  + manger
//  + se reproduire
//  + dormir
//  + vocaliser (-parler, -crier, ...)

// règle 03 : forte cohésion : est-ce que ça appartient bien à mon entité ?
// >> celui qui sait, c'est celui qui fait !

// règle 04 : qu'est ce qui est identique, et qui peut etre substitué par une classe parente

// règle 05 : on pense parent avant enfant

// règle 06 : on pense contrat avant class

using ApprentissagePOO;

Animal panda = new Panda();
panda.Surname = "Robert";

panda.Sleep();

Animal rhino = new Rhino();
rhino.Surname = "Albert";
rhino.Sleep();

// ((Rhino)rhino).Corne


Panda panda2 = new Panda();
panda2.Surname = "Robert 2";

panda2.Sleep();

var list2 = new List<Animal>()
{
    rhino,
    panda,
    panda2,
    new Bat(),
    new RedPanda()
    //new MushRoom() => je ne peux pas, car n'hérite pas de Animal
};

GoToSleep(list2);
GoToEat(list2);

void GoToSleep(List<Animal> list)
{
    foreach (var item in list)
    {
        item.Sleep();
    }
}

void GoToEat(List<Animal> list)
{
    foreach (var item in list)
    {
        item.Miam("repas");
    }
}


List<IFlying> flyers = new List<IFlying>()
{
    new Sparrow(),
    new Bat()
};

flyers.ForEach(flyer =>
{
    flyer.Fly();
});


List<Panda> list = new List<Panda>() // on crée et initialise avec 3 pandas
{
    (Panda)panda,
    panda2,
    new Panda() { Surname = "Robert 3" }
};

list.Add(new Panda() { Surname = "Robert 4" }); // on ajoute un nouveau panda



foreach (var item in list) // on peut itérer avec foreach car List est IEnumerable
{
    Console.WriteLine("{0} {1}", item.Surname, item.BirthDay.ToString("ddd dd MMM yyyy"));
    item.Sleep();
}


Panda po = (Panda)panda;  // type de référence, on a dans la variable la référence
po.Surname = "Pô";




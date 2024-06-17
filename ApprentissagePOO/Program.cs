
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

using ApprentissagePOO;

Panda panda = new Panda();
panda.Surname = "Robert";

panda.Sleep();


Panda panda2 = new Panda();
panda2.Surname = "Robert 2";

panda2.Sleep();


List<Panda> list = new List<Panda>() // on crée et initialise avec 3 pandas
{
    panda,
    panda2,
    new Panda() { Surname = "Robert 3" }
};

list.Add(new Panda() { Surname = "Robert 4" }); // on ajoute un nouveau panda



foreach (var item in list) // on peut itérer avec foreach car List est IEnumerable
{
    Console.WriteLine("{0} {1}", item.Surname, item.BirthDay.ToString("ddd dd MMM yyyy"));
    item.Sleep();
}


Panda po = panda;  // type de référence, on a dans la variable la référence
po.Surname = "Pô";


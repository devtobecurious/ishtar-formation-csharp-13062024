using SdA.Movements;

var player = new Player();
var horse = new Horse() { MovePoint = 4 };
var eagle = new Eagle();
var spaceShip = new SpaceShip();

player.Ride(horse);
player.Ride(eagle);
player.Ride(spaceShip);
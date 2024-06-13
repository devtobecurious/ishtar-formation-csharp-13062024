using DecouverteEnums;

MoveState moveState = MoveState.Idle;
moveState = MoveState.Walk;

int stateValue = (int)moveState;

if (moveState == MoveState.Idle)
{

}

moveState = (MoveState)((int)MoveState.Walk + (int)MoveState.Idle);

Random rand = new Random();
int result = rand.Next(0, (int)MoveState.Run);

var state = (MoveState)result;


string[] stateNames = Enum.GetNames<MoveState>();
for (int i = 0; i < stateNames.Length; i++)
{
    Console.WriteLine("State : {0}", stateNames[i]);
}

MoveState[] values = Enum.GetValues<MoveState>();
for (int i = 0; i < values.Length; i++)
{
    Console.WriteLine("Valeur ? {0}", (int)values[i]);
}
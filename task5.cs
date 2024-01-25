// Your program should start at this line.
int moveCount = 0;


for (int i = 0; i < 3; i++)
{
    if (Peek())
    {
        Move();
        Console.WriteLine(moveCount);
    }
}
Turn();
Console.WriteLine("Turn right");

for (int j = 0; j < 7; j++)
{
    if (Peek())
    {
        Move();
        Console.WriteLine(moveCount);
    }
}

TurnLeft();

for (int k = 0; k < 4; k++)
{
    if (Peek())
    {
        Move();
        Console.WriteLine(moveCount);
    }
}

Turn();
Console.WriteLine("Turn right");

for (int l = 0; l < 6; l++)
{
    if (Peek())
    {
        Move();
        Console.WriteLine(moveCount);
    }
}

TurnLeft();

for (int m = 0; m < 5; m++)
{
    if (Peek())
    {
        Move();
        Console.WriteLine(moveCount);
    }
}

TurnLeft();

for (int n = 0; n < 14; n++)
{
    if (Peek())
    {
        Move();
        Console.WriteLine(moveCount);
    }
}
if (AtGoal())
{
    Console.WriteLine("You are done");
    return;
}


#region Basic functions
// These functions are just her to make your intelisense work. 
// They only have a conceptual function.

void Move()
{
    // Moves the car 1 cell in the direction it is heading. 
    moveCount++;
}

void Turn()
{
    // Turns the car 90 deg clockwise.
    
    
}
void TurnLeft()
{
    Console.WriteLine("Turned left");
    for (int turns = 0; turns < 3; turns++);
    {
        Turn();
    }
}

bool Peek()
{
    // Returns true if the next cell is open, otherwise false.
    return true; // Just a placeholder value. 
}

bool AtGoal()
{
    // Returns true if the current cell is the goal cell.
    return true; // just a placholder
}

#endregion



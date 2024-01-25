// Your program should start at this line.
int moveCount = 0;

for (int i = 0; i < 11; i++)
{
    if (Peek())
    {
        Move();
        
    }
}
Console.WriteLine(moveCount);

Turn();
Console.WriteLine("Turn right");

Move();
Move();
Console.WriteLine(moveCount);

Turn();
Console.WriteLine("Turn right");

for (int j = 0; j < 10; j++)
{
    if (Peek())
    {
        Move();
        
    }
}
Console.WriteLine(moveCount);
TurnLeft();

Move();
Move();
Console.WriteLine(moveCount);

TurnLeft();

for (int k = 0; k < 10 ; k++)
{
    if (Peek())
    {
        Move();
        
    }
}
Console.WriteLine(moveCount);
Turn();
Console.WriteLine("Turn right");

Move();
Move();
Console.WriteLine(moveCount);

Turn();
Console.WriteLine("Turn right");

for (int l = 0; l < 10; l++)
{
    if (Peek())
    {
        Move();
        
    }
}
Console.WriteLine(moveCount);

TurnLeft();

for (int m = 0; m < 7; m++)
{
    if (Peek())
    {
        Move();
        
    }
}
Console.WriteLine(moveCount);

TurnLeft();

Move();
Move();
Console.WriteLine(moveCount);
TurnLeft();

for (int n = 0; n < 5; n++)
{
    if (Peek())
    {
        Move();
        
    }
}
Console.WriteLine(moveCount);

Turn();
Console.WriteLine("Turn right");

Move();
Move();
Console.WriteLine(moveCount);

Turn();
Console.WriteLine("Turn right");

for (int o = 0; o < 5; o++)
{
    if (Peek())
    {
        Move();
        
    }
}
Console.WriteLine(moveCount);

TurnLeft();

Move();
Move();
Console.WriteLine(moveCount);
TurnLeft();

for (int p = 0; p < 5; p++)
{
    if (Peek())
    {
        Move();
       
    }
}
 Console.WriteLine(moveCount);

Turn();
Console.WriteLine("Turn right");

Move();
Move();
Console.WriteLine(moveCount);

Turn();
Console.WriteLine("Turn right");

for (int q = 0; q < 5; q++)
{
    if (Peek())
    {
        Move();
        
    }
}
Console.WriteLine(moveCount);

TurnLeft();

for (int r = 0; r < 4; r++)
{
    if (Peek())
    {
        Move();
        
    }
}
Console.WriteLine(moveCount);

if (AtGoal());
    {
        Console.WriteLine("Congratulations, you have won!");
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



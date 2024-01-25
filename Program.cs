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

for (int j = 0; j < 2; j++)
{
    if (Peek())
    {
        Move();
        Console.WriteLine(moveCount);
    }
}
Turn();

for (int k = 0; k < 5; k++)
{
    if (Peek())
    {
        Move();
        Console.WriteLine(moveCount);
    }
}
Turn();

for (int l = 0; l < 4; l++)
{
    if (Peek())
    {
        Move();
        Console.WriteLine(moveCount);
    }
}
Turn();
//under car

for (int m = 0; m < 7; m++)
{
    if (Peek())
    {
        Move();
        Console.WriteLine(moveCount);
    }
}
Turn();

for (int n = 0; n < 6; n++)
{
    if (Peek())
    {
        Move();
        Console.WriteLine(moveCount);
    }
}
Turn();

for (int n = 0; n < 9; n++)
{
    if (Peek())
    {
        Move();
        Console.WriteLine(moveCount);
    }
}
Turn();
//over car

for (int o = 0; o < 8; o++)
{
    if (Peek())
    {
        Move();
        Console.WriteLine(moveCount);
    }
}
Turn();

for (int p = 0; p < 11; p++)
{
    if (Peek())
    {
        Move();
        Console.WriteLine(moveCount);
    }
}
Turn();

for (int q = 0; q < 10; q++)
{
    if (Peek())
    {
        Move();
        Console.WriteLine(moveCount);
    }
}
Turn();

for (int r = 0; r < 13; r++)
{
    if (Peek())
    {
        Move();
        Console.WriteLine(moveCount);
    }
}
Turn();
//upper right corner

for (int s = 0; s < 12; s++)
{
    if (Peek())
    {
        Move();
        Console.WriteLine(moveCount);
    }
}
Turn();

for (int t = 0; t < 15; t++)
{
    if (Peek())
    {
        Move();
        Console.WriteLine(moveCount);
    }
}
Turn();

for (int u = 0; u < 14; u++)
{
    if (Peek())
    {
        Move();
        Console.WriteLine(moveCount);
    }
}

if (AtGoal())
{
    Console.WriteLine("You made it past the finish line");
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
    Console.WriteLine("Turned right");
    
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
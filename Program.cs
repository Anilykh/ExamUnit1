// Your program should start at this line.
int moveCount = 0;


for (int i = 0; i < 4; i++)
{
    if (Peek())
    {
        Move();
        
    }
}
Console.WriteLine(moveCount);

TurnLeft();

for (int j = 0; j < 4; j++)
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
Console.WriteLine(moveCount);

TurnLeft();
Move();
Console.WriteLine(moveCount);
Turn();
Console.WriteLine("Turn right");

Console.WriteLine(moveCount);

for (int k = 0; k < 3; k++)
{
    if (Peek())
    {
        Move();
        
    }
}
Console.WriteLine(moveCount);

TurnLeft();
Move();
Console.WriteLine(moveCount);
Turn();
Console.WriteLine("Turn right");

for (int l = 0; l < 5; l++)
{
    if (Peek())
    {
        Move();
        
    }
}
Console.WriteLine(moveCount); 

TurnLeft();

for (int m = 0; m < 3; m++)
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
Console.WriteLine(moveCount);
TurnLeft();
Move();
Console.WriteLine(moveCount);
Turn();
Console.WriteLine("Turn right");
Move();
Move();
Console.WriteLine(moveCount);
Turn();
Console.WriteLine("Turn right");
Move();
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
Console.WriteLine(moveCount);
TurnLeft();
Move();
Console.WriteLine(moveCount);
Turn();
Console.WriteLine("Turn right");
Move();
Move();
Console.WriteLine(moveCount);
TurnLeft();

for (int o= 0; o < 3; o++)
{
    if (Peek())
    {
        Move();
        
    }
}
Console.WriteLine(moveCount);

Turn();
Console.WriteLine("Turn right");

for (int p = 0; p < 3; p++)
{
    if (Peek())
    {
        Move();
        
    }
}
Console.WriteLine(moveCount);

TurnLeft();
Move();
Console.WriteLine(moveCount);
Turn();
Console.WriteLine("Turn right");
Move();
Move();
Console.WriteLine(moveCount);
TurnLeft();

for (int q = 0; q < 3; q++)
{
    if (Peek())
    {
        Move();
       
    }
}
Console.WriteLine(moveCount);

TurnLeft();

for (int r = 0; r < 3; r++)
{
    if (Peek())
    {
        Move();
        
    }
}
Console.WriteLine(moveCount);

Turn();
Console.WriteLine("Turn right");

for (int s = 0; s < 5; s++)
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
Console.WriteLine(moveCount);
TurnLeft();

for (int t = 0; t < 4; t++)
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
Console.WriteLine(moveCount);
TurnLeft();
Move();
Console.WriteLine(moveCount);
Turn();
Console.WriteLine("Turn right");
Move();
Console.WriteLine(moveCount);
TurnLeft();
Move();
Move();
Console.WriteLine(moveCount);
Turn();
Console.WriteLine("Turn right");
Move();
Console.WriteLine(moveCount);

for (int u = 0; u < 4; u++)
{
    if (Peek())
    {
        Move();
        Console.WriteLine(moveCount);
    }
}
Turn();
Console.WriteLine("Turn right");
for (int v = 0; v < 3; v++)
{
    if (Peek())
    {
        Move();
        Console.WriteLine(moveCount);
    }
}

if (AtGoal())
{
    Console.WriteLine("You made");
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



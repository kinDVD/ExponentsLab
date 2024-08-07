//Intro
Console.WriteLine("Welcome to Learn Your Squares and Cubes! LYSC for short.");
Console.WriteLine("What is your name?");
string name = Console.ReadLine();
Console.WriteLine();
Console.WriteLine($"Hi {name}.");
Console.WriteLine();

//for loop
bool runProgram = true;
int i = 1;

do
{
    int num = GetInput(); 
    Console.WriteLine(string.Format("{0,7}\t{1,7}\t{2,7}\t", "Number", "Squared", "Cubed"));
    Console.WriteLine(string.Format("{0,7}\t{1,7}\t{2,7}\t", "=======", "=======", "======="));
    for (int r = 1; r <= num; r++)
    {
        int number = r;
        int square = GetSquare(r);
        int cube = GetCube(r);
        Console.WriteLine(string.Format("{0,-7}\t{1,-7}\t{2,-7}\t", number, square, cube));
    }
    Console.WriteLine();
    runProgram = GetContinue();
} while (runProgram);

//methods
static int GetInput()
{
    int num = -1;
    while (num <= 0 || num > 1290)
    {
        Console.WriteLine("Please enter a positive integer.");
        num = int.Parse(Console.ReadLine());

        if (num <= 0)
        {
            Console.WriteLine("That number is not positive.");
            Console.WriteLine();
        }
        else if (num > 1290)
        {
            Console.WriteLine("That number is too large to square in C#!");
            Console.WriteLine();
        }
        Console.WriteLine();
    }
    return num;
}

static  int GetSquare(int num)
{
    return num * num;
}

static int GetCube(int num)
{
    return num * num * num;
}

static bool GetContinue()
{
    bool result = true;
    while (true)
    {
        Console.WriteLine("Would you like to continue? y/n");
        string continueChoice = Console.ReadLine();
        Console.WriteLine();
        if (continueChoice == "y")
        {
            result = true;
            break;
        }
        else if (continueChoice == "n")
        {
            result = false;
            break;
        }
        else
        {
            Console.WriteLine("Invalid. Try again.");
            Console.WriteLine();
        }
    }
    Console.WriteLine();
    return result;
}

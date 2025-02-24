using MathGame;

bool mustExit = false;
Helper helper = new Helper();
List<Match> matchHistory = new List<Match>();

Console.WriteLine("Welcome!");

while (mustExit == false)
{
    ShowMenu();
    Console.WriteLine();
    string selection = Console.ReadLine();
    int selectionNumber = 0; 
    int.TryParse(selection, out selectionNumber);
    
    switch (selectionNumber)
    {
        case 1:
            AdditionGame();
            break;
        case 2:
            SubstractionGame();
            break;
        case 3:
            MultiplicationGame();
            break;
        case 4:
            DivisionGame();
            break;
        case 5:
            ShowGameHistory();
            break;
        case 6:
            mustExit = true;
            break;
    }
}
Console.WriteLine("\nThanks for playing!");
Console.ReadLine();


 void ShowMenu()
{
    Console.WriteLine("Select an option from the menu!");
    Console.WriteLine("1 - Addition game");
    Console.WriteLine("2 - Substraction game");
    Console.WriteLine("3 - Multiplication game");
    Console.WriteLine("4 - Division game");
    Console.WriteLine("5 - Show game history");
    Console.WriteLine("\n6 - Leave program");
    Console.WriteLine("\n______________________________");
}

void ShowGameHistory ()
{
    foreach(Match match in matchHistory)
    {
        match.DisplayGame();
    }
    Console.WriteLine();
    Console.ReadLine();
}

void AdditionGame() 
{
    int roll1 = 0;
    int roll2 = 0;
    helper.GenerateNumbers(ref roll1, ref roll2);

    int solution = roll1 + roll2;

    Console.Clear();
    Console.WriteLine($"What is the solution for {roll1} + {roll2} ?");
    string answer = Console.ReadLine();

    if (helper.VerifySolution(solution, answer) == true)
    {
        Console.WriteLine("Correct!");
    }
    else
        Console.WriteLine("Incorrect!");
    helper.AddNewMatch(matchHistory, roll1, roll2, answer, solution, '+');
}

void SubstractionGame()
{
    int roll1 = 0;
    int roll2 = 0;
    helper.GenerateNumbers(ref roll1, ref roll2);

    int solution = roll1 - roll2;

    Console.Clear();
    Console.WriteLine($"What is the solution for {roll1} - {roll2} ?");
    string answer = Console.ReadLine();

    if (helper.VerifySolution(solution, answer) == true)
    {
        Console.WriteLine("Correct!");
    }
    else
        Console.WriteLine("Incorrect!");

    helper.AddNewMatch(matchHistory, roll1, roll2, answer, solution, '-');
}

void MultiplicationGame()
{
    int roll1 = 0;
    int roll2 = 0;
    helper.GenerateNumbers(ref roll1, ref roll2);

    int solution = roll1 * roll2;

    Console.Clear();
    Console.WriteLine($"What is the solution for {roll1} * {roll2} ?");
    string answer = Console.ReadLine();

    if (helper.VerifySolution(solution, answer) == true)
    {
        Console.WriteLine("Correct!");
    }
    else
        Console.WriteLine("Incorrect!");

    helper.AddNewMatch(matchHistory, roll1, roll2, answer, solution, '*');
}

void DivisionGame()
{
    int roll1 = 0;
    int roll2 = 0;
    helper.GenerateNumbersForDivision(ref roll1, ref roll2);

    int solution = roll1 / roll2;

    Console.Clear();
    Console.WriteLine($"What is the solution for {roll1} / {roll2} ?");
    string answer = Console.ReadLine();

    if (helper.VerifySolution(solution, answer) == true)
    {
        Console.WriteLine("Correct!");
    }
    else
        Console.WriteLine("Incorrect!");

    helper.AddNewMatch(matchHistory, roll1, roll2, answer, solution, '/');
}
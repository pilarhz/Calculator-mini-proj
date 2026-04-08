bool AppRunning = true;

void Calculate(string expression)
{
    List<string> orderOfMathOperations = new List<string>();

    calculator.SettingFalseOrder.SetList(orderOfMathOperations, expression);

    calculator.SortingAlgorithm.Sort(orderOfMathOperations);

    Console.WriteLine("Posortowane");
    for (int i = 0; i < orderOfMathOperations.Count; i++)
    {
        Console.WriteLine(orderOfMathOperations[i]);
    }

    Console.WriteLine("Step - 1");
    calculator.EquationSolver.Solve(orderOfMathOperations, ref expression);

    int s = 2;
    while (orderOfMathOperations.Count != 0)
    {
        calculator.SettingFalseOrder.SetList(orderOfMathOperations, expression);
        Console.WriteLine("Step - " + s);
        calculator.EquationSolver.Solve(orderOfMathOperations, ref expression);
        s++;
    }
}

void MathOperation()
{
    Console.Clear();

    Console.WriteLine("Write math operation below (the only ones that work for now are '+', '-', '*', '/')");

    string? operation = Console.ReadLine();

    if (operation != null)
    {
        Calculate(operation);
    }
    else
    {
        Console.WriteLine("Null equation");
    }

    Console.WriteLine();
    Console.WriteLine("Press anything to continue");
    Console.ReadKey();
}

void ShowMenu()
{
    string? option = null;

    Console.WriteLine("1 - Math operation");
    Console.WriteLine("2 - Exit");

    option = Console.ReadLine();

    while (true)
    {
        if (option == "1")
        {
            MathOperation();
            break;
        }
        else if (option == "2")
        {
            AppRunning = false;
            break;
        }
        else
        {
            Console.Clear();
            ShowMenu();
            continue;
        }
    }
}

while(AppRunning == true)
{
    ShowMenu();
    Console.Clear();
}
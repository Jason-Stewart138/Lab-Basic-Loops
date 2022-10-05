using System.Security.Cryptography.X509Certificates;


RunUI();
ExitApplication();

void RunUI()
{
    HelloWorldLoop();
    CountDownCountUpLoop();
    KeyPadLock();
}

void ExitApplication()
{
    Console.WriteLine("Thanks!");
    Console.WriteLine("Hit Any Key To Exit");
    Console.ReadKey();
    Environment.Exit(0);
}

bool ShouldContinueAsking()
{
    Console.WriteLine("Would You Like To Continue (y/n)?");
    string userResponse = Console.ReadLine();
    if (userResponse.ToLower().Trim() == "y")
    {
        return true;
    }
    else
    {
        return false;
    }

}

void HelloWorldLoop()
{
    bool continueHelloWorld = true;
    do
    {
        Console.WriteLine("Hello, World!");
        continueHelloWorld = ShouldContinueAsking();

    } while (continueHelloWorld);
}

void CountDownCountUpLoop()
{
    bool continueCountDownCountUp = true;
    Console.Clear();
    do
    {
        Console.WriteLine("Please Enter A Whole Number (No Decimals Please):");
        int userInputNumber = int.Parse(Console.ReadLine());
        Console.WriteLine();


        for (int i = 0; i <= userInputNumber; i++)
        {
            Console.WriteLine($"{i}");
        }

        Console.WriteLine();

        for (int i = userInputNumber; i >= 0; i--)
        {
            Console.WriteLine($"{i}");
        }
        continueCountDownCountUp = ShouldContinueAsking();

    } while (continueCountDownCountUp);

}

void KeyPadLock()
{
    Console.Clear();
    bool isDoorLocked = true;
    int maximumAttempts = 5;
    string correctCombination = "13579";

    Console.WriteLine("Please Enter The Five Digit Code To Open The Door");
    Console.WriteLine("Each Digit In the Code Is Only Used Once.. Isn't That Odd..");
    Console.WriteLine("Warning!");
    Console.WriteLine("You Only Get 5 Attempts To Enter The Correct Code!");
    Console.WriteLine();

    isDoorLocked = EnterDoorCode(isDoorLocked, maximumAttempts, correctCombination, out maximumAttempts);

    if (isDoorLocked)
    {
        Console.WriteLine();
        Console.WriteLine("You Have Entered 5 Incorrect Codes");
        Console.WriteLine("You Have No Attempts Left");
    }

}

bool EnterDoorCode(bool isDoorLocked, int maximumAttempts, string correctCombination, out int maxAttemptsLeft)
{

    do
    {
        Console.WriteLine($"Please Enter The Door Code");
        string userCodeInput = Console.ReadLine();
        Console.WriteLine();

        if (userCodeInput == correctCombination)
        {
            Console.WriteLine($"{userCodeInput} Is Correct, Welcome In");
            isDoorLocked = false;
        }
        else
        {
            Console.WriteLine($"{userCodeInput} Is Incorrect, Please Try Again");
            maximumAttempts--;
            isDoorLocked = true;

        }

    } while (isDoorLocked && maximumAttempts > 0);

    maxAttemptsLeft = maximumAttempts;
    return isDoorLocked;
}
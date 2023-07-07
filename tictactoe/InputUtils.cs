namespace tictactoe;

public static class InputUtils
{
    public static int GetIntInRange(string prompt, int rangeLow, int rangeHigh)
    {
        Console.WriteLine(prompt);
        string userInput = Console.ReadLine() ?? string.Empty;
        int input;

        //try-parse is the var you are checking and then an output var if it passes. So input becomes the number if it passes the parse.
        while ((!int.TryParse(userInput, out input) && input < rangeLow) || input > rangeHigh)
        {
            Console.WriteLine(
                $"That is not a number or is out of range. Please input a number between {rangeLow} and {rangeHigh}.");
            userInput = Console.ReadLine() ?? string.Empty;
        }

        return input;
    }

    public static string GetStringToLower(string prompt, string error)
    {
        Console.WriteLine(prompt);
        string userInput = Console.ReadLine() ?? string.Empty;

        while (userInput == string.Empty)
        {
            Console.WriteLine(error);
            userInput = Console.ReadLine() ?? string.Empty;
        }

        return userInput.ToLower();
    }
}
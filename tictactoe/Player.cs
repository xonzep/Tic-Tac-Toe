namespace tictactoe;

public class Player
{
    private int _choice;
    
    public Player()
    {
        
    }
    
   public void DecideTeams()
    {
        char team1;
        char team2;
        bool askAgain = true;
        string uinput =
            InputUtils.GetStringToLower("Do you want to be X or O?", "That is not an option. Please choose X or O.");

        while (askAgain)
            if (uinput == "x")
            {
                Console.WriteLine("Player 1 is team X. Player 2 is team O");
                team1 = 'X';
                team2 = 'O';
                askAgain = false;
            }
            else if (uinput == "o")
            {
                Console.WriteLine("Player 1 is team O. Player 2 is team X");
                team1 = 'O';
                team2 = 'X';
                askAgain = false;
            }
            else
            {
                Console.WriteLine("That is not an option. Please choose X or O");
                uinput =
                    InputUtils.GetStringToLower("Do you want to be X or O?", "That is not an option. Please choose X or O.");
            }
    }

    //We're going to use an array/list to keep track of previous choices. If they number is in the array then we ask for a new guess.
    List<int> chosen = new();
    public int CheckChoice()
    {
        
        bool pickedNum = false;
        int userChoice = InputUtils.GetIntInRange("What position would you like to use? 1-9", 1, 9);

        while (pickedNum == false)
        {
            if (chosen.Contains(userChoice))
            {
                userChoice = InputUtils.GetIntInRange("That choice has already been picked. Please chose another.", 1, 9);
            }
            else
            {
                chosen.Add(userChoice);
                pickedNum = true;
            }
        }

        return userChoice;
    }
}
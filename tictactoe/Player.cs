namespace tictactoe;

public class Player
{
    public void GetNames()
    {
        //How do we assign the symbol to the players? We have the input of their teams. How do we take that as our point to the symbol?
        
       string playerOne =  InputUtils.GetStringToLower("Who will go first? You will be X. Please input your name.", "That is not an option.");
       
       string playerTwo =
           InputUtils.GetStringToLower("Player Two, what is your name? You will be O. Please input your name.",
               "That is not an option.");
       
    }

    

    //We're going to use an array/list to keep track of previous choices. If the number is in the array then we ask for a new guess.
    List<int> _chosen = new();
    public int CheckChoice()
    {
        
        bool pickedNum = false;
        int userChoice = InputUtils.GetIntInRange("What position would you like to use? 1-9", 1, 9);

        while (pickedNum == false)
        {
            if (_chosen.Contains(userChoice))
            {
                userChoice = InputUtils.GetIntInRange("That choice has already been picked. Please chose another.", 1, 9);
            }
            else
            {
                _chosen.Add(userChoice);
                pickedNum = true;
            }
        }

        return userChoice;
    }
}


namespace tictactoe;

public class Player
{
    private const int _pOne = 1;
    private const int _pTwo = 2;


    //We're going to use an array/list to keep track of previous choices. If the number is in the array then we ask for a new guess.
    private readonly List<int> _chosen = new();
    private int CheckChoice()
    {
        
        bool pickedNum = false;
        int userChoice = InputUtils.GetIntInRange("What position would you like to use? 1-9", 1, 9);
       

        while (pickedNum == false)
        {
            if (_chosen.Contains(userChoice))
            {
                userChoice = InputUtils.GetIntInRange("That choice has already been picked. Please choose another.", 1, 9);
            }
            else
            {
                _chosen.Add(userChoice);
                pickedNum = true;
            }
        }

        return userChoice;
    }

    public void ApplyChoice()
    {
        int userChoice;
        int team = _pOne;
        
        if (team == _pOne)
        {   
            userChoice = CheckChoice();
            Board boardTeamOne = new(userChoice, _pOne);
            boardTeamOne.GetSymbol();
            Board.DrawBoard();
            team = _pTwo;

        } 
        
        if (team == _pTwo)
        {
            userChoice = CheckChoice();
            Board boardTeamTwo = new(userChoice, _pTwo);
            boardTeamTwo.GetSymbol();
            Board.DrawBoard();
            team = _pOne;
        }
    }
}
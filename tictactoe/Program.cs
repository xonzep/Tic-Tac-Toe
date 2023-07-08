/* We are making a tic-tac-toe game. This is going to be difficult as it's the biggest program we've made.
 No looking at the solution. We need to figure this out mostly by ourselves. So let's start.
 
 DONE AND MOVED TO ITS OWN CLASS: First we need an input for each user. This should be a method that asks for a number 1-9. This number is the placement
 on the board.
 
 Next we need a way to display the board and update it. The board is just a string, so should each row be split up?
 Or each square? Like a switch is tied to each square. If we do that we can use short hand rather than numbers?
 
 TL-TM-TR
 ML-M-MR
 BR-BM-BR
 
 1-2-3
 4-5-6   --We'll use this as we already have an int method.
 7-8-9
 

*/


using tictactoe;

void DecideTeams()
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

int CheckChoice()
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

CheckChoice();



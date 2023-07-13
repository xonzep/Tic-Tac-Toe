/*
 * We need a way to get info to the board and display it. So we need to set who is X and who is O. We can do that in the main branch using the input.
 * We will need to check if we are getting the expected response. 
 */


namespace tictactoe;

public class Board
{
    private string _user;
    public Board(string user)
    {
        user = _user;
    }

    
    private static string[] _cellNum = {"1", "2", "3", "4", "5", "6", "7", "8", "9"};
    private string PlaceChoice(Player teamOne, Player teamTwo)
    {
        teamOne = new Player();
        teamTwo = new Player();
        foreach (string cell in _cellNum)
        {
            if (_cellNum.Contains(teamOne.CheckChoice().ToString()))
            {
                return "test";
            }
        }

        return "0";
    }
    
   

    
    
    
    public static void DrawBoard()
    {
        const string cells = "  {0}  |  {1}  |  {2}  ";
        const string line = "----------------";
        const int boardSize = 9;
        const int row = 3;

        for (int i = 0; i < boardSize; i += row)
        {
           Console.WriteLine(cells, _cellNum[i], _cellNum[i+1], _cellNum[i+2]);
           Console.WriteLine(line);
        }

    }

}
/*
 * We need a way to get info to the board and display it. So we need to set who is X and who is O. We can do that in the main branch using the input.
 * We will need to check if we are getting the expected response. 
 */



namespace tictactoe;

public class Board
{
    private int _choice;
    private int _team;
    public Board(int choice, int team)
    {
        _choice = choice;
        _team = team;
    }

    
    
    private static string[] _cellNum = {"1", "2", "3", "4", "5", "6", "7", "8", "9"};

    public void GetSymbol()
    {
        string userInput = _choice.ToString();
        //We get the index of the number.
        int contain = Array.IndexOf(_cellNum, userInput);
        //then we do something if that number does exist in our array.

        if (contain == -1)
        {
            Console.WriteLine("Out of range.");
        }
        
        if (_team == 1)
        {
            _cellNum[contain] = "X";
        }
        else if (_team == 2)
        {
            _cellNum[contain] = "O";
        }
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
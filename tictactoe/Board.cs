/*
 * We need a way to get info to the board and display it. So we need to set who is X and who is O. We can do that in the main branch using the input.
 * We will need to check if we are getting the expected response. 
 */

namespace tictactoe;

public class Board
{
    private readonly int _choice;
    private readonly int _team;
    
    public Board(int choice, int team)
    {
        _choice = choice;
        _team = team;
    }

    
    
    private static readonly string[] _cellNum = {"1", "2", "3", "4", "5", "6", "7", "8", "9"};

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
    
    private static bool CheckLine(int index1, int index2, int index3)
    {
        return _cellNum[index1] == _cellNum[index2] && _cellNum[index2] == _cellNum[index3];
    }
    
    public static bool CheckWinCondition()
    {
        // Check row
        if (CheckLine(0, 1, 2) || CheckLine(3, 4, 5) || CheckLine(6, 7, 8))
            return true;

        // Check column
        if (CheckLine(0, 3, 6) || CheckLine(1, 4, 7) || CheckLine(2, 5, 8))
            return true;

        // Check diagonal
        return CheckLine(0, 4, 8) || CheckLine(2, 4, 6);
    }

   

}
/*
 * We need a way to get info to the board and display it. So we need to set who is X and who is O. We can do that in the main branch using the input.
 * We will need to check if we are getting the expected response. 
 */


namespace tictactoe;

internal class Board
{
    private string _team1;
    private string _team2;
    private int _userInput;

    public Board(int uPlace, string team1, string team2)
    {
        _userInput = uPlace;
        _team1 = team1;
        _team2 = team2;
    }
}
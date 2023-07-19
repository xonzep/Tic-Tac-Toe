namespace tictactoe
{
    public class Player
    {
        public const int POne = 1;
        private const int PTwo = 2;

        private static List<int>? _chosen;
        private int _team;

        public Player()
        {
            _chosen = new List<int>();
            _team = POne;
        }

        private static int CheckChoice()
        {
            bool pickedNum = false;
            int userChoice = InputUtils.GetIntInRange("What place would you like to use? 1-9", 1, 9);

            while (!pickedNum)
            {
                if (_chosen?.Contains(userChoice) == true)
                {
                    userChoice = InputUtils.GetIntInRange("That choice has already been picked. Please choose another.", 1, 9);
                }
                else
                {
                    _chosen?.Add(userChoice);
                    pickedNum = true;
                }
            }

            return userChoice;
        }

        
        private static bool CheckLine(int index1, int index2, int index3)
        {
            return Board.CellNum[index1] == Board.CellNum[index2] && Board.CellNum[index2] == Board.CellNum[index3];
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

        public static bool CheckDraw()
        {
            //Check for draw
            if (_chosen is { Count: > 8 })
                return true;
            return false;
        }
        private void RunChoice()
        {
            Board.DrawBoard();
            int userChoice = CheckChoice();
            Board boardTeamOne = new Board(userChoice, _team);
            boardTeamOne.GetSymbol();
            Console.Clear();

        }
        public int MakeMove()
        {
            RunChoice();
            _team = (_team == POne) ? PTwo : POne;
            return _team;
        }
    }
}
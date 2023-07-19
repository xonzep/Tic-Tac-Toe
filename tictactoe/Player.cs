namespace tictactoe
{
    public class Player
    {
        public const int POne = 1;
        public const int PTwo = 2;

        private readonly List<int> _chosen;
        private int _team;

        public Player()
        {
            _chosen = new List<int>();
            _team = POne;
        }

        private int CheckChoice()
        {
            bool pickedNum = false;
            int userChoice = InputUtils.GetIntInRange("What place would you like to use? 1-9", 1, 9);

            while (!pickedNum)
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
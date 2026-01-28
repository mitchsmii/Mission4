namespace Mission4;

public class BoardTools
{
    public int CheckWinner(int[] gameBoard, int player)
    {
        List<int> playerInputs = new List<int>();
        for (int i = 0; i < gameBoard.Length; i++)
        {
            if (gameBoard[i] == player)
            {
                playerInputs.Add(i);
            }
        }
        
        int winner = 0;
        int[][] combinations = new int[8][]
        {
            new int[] { 0, 1, 2 },
            new int[] { 3, 4, 5 },
            new int[] { 6, 7, 8 },
            new int[] { 0, 3, 6 },
            new int[] { 1, 4, 7 },
            new int[] { 2, 5, 8 },
            new int[] { 0, 4, 8 },
            new int[] { 2, 4, 6 }
        };

        // get player inputs in an array
        
        // compare inputs to the possible combinations

        foreach (var combo in combinations)
        {
            if (gameBoard[combo[0]] == player &&
                gameBoard[combo[1]] == player &&
                gameBoard[combo[2]] == player)
            {
                winner = player; // player
            }

        }
        
        

        return winner;
    }


    public void PrintBoard(int[] gameBoard)
    {
        
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();

    }
}
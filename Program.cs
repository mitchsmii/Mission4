using Mission4;


// 1. Welcome the user
Console.WriteLine("Welcome to Team 1's Tic-Tac-Toe Game!");
Console.WriteLine("Players will take turns entering a position number (0-8) to make a move.");


// 2. Initialize the game components
BoardTools bt = new BoardTools();
int[] gameBoard = new int[9];
int currentTurn = 1;          // Player 1 starts (X)
bool gameOver = false;


while (!gameOver)
{
   // 3. Print the board by calling the supporting class
    bt.PrintBoard(gameBoard);


   // 4. Ask the current player for their choice
    Console.WriteLine($"Player {(currentTurn == 1 ? "X" : "O")} (Player {currentTurn}), choose an available position (0-8):");


    string input = Console.ReadLine();


   // Validation: Check if input is a number, within range, and the space isn't taken
    if (int.TryParse(input, out int choice) && choice >= 0 && choice <= 8)
    {
        if (gameBoard[choice] == 0)
        {
            // Update the array with the player's ID (1 or 2)
            gameBoard[choice] = currentTurn;


           // 5. Check for a winner or tie by calling the method in the supporting class
            int result = bt.CheckWinner(gameBoard, currentTurn);


            if (result == 1 || result == 2)
            {
                bt.PrintBoard(gameBoard);
                Console.WriteLine($"\nCONGRATULATIONS! Player {(result == 1 ? "X" : "O")} wins!");
                gameOver = true;
            }
            else if (result == 3)
            {
                bt.PrintBoard(gameBoard);
                Console.WriteLine("\nIT'S A TIE! No more moves left.");
                gameOver = true;
            }
            else
            {
                // No winner yet, switch player turn (1 becomes 2, 2 becomes 1)
                currentTurn = (currentTurn == 1) ? 2 : 1;
            }
        }
        else
        {
            Console.WriteLine("\n--- ERROR: That space is already taken! Please try again. ---");
        }
    }
    else
    {
        Console.WriteLine("\n--- ERROR: Invalid input. Please enter a number between 0 and 8. ---");
    }
    }


Console.WriteLine("Thanks for playing!");




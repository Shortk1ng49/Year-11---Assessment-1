using System.Linq;
using System.Threading;

Random random = new Random();
bool playAgain = true;
string player;
string computer;
bool PLAYER1 = true;

// Variables

while(playAgain)
{
int playerscore = 0;
int computerscore = 0;
int Turns = 0;
// Delcare variables related to the points system in Rock Paper Scissors
string [] board = new string[9] {"1", "2", "3", "4","5", "6", "7", "8", "9"};
// Print the options of the board
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.Yellow;
    for (int i = 0; i < 50; i++)
    {
        Console.Write("- ");
    }
    // Loop allows lines to continuosly be printed without having to indivually write them in code
    Console.WriteLine("");
    Console.WriteLine("");  

            
                Console.ForegroundColor = ConsoleColor.Cyan;
                
            Console.WriteLine(@"
 ██████╗  █████╗ ███╗   ███╗███████╗  ██████╗ ███╗   ██╗██╗
██╔════╝ ██╔══██╗████╗ ████║██╔════╝ ██╔═══██╗████╗  ██║██║
██║  ███╗███████║██╔████╔██║█████╗   ██║   ██║██╔██╗ ██║██║
██║   ██║██╔══██║██║╚██╔╝██║██╔══╝   ██║   ██║██║╚██╗██║╚═╝ 
╚██████╔╝██║  ██║██║ ╚═╝ ██║███████╗ ╚██████╔╝██║ ╚████║██╗
 ╚═════╝ ╚═╝  ╚═╝╚═╝     ╚═╝╚══════╝  ╚═════╝ ╚═╝  ╚═══╝╚═╝
 ");
            
                            Console.ForegroundColor = ConsoleColor.White;


    Console.WriteLine();
    Console.WriteLine("Welcome to Text based Gaming!");
    Console.WriteLine("This Applications offers 2 different games:");
    Console.WriteLine("     - Rock, Paper, Scissors: Play against the computer! ");
    Console.WriteLine("     - Tic Tac toe: Play alongside a friend next to you!");
    Console.WriteLine();
    Console.WriteLine("Press 1 if you wish to play Rock, Paper, Scissors!");
    Console.WriteLine("Press 2 if you would like to play Tic Tac Toe!");
    Console.WriteLine();
    
    Console.ForegroundColor = ConsoleColor.Yellow;

    for (int i = 0; i < 50; i++)
    {
        Console.Write("- ");
    }
        Console.ForegroundColor = ConsoleColor.White;

    // Prints introductory text

    Console.WriteLine();
    string game = Console.ReadLine();
    
    if (game == "1")
    // This input sends the user to rock paper scissors
        {
            Console.Clear();
            
            Console.ForegroundColor = ConsoleColor.Yellow;

            for (int i = 0; i < 50; i++)
            {
                Console.Write("- ");
            }
            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.WriteLine("");
            Console.WriteLine("");
            
            Console.WriteLine(@"
█████╗   ██████╗  ██████╗██╗  ██╗    ██████╗  █████╗ ██████╗ ███████╗██████╗
██╔══██╗██╔═══██╗██╔════╝██║ ██╔╝    ██╔══██╗██╔══██╗██╔══██╗██╔════╝██╔══██╗
██████╔╝██║   ██║██║     █████╔╝     ██████╔╝███████║██████╔╝█████╗  ██████╔╝
██╔══██╗██║   ██║██║     ██╔═██╗     ██╔═══╝ ██╔══██║██╔═══╝ ██╔══╝  ██╔══██╗ 
██║  ██║╚██████╔╝╚██████╗██║  ██╗    ██║     ██║  ██║██║     ███████╗██║  ██║ 
╚═╝  ╚═╝ ╚═════╝  ╚═════╝╚═╝  ╚═╝    ╚═╝     ╚═╝  ╚═╝╚═╝     ╚══════╝╚═╝  ╚═╝

███████╗ ██████╗██╗███████╗███████╗ ██████╗ ██████╗ ███████╗
██╔════╝██╔════╝██║██╔════╝██╔════╝██╔═══██╗██╔══██╗██╔════╝
███████╗██║     ██║███████╗███████╗██║   ██║██████╔╝███████╗
╚════██║██║     ██║╚════██║╚════██║██║   ██║██╔══██╗╚════██║
███████║╚██████╗██║███████║███████║╚██████╔╝██║  ██║███████║ 
╚══════╝ ╚═════╝╚═╝╚══════╝╚══════╝ ╚═════╝ ╚═╝  ╚═╝╚══════╝ 
");
            
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("");
            
            Console.WriteLine("Welcome to Rock Paper Scissors");
            Console.WriteLine("You will verse the computer!");
            Console.WriteLine("Don't worry, it will make a random choice");
            Console.WriteLine("Simply type Rock, Paper or Scissors and press Enter to confirm your choice");
            Console.WriteLine("First one to three Points Wins!");
            Console.WriteLine("Have Fun!");
            Console.WriteLine("Press Enter to Continue");
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Yellow;
            for (int i = 0; i < 50; i++)
            {
                Console.Write("- ");
            }
            Console.ForegroundColor = ConsoleColor.White;
            
            // Introduction for rock paper scissors
            
            Console.ReadLine();
            {
                Console.Clear();
                
                while (playerscore != 3 && computerscore != 3)
                // as long as somones score is not three, there is no winner so the game continues
                {
                    player = ("");
                    computer = ("");
                    
                    // variables for the user and the computer in rock paper scissors

                    while (player != "ROCK" && player != "PAPER" && player  != "SCISSORS") {
                    
                    // Until the player enters one of these inputs, the following will print

                        Console.Clear();
                        Console.WriteLine("Player Score - " + playerscore + " | Computer Score - " + computerscore);
                        Console.WriteLine("Enter Rock, Paper or scissors");
                        player = Console.ReadLine();
                        player = player.ToUpper();
                        // Makes the text all uppercase to prevent inconsistencies
                    }
                   
                    int randonumber = random.Next(1, 4);
                    // Random variable so we have three outomes which the computer will randomly choose against the player
                    switch(randonumber)
                    {
                        case 1:
                            computer = "ROCK";
                            break;
                        case 2:
                            computer = "PAPER";
                            break;
                        case 3:
                            computer = "SCISSORS";
                            break;
                        // listing the possibilities the computer have have and stating what they equate to
                    }
                    Console.Clear();
                    Console.WriteLine("Player: " + player);
                    Console.WriteLine("Computer: " + computer);
                    
                    // Shows the points betweern the player and computer

                    switch(player)
                    
                    // Depending on the players choice the code will respond with one of the cases

                    {
                        case "ROCK":
                            if (computer == "ROCK")
                            {
                                Console.WriteLine("Its a draw!");
                            }
                            else if (computer == "PAPER")
                            {
                                Console.WriteLine("You lost!");
                                computerscore++;
                            }
                            else
                            {
                                Console.WriteLine("You won!");
                                playerscore++;
                            }
                            break;

                            // When the player choose rock, all the outcomes of computer

                        case "PAPER":
                            if (computer == "ROCK")
                            {
                                Console.WriteLine("You won!");
                                playerscore++;
                            }
                            else if (computer == "PAPER")
                            {
                                Console.WriteLine("Its a draw!");
                            }
                            else
                            {
                                Console.WriteLine("You lost!");
                                computerscore++;
                            }
                            break;

                            // When the player choose paper, all the outcomes of computer

                        case "SCISSORS":
                            if (computer == "ROCK")
                            {
                                Console.WriteLine("You Lost!");
                                computerscore++;
                            }
                            else if (computer == "PAPER")
                            {
                                Console.WriteLine("You won!");
                                playerscore++;
                            }
                            else
                            {
                                Console.WriteLine("Its a draw!");
                            }
                            break;

                            // When the player choose scissors, all the outcomes of computer

                    }
                    Console.WriteLine("Player Score - " + playerscore + " | Computer Score - " + computerscore);
                    Console.WriteLine("Press Enter to continue!");
                    Console.ReadLine();
                }
                
                if (playerscore == 3)
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine(@"
██╗    ██╗██╗███╗   ██╗███╗   ██╗███████╗██████╗ ██╗
██║    ██║██║████╗  ██║████╗  ██║██╔════╝██╔══██╗██║
██║ █╗ ██║██║██╔██╗ ██║██╔██╗ ██║█████╗  ██████╔╝██║
██║███╗██║██║██║╚██╗██║██║╚██╗██║██╔══╝  ██╔══██╗╚═╝
╚███╔███╔╝██║██║ ╚████║██║ ╚████║███████╗██║  ██║██╗
 ╚══╝╚══╝ ╚═╝╚═╝  ╚═══╝╚═╝  ╚═══╝╚══════╝╚═╝  ╚═╝╚═╝
                         ");
                        

                        
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("You Won the Game!");
                        Console.WriteLine("Press Enter to return to menu!");
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine(@" 
  ██████╗  █████╗ ███╗   ███╗███████╗     ██████╗ ██╗   ██╗███████╗██████╗ ██╗
 ██╔════╝ ██╔══██╗████╗ ████║██╔════╝    ██╔═══██╗██║   ██║██╔════╝██╔══██╗██║
 ██║  ███╗███████║██╔████╔██║█████╗      ██║   ██║██║   ██║█████╗  ██████╔╝██║
 ██║   ██║██╔══██║██║╚██╔╝██║██╔══╝      ██║   ██║╚██╗ ██╔╝██╔══╝  ██╔══██╗╚═╝
 ╚██████╔╝██║  ██║██║ ╚═╝ ██║███████╗    ╚██████╔╝ ╚████╔╝ ███████╗██║  ██║██╗
  ╚═════╝ ╚═╝  ╚═╝╚═╝     ╚═╝╚══════╝     ╚═════╝   ╚═══╝  ╚══════╝╚═╝  ╚═╝╚═╝
                         ");
                        
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Press Enter to return to menu!");
                        Console.ReadLine();
                    }
                
            }
        }
            else if (game == "2")
    // this input sends the user to tic tac toe
             {
                Console.Clear();
                Console.Clear();
                
                Console.ForegroundColor = ConsoleColor.Yellow;
                for (int i = 0; i < 50; i++)
                {
                    Console.Write("- ");
                }
                Console.WriteLine();
                Console.WriteLine();
                
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(@"
████████╗██╗ ██████╗    ████████╗ █████╗  ██████╗    ████████╗ ██████╗ ███████╗
╚══██╔══╝██║██╔════╝    ╚══██╔══╝██╔══██╗██╔════╝    ╚══██╔══╝██╔═══██╗██╔════╝
   ██║   ██║██║            ██║   ███████║██║            ██║   ██║   ██║█████╗
   ██║   ██║██║            ██║   ██╔══██║██║            ██║   ██║   ██║██╔══╝
   ██║   ██║╚██████╗       ██║   ██║  ██║╚██████╗       ██║   ╚██████╔╝███████╗
   ╚═╝   ╚═╝ ╚═════╝       ╚═╝   ╚═╝  ╚═╝ ╚═════╝       ╚═╝    ╚═════╝ ╚══════╝
                   ");

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Welcome to Tic, Tac Toe!");
                Console.WriteLine("The Rules are simple!");
                Console.WriteLine("Find a Friend and first person to align 3 X's or 3 O's wins! ");
                Console.WriteLine("Player one plays as O and Player two plays as X");
                Console.WriteLine("Have Fun!");
                Console.WriteLine("Press Enter to Continue");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Yellow;
                for (int i = 0; i < 50; i++)
                {
                    Console.Write("- ");
                }
                Console.ForegroundColor = ConsoleColor.White;
                Console.ReadLine();
                
                while(winner() == "" && Turns < 9)
                {
                    Console.Clear();
                    PrintGrid();
                    
                    if (PLAYER1)
                    {
                        Console.WriteLine("Player 1's Turn!");
                    }
                    else
                    {   
                        Console.WriteLine("Player 2's Turn!");
                    }
                    string input = Console.ReadLine();
                    int boardChoice = Convert.ToInt32(input) - 1;
                    
                    if (board[boardChoice] == "X" || board[boardChoice] == "O")
                        {
                            Console.WriteLine("Square Taken!");
                            Thread.Sleep(1000);
                            continue;
                        }
                    else if (board.Contains(input))
                    {
                        
                        if (board[boardChoice] != "X" && board[boardChoice] != "O")
                        {
                        if (PLAYER1)
                        {
                            
                            board[boardChoice] = "O";
                            Turns++;

                        }
                        else if (!PLAYER1)
                        {
                            board[boardChoice] = "X";

                            Turns++;
                        }
      
                        PLAYER1 = !PLAYER1;
                        }
                        
                    }
                    
                    
                    
                }
                Console.Clear();
                    PrintGrid();

                    string victor = winner();

                    if (victor == "O")
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Cyan;

                        Console.WriteLine(@"
██████╗ ██╗      █████╗ ██╗   ██╗███████╗██████╗      ██╗    ██╗    ██╗██╗███╗   ██╗███████╗██╗
██╔══██╗██║     ██╔══██╗╚██╗ ██╔╝██╔════╝██╔══██╗    ███║    ██║    ██║██║████╗  ██║██╔════╝██║
██████╔╝██║     ███████║ ╚████╔╝ █████╗  ██████╔╝    ╚██║    ██║ █╗ ██║██║██╔██╗ ██║███████╗██║
██╔═══╝ ██║     ██╔══██║  ╚██╔╝  ██╔══╝  ██╔══██╗     ██║    ██║███╗██║██║██║╚██╗██║╚════██║╚═╝
██║     ███████╗██║  ██║   ██║   ███████╗██║  ██║     ██║    ╚███╔███╔╝██║██║ ╚████║███████║██╗
╚═╝     ╚══════╝╚═╝  ╚═╝   ╚═╝   ╚══════╝╚═╝  ╚═╝     ╚═╝     ╚══╝╚══╝ ╚═╝╚═╝  ╚═══╝╚══════╝╚═╝
                        ");
                    }
                    else if (victor == "X")
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine(@"
██████╗ ██╗      █████╗ ██╗   ██╗███████╗██████╗      ██████╗      ██╗    ██╗██╗███╗   ██╗███████╗██╗
██╔══██╗██║     ██╔══██╗╚██╗ ██╔╝██╔════╝██╔══██╗     ╚════██╗     ██║    ██║██║████╗  ██║██╔════╝██║
██████╔╝██║     ███████║ ╚████╔╝ █████╗  ██████╔╝      █████╔╝     ██║ █╗ ██║██║██╔██╗ ██║███████╗██║
██╔═══╝ ██║     ██╔══██║  ╚██╔╝  ██╔══╝  ██╔══██╗     ██╔═══╝      ██║███╗██║██║██║╚██╗██║╚════██║╚═╝
██║     ███████╗██║  ██║   ██║   ███████╗██║  ██║     ███████╗     ╚███╔███╔╝██║██║ ╚████║███████║██╗
╚═╝     ╚══════╝╚═╝  ╚═╝   ╚═╝   ╚══════╝╚═╝  ╚═╝     ╚══════╝      ╚══╝╚══╝ ╚═╝╚═╝  ╚═══╝╚══════╝╚═╝
                        ");
                    }
                    else
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine(@"
██████╗ ██████╗  █████╗ ██╗    ██╗██╗
██╔══██╗██╔══██╗██╔══██╗██║    ██║██║
██║  ██║██████╔╝███████║██║ █╗ ██║██║
██║  ██║██╔══██╗██╔══██║██║███╗██║╚═╝
██████╔╝██║  ██║██║  ██║╚███╔███╔╝██╗
╚═════╝ ╚═╝  ╚═╝╚═╝  ╚═╝ ╚══╝╚══╝ ╚═╝
                        ");
                    }
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Press Enter to return to menu!");
                        Console.ReadLine();

                string winner()
                {
                    if (board[0] == board[1] && board[1] == board[2]) return board[0].ToString();
                    else if (board[0] == board[3] && board[3] == board[6]) return board[0].ToString();
                    else if (board[0] == board[4] && board[4] == board[8]) return board[0].ToString();

                    else if (board[3] == board[4] && board[4] == board[5]) return board[3].ToString();
                    else if (board[6] == board[7] && board[7] == board[8]) return board[6].ToString();
                    
                    else if (board[1] == board[4] && board[4] == board[7]) return board[1].ToString();
                    
                    else if (board[2] == board[5] && board[5] == board[8]) return board[2].ToString();
                    else if (board[2] == board[4] && board[4] == board[6]) return board[2].ToString();
                    // If one of these combonations is found then there is a winner
                    // Converts to string so we can determine winner

                    return ""; // No winner
                }
                
                void PrintGrid()
                {
                
                for (int i = 0; i < 3; i++)
                {
                    
                    Console.WriteLine(" -----------------------");
                    Console.WriteLine(" |     | |     | |     |");
                    
                    for (int k = 0; k < 3; k++)
                    {
                        Console.Write(" |  ");
                        Console.Write(board[i * 3 + k] + "  |");
                    }
                    Console.WriteLine();
                    Console.WriteLine(" |     | |     | |     |");
                }
                
                Console.WriteLine(" -----------------------");
                
                }
            }
            else 
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
                for (int i = 0; i < 50; i++)
    {
        Console.Write("- ");
    }
    // Loop allows lines to continuosly be printed without having to indivually write them in code
    Console.WriteLine("");
    Console.WriteLine("");  

            
                Console.ForegroundColor = ConsoleColor.Cyan;
                
                Console.WriteLine(@"
 ██████╗  █████╗ ███╗   ███╗███████╗  ██████╗ ███╗   ██╗██╗
██╔════╝ ██╔══██╗████╗ ████║██╔════╝ ██╔═══██╗████╗  ██║██║
██║  ███╗███████║██╔████╔██║█████╗   ██║   ██║██╔██╗ ██║██║
██║   ██║██╔══██║██║╚██╔╝██║██╔══╝   ██║   ██║██║╚██╗██║╚═╝ 
╚██████╔╝██║  ██║██║ ╚═╝ ██║███████╗ ╚██████╔╝██║ ╚████║██╗
 ╚═════╝ ╚═╝  ╚═╝╚═╝     ╚═╝╚══════╝  ╚═════╝ ╚═╝  ╚═══╝╚═╝
 ");
            
                Console.ForegroundColor = ConsoleColor.White;


                Console.WriteLine();
                Console.WriteLine("Welcome to Text based Gaming!");
                Console.WriteLine("This Applications offers 2 different games:");
                Console.WriteLine("     - Rock, Paper, Scissors: Play against the computer! ");
                Console.WriteLine("     - Tic Tac toe: Play alongside a friend next to you!");
                Console.WriteLine();
                Console.WriteLine("Press 1 if you wish to play Rock, Paper, Scissors!");
                Console.WriteLine("Press 2 if you would like to play Tic Tac Toe!");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Yellow;
                for (int i = 0; i < 50; i++)
                {
                    Console.Write("- ");
                }
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("ERROR, Invalid Input!");
                Console.WriteLine("Please Enter 1 or 2 to select your game");
                Thread.Sleep(1000);
                continue;
            }
}
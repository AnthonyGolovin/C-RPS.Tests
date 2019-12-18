namespace ToDoList.Models
{
  public class Game
  {
    public string Player1 { get; set;}
    public string Player2 { get; set;}
  
    public Game(string player1, string player2)
    {
      Player1 = player1;
      Player2 = player2;
    }

    public string GameResult(string player1, string player2)
    {
      string Paper = "Paper Wins";
      string Rock = "Rock Wins";
      string Scissors = "Scissors Wins";
      string Tie = "Its a Tie";
      
      if(player1 == "Rock" && player2 == "Paper" || player2 == "Rock" && player1 == "Paper" )
      {
        return Paper;
      }
      if(player1 == "Paper" && player2 == "Scissors" || player2 == "Paper" && player1 == "Scissors")
      {
        return Scissors;
      }
      if(player1 == "Rock" && player2 == "Scissors" || player1 == "Scissors" && player2 == "Rock")
      {
        return Rock;
      }
      if(Player1 == Player2)
      {
        return Tie;
      }
      else 
      {
        return "";
      }
    }
  }
}
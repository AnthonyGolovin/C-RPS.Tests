using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToDoList.Models;

namespace ToDoList.Tests
{
  [TestClass]
  public class ItemTest
  {
    [TestMethod]
    public void GameResult_ReturnsString_StringReturned()
    {
      Game player = new Game("Rock", "Paper");
      string result = player.GameResult("Rock" , "Paper");
      Assert.AreEqual(result, "Paper Wins");
    }

  }
}
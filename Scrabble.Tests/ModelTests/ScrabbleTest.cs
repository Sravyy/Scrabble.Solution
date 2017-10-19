using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using Scrabble;

namespace Scrabble.Tests
{
  [TestClass]
  public class ScrabbleTests
  {
    [TestMethod]
    public void GetScore_Scrabble_int()
    {
      //Arrange
      Scrabble newScrab = new Scrabble("DOG");
      var output = 5;
      //Act
      int result = newScrab.GetScore();
      //Assert
      Assert.AreEqual(output, result);
    }
    [TestMethod]
    public void GetScore_LongWord_int()
    {
      //Arrange
      Scrabble newScrab = new Scrabble("AEIOUJ");
      var output = 13;
      //Act
      int result = newScrab.GetScore();
      //Assert
      Assert.AreEqual(output, result);
    }
  }
}

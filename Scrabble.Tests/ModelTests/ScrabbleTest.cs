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
      Scrabble newScrab = new Scrabble("iu");
      var output = 2;
      //Act
      int result = newScrab.GetScore();
      //Assert
      Assert.AreEqual(output, result);
    }
    [TestMethod]
    public void GetScore_Numbers_int()
    {
      //Arrange
      Scrabble newScrab = new Scrabble("2312sadasSDD");
      var output = 11;
      //Act
      int result = newScrab.GetScore();
      //Assert
      Assert.AreEqual(output, result);
    }
  }
}

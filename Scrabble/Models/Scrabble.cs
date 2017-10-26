using System;
using System.Collections.Generic;

namespace Scrabble
{
  public class Scrabble
  {
    private string _input;

    public Scrabble(string input)
    {
      _input = input.ToUpper();
    }

    public string GetInput()
    {
      return _input;
    }

    public int GetScore()
    {
      List<string> onePointLetters = new List<string> {"1", "A", "E", "I", "O", "U", "L", "N", "R", "S", "T"};
  		List<string> twoPointLetters = new List<string> {"2", "D", "G"};
      List<string> threePointLetters = new List<string> {"3", "B", "C", "M", "P"};
      List<string> fourPointLetters = new List<string> {"4", "F", "H", "V", "W", "Y"};
      List<string> fivePointLetters = new List<string> {"5", "K"};
      List<string> eightPointLetters = new List<string> {"8","J", "X"};
      List<string> tenPointLetters = new List<string> {"10","Q", "Z"};
      var score = 0;
      for (int i=0; i < _input.Length; i++)
      {
        if ((_input[i]>='A'&& _input[i]<='Z'))
       {
         List<List<string>> letterLists = new List<List<string>> {onePointLetters, twoPointLetters,threePointLetters,fourPointLetters,fivePointLetters,eightPointLetters,tenPointLetters};

     		foreach (List<string> letters in letterLists)
     		{
     			if (letters.Contains(_input[i].ToString()))
     			{
     				score += (int.Parse(letters[0]));
     			}
     		}
       }
       else
       {
         return 0;
       }
    }
    return score;
  }
}
}

using System;
using System.Collections.Generic;

public class Program
{
	public static void Main()
	{
		List<char> onePointLetters = new List<char> {'1','a','r','w'};
		List<char> twoPointLetters = new List<char> {'2','t','q','h'};

		char myChar = 't';

		List<List<char>> letterLists = new List<List<char>> {onePointLetters, twoPointLetters};

		foreach (List<char> letters in letterLists)
		{
			if (letters.Contains(myChar))
			{
				Console.WriteLine(Char.GetNumericValue(letters[0]));
			}
		}
	}
}

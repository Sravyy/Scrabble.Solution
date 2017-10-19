using System;
using System.Collections.Generic;

namespace Palindrome
{
  public class Palindrome
  {
    private string _input;

    public Palindrome(string input)
    {
      _input = input;
    }
    public bool IsPalindrome()
    {
      string SpecialCharRmInput="";
      for (int i=0; i<=_input.Length-1; i++)
      {
        if ((_input[i]>='0'&& _input[i]<='9')|| (_input[i]>='a'&& _input[i]<='z') ||(_input[i]>='A'&& _input[i]<='Z'))
       {
        SpecialCharRmInput += _input[i].ToString().ToUpper();
       }

      }
      string ReverseInput="";
      for (int i=SpecialCharRmInput.Length-1; i>=0; i--)
      {
          ReverseInput += SpecialCharRmInput[i].ToString();
      }
      if(SpecialCharRmInput == ReverseInput)
      {
        return true;
      }
      else
      {
        return false;
      }
    }
  }
}

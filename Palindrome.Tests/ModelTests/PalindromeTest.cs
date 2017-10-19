using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using Palindrome;

namespace Palindrome.Tests
{

  [TestClass]
  public class PalindromeTests
  {
    [TestMethod]
    public void IsPalindrome_compareWord_True()
    {
      Palindrome newString = new Palindrome();
      Assert.AreEqual(true, newString.IsPalindrome("madam"));
    }
    [TestMethod]
    public void IsPalindrome_compare_False()
    {
      Palindrome newString = new Palindrome();
      Assert.AreEqual(false, newString.IsPalindrome("mad"));
    }
    [TestMethod]
    public void IsPalindrome_compareStrings_True()
    {
      Palindrome newString = new Palindrome();
      Assert.AreEqual(true, newString.IsPalindrome("no lemon, no melon"));
    }
    [TestMethod]
    public void IsPalindrome_compareStrings_False()
    {
      Palindrome newString = new Palindrome();
      Assert.AreEqual(false, newString.IsPalindrome("no lemon, no"));
    }
    [TestMethod]
    public void IsPalindrome_compareNumbers_True()
    {
      Palindrome newString = new Palindrome();
      Assert.AreEqual(true, newString.IsPalindrome("121"));
    }
    [TestMethod]
    public void IsPalindrome_compareNumbers_False()
    {
      Palindrome newString = new Palindrome();
      Assert.AreEqual(false, newString.IsPalindrome("1214"));
    }
    [TestMethod]
    public void IsPalindrome_compareNumbersWithingString_True()
    {
      Palindrome newString = new Palindrome();
      Assert.AreEqual(true, newString.IsPalindrome("mad121dam"));
    }
    [TestMethod]
    public void IsPalindrome_compareCapitalString_True()
    {
      Palindrome newString = new Palindrome();
      Assert.AreEqual(true, newString.IsPalindrome("mADam"));
    }
    [TestMethod]
    public void IsPalindrome_compareStringwithSpclChars_True()
    {
      Palindrome newString = new Palindrome();
      Assert.AreEqual(true, newString.IsPalindrome("mADam 12 1 M ad ,# aM"));
    }



  }
}

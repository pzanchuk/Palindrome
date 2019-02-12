using System;

  class Program
  {
// ==========================String Checker Method==================================
    public static bool IsStringPalindrome(string phrase)
    {
      int i = 0;
      int j = phrase.Length - 1;
      while (i<j)
        {
            if (phrase[i] != phrase[j])
                return false;


            i++;
            j--;
        }

      return true;
    }
// ==========================Integer Checker Method==================================
    public static bool IsIntegerPalindrome(int number)
    {
      int holder = number;
      int num = 0;
      while(number != 0)
      {
        num = (num * 10) + (number % 10) ;
        number = number / 10;
      }
      if(num == holder)
      {
        return true;
      }else
      {
        return false;
      }
    }
// ==========================Check Again Method==================================
    public static void CheckAgain()
    {
      Console.WriteLine("Would you like to check again? (Y or N): ");
      string yesOrNo = Console.ReadLine();
      if(yesOrNo == "Y" || yesOrNo == "y")
      {
        Main();
      }
    }

    public static void Main()
    {

      Console.WriteLine("=================Palindrome Checker===================");
      Console.WriteLine("Would you like to check a string or an Integer? (S for String/ I for Integer)");
      string stringOrInteger = Console.ReadLine();
      if( stringOrInteger == "S")
      {
        Console.WriteLine("Please enter a word/phrase: ");
        string input = Console.ReadLine();
        string inputNoSpaces = input.Replace(" ", string.Empty).ToLower();
        Console.WriteLine(IsStringPalindrome(inputNoSpaces));
        CheckAgain();
      }else
      {
        Console.WriteLine("Please enter a number: ");
        int inputForInteger = int.Parse(Console.ReadLine());
        Console.WriteLine(IsIntegerPalindrome(inputForInteger));
        CheckAgain();
      }
    }
}

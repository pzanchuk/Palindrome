using System;

  class Program
  {

    public static bool IsPalindrome(string phrase)
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

    public static void Main()
    {

      Console.WriteLine("====================================");
      Console.WriteLine("Please enter a word/phrase: ");
      string input = Console.ReadLine();
      string inputNoSpaces = input.Replace(" ", string.Empty).ToLower();
      Console.WriteLine(IsPalindrome(inputNoSpaces));
      Console.WriteLine("Would you like to check another string? (Y or N): ");
      string yesORno = Console.ReadLine();
      if(yesORno == "Y" || yesORno =="y")
      {
        Main();
      }
    }
}

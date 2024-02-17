using System;

class Program {
  public static void Main (string[] args) {
      string input = "";
      string output = "";
    
      Console.WriteLine ("Enter something:");

      while (true)
      {
        input = Console.ReadLine();
        if (input == "exit")
        {
          Console.WriteLine("Closing program....");
          break;
        }
        else
        {
          output += input + "  ";
          Console.WriteLine(output);
        }
      }
  }
}
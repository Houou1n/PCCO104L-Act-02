using System;

class Program {
  public static void Main (string[] args) {

    for (int i = 1; i < 101; i++)
    { 
      if (i % 3 == 0 && i % 5 > 0)
      {
        Console.WriteLine(i + " - Foo");
      }
      else if (i % 3 > 0 && i % 5 == 0)
      {
        Console.WriteLine(i + " - Bar");
      }
      else if (i % 3 == 0 && i % 5 == 0)
      {
        Console.WriteLine(i + "- Foobar");
      }
      else if (i % 3 > 0 && i % 5 > 0)
      {
        Console.WriteLine(i);
      }
    }
  }
}
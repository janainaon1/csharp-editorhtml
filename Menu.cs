public static class Menu
{
  public static void Show()
  {
    Console.Clear();
    Console.BackgroundColor = ConsoleColor.DarkGray;
    Console.ForegroundColor = ConsoleColor.Black;

    DrawScreen();
  }

  public static void DrawScreen()
  {
    Console.Write("+");

    for (int column = 0; column <= 30; column++)
      Console.Write("-");

    Console.Write("+");
    Console.Write("\n");

    for (int line = 0; line <= 10; line++)
    {
      Console.Write("|");
      for (int column =0; column <= 30; column++)
        Console.Write(" ");

        Console.Write("|");
        Console.Write("\n");
    }

    Console.Write("+");

    for (int column = 0; column <= 30; column++)
      Console.Write("-");

    Console.Write("+");
    Console.Write("\n");
  }
}

public static class Menu
{
  public static void Show()
  {
    Console.Clear();
    Console.BackgroundColor = ConsoleColor.DarkGray;
    Console.ForegroundColor = ConsoleColor.Black;

    DrawScreen();
  }

  public static void DrawScreen(short numberColumns = 30, short numberLines = 10)
  {
    DrawColumns(numberColumns);

    DrawLines(numberColumns, numberLines);

    DrawColumns(numberColumns);
  }

  private static void DrawColumns(short numberColumns)
  {
    Console.Write("+");

    for (int column = 0; column <= numberColumns; column++)
      Console.Write("-");

    Console.Write("+");
    Console.Write("\n");
  }

  private static void DrawLines(short numberColumns, short numberLines)
  {
    for (int line = 0; line <= numberLines; line++)
    {
      Console.Write("|");
      for (int column = 0; column <= numberColumns; column++)
        Console.Write(" ");

      Console.Write("|");
      Console.Write("\n");
    }
  }
}
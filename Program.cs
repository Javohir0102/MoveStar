using System;

class Program
{
    static void Main()
    {
        ConsoleKeyInfo keyInfo;
        int cursorLeft = Console.CursorLeft;
        int cursorTop = Console.CursorTop;

        Console.WriteLine("Use arrow keys to move the cursor. Press 'Esc' to exit.");

        while (true)
        {
            keyInfo = Console.ReadKey(true);

            Console.Clear();
            switch (keyInfo.Key)
            {
                case ConsoleKey.LeftArrow:
                    if (cursorLeft > 0)
                    {
                        cursorLeft--;
                        Console.SetCursorPosition(cursorLeft, cursorTop);
                        Console.Write('*');
                    }
                    break;
                case ConsoleKey.RightArrow:
                    if (cursorLeft < Console.WindowWidth - 1)
                    {
                        cursorLeft++;
                        Console.SetCursorPosition(cursorLeft, cursorTop);
                        Console.Write('*');
                    }
                    break;
                case ConsoleKey.UpArrow:
                    if (cursorTop > 0)
                    {
                        cursorTop--;
                        Console.SetCursorPosition(cursorLeft, cursorTop);
                        Console.Write('*');
                    }
                    break;
                case ConsoleKey.DownArrow:
                    if (cursorTop < Console.WindowHeight - 1)
                    {
                        cursorTop++;
                        Console.SetCursorPosition(cursorLeft, cursorTop);
                        Console.Write('*');
                    }
                    break;
                case ConsoleKey.Escape:
                    return; // Exit the loop and program
            }
        }
    }
}
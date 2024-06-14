# MoveStar

this program is designed to move the information entered by the user. You can move four directions by cursor.

## Basic function
- The user enter elements on terminal.
- Entered elements are moved by user

## Code explanation

```cs
        Console.Title = "Move star with cursor";
        Console.Write("Enter the moving element -> ");
        string movingElement = Console.ReadLine();

        ConsoleKeyInfo keyInfo;
        int cursorLeft = Console.CursorLeft;
        int cursorTop = Console.CursorTop;

You can see all codes followed pictures

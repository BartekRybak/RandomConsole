using System;

namespace RandomConsole
{
	class MainClass
	{
		public static Random _Random = new Random();

		public static bool DarkMode = false;

		public static void Main(string[] args)
		{
			Console.Title = "Random Screen by ShadeHero";
			Console.SetWindowSize(60, 60);
			Console.SetBufferSize(60, 60);
			Console.SetCursorPosition(0,0);
			Console.SetCursorPosition(0, 0);

			if (!DarkMode)
			{
				Console.BackgroundColor = ConsoleColor.White;
			}

			while (true)
			{
				int bs_x = Console.BufferWidth;
				int bs_y = Console.BufferHeight;

				int r_x = _Random.Next(0, Console.WindowWidth);
				int r_y = _Random.Next(0, Console.BufferHeight - 1);

				Console.SetCursorPosition(r_x, r_y);
				Console.ForegroundColor = GetRandomConsoleColor();
				Console.Write(GetRandomChar());
			}

		}

		static ConsoleColor GetRandomConsoleColor(){
			var consoleColors = Enum.GetValues(typeof(ConsoleColor));
			return (ConsoleColor)consoleColors.GetValue(_Random.Next(consoleColors.Length));
		}

		static char GetRandomChar(){
			return (char)_Random.Next(32, 125);
		}
	}
}

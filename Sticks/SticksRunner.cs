using System;

namespace Sticks;

public static class SticksRunner
{
	public static void Main()
	{
		Console.WriteLine("Welcome to the game of Sticks!");

		int sticks = SticksGame.Prompt("How many sticks should the game start with? ");
		int maxTake = SticksGame.Prompt("What is that maximum number of sticks a player can take? ");

		Console.WriteLine();
		Console.WriteLine($"There are {sticks} sticks in the pile.");
		Console.WriteLine($"On each turn, you can take up to {maxTake} sticks.");
		Console.WriteLine("The player who takes the last stick loses.");
		Console.WriteLine();

		SticksGame game = new SticksGame(sticks, maxTake);
		game.Play();
	}
}

namespace Sticks.Players;

public class Human : IPlayer
{
	public Human(string name)
	{
		Name = name;
	}
	public string Name { get; }
	public int Take(int sticksLeft, int maxTake)
	{
		return SticksGame.Prompt($"[{Name}] Take {SticksGame.MinTake}-{maxTake} sticks: ");
	}
}

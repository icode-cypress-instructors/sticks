/*
 * INSTRUCTOR NOTE:
 * Students should implement this class on their own.
 */

namespace Sticks.Players;

public class SmartBot : Bot
{
	public override int Take(int sticksLeft, int maxTake) => (sticksLeft - 1) % (maxTake + 1);
}

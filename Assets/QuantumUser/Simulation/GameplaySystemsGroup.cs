namespace Quantum
{
	using UnityEngine.Scripting;
	[Preserve]
	public class GameplaySystemsGroup : SystemMainThreadGroup
	{
		public GameplaySystemsGroup(string update, params SystemMainThread[] children) : base(update, children)
		{
		}
	}
}
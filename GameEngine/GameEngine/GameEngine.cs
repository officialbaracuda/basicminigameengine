using System;

namespace GameEngine
{
	public partial class GameEngine
	{
		public delegate void GameplayUpdate();

		public void init()
		{
			Console.CursorVisible = false;
			while (true)
			{
				inputUpdate();
				play();
				render();
			}
		}
	}
}

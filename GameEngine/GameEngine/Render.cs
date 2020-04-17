using System;
using System.Collections.Generic;
using System.Text;

namespace GameEngine
{
	public partial class GameEngine
	{
		public Item player = new Item(1,1,'P');
		public Item goal = new Item(5, 5, 'G');
		public void render()
		{
			foreach (Item item in initMap())
			{
				Console.SetCursorPosition(item.x, item.y);
				Console.Write(item.letter);
			}

			Console.SetCursorPosition(player.x, player.y);
			Console.Write(player.letter);

			Console.SetCursorPosition(goal.x, goal.y);
			Console.Write(goal.letter);
		}

		public class Item {
			public int x;
			public int y;
			public char letter;

			public Item(int x, int y, char letter)
			{
				this.x = x;
				this.y = y;
				this.letter = letter;
			}
		}

		public void updatePlayerPos(int x, int y) {
			Console.SetCursorPosition(player.x, player.y);
			Console.Write(' ');
			player.x += x;
			player.y += y;
		}

		private IList<Item> initMap()
		{
			IList<Item> map = new List<Item>();
			for (int i = 0; i < 10; i++) {
				Item item = new Item(i,0,'x');
				map.Add(item);
			}
			for (int i = 0; i < 10; i++)
			{
				Item item = new Item(i, 9, 'x');
				map.Add(item);
			}
			for (int i = 0; i < 9; i++)
			{
				Item item = new Item(0, i, 'x');
				map.Add(item);
			}
			for (int i = 0; i < 9; i++)
			{
				Item item = new Item(9, i, 'x');
				map.Add(item);
			}

			return map;
		}
	} 


}

using System;

namespace GameEngine
{
    public partial class GameEngine
    {
        public void play()
        {

            if (w.down)
            {
                updatePlayerPos(0, -1);
            }

            if (a.down)
            {
                updatePlayerPos(-1, 0);
            }

            if (s.down)
            {
                updatePlayerPos(0, 1);
            }

            if (d.down)
            {
                updatePlayerPos(1, 0);
            }

            if (player.x == goal.x && player.y == goal.y) {
                Console.SetCursorPosition(0, 10);
                Console.WriteLine("Congratulations, You Win");
            }
        }
    }
}

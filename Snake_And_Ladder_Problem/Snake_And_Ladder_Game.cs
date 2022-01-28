using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_And_Ladder_Problem
{
    public class Snake_And_Ladder_Game
    {
        int player_pos = 0;
        Random random = new Random();
        public int DiceRoll()
        {
            int dice = random.Next(1, 7);
            return dice;
        }
        public void Play()
        {
            const int LADDER = 1, SNAKE = 2;
            int choice = random.Next(1, 3);
            int diceoutcome = DiceRoll();
            switch (choice)
            {
                case LADDER:
                    player_pos += diceoutcome;
                    break;
                case SNAKE:
                    player_pos -= diceoutcome;
                    break;
                default:
                    break;
            }

        }
    }
}


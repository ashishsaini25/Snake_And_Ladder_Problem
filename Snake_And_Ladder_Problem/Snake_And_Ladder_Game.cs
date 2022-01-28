using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_And_Ladder_Problem
{
    public class Snake_And_Ladder_Game
    {
        int player_pos = 0,count=0;
        Random random = new Random();
        public int DiceRoll()
        {
            int dice = random.Next(1, 7);
            count++;
            return dice;
        }
        public int Play()
        {
            const int LADDER = 1, SNAKE = 2;
                int choice = random.Next(1, 3);
                int diceoutcome = DiceRoll();
                switch (choice)
                {
                    case LADDER:
                    if (player_pos + diceoutcome <= 100)
                    {
                        player_pos += diceoutcome;
                        Play();
                    }
                        break;
                    case SNAKE:
                        if(player_pos-diceoutcome > 0)
                        player_pos -= diceoutcome;
                        else
                        {
                            player_pos = 0;
                        }
                        break;
                    default:
                        break;
                }
            return player_pos;
            }

    }
}


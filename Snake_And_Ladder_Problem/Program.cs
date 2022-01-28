using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_And_Ladder_Problem
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Snake_And_Ladder_Game player1=new Snake_And_Ladder_Game();
           Snake_And_Ladder_Game player2=new Snake_And_Ladder_Game();
            Random random=new Random();
            int start = random.Next(1, 3);
            bool turn=true;
            if (start == 1)
                turn = true;
            if (start == 2)
                turn = false;
            bool flag = true;
            int pos1=0,pos2=0;
            while (flag)
            {
                if (turn)
                {
                    pos1=player1.Play();
                    turn = false;
                    Console.WriteLine("this was player 1 turn and he was in {0}", pos1);
                }
                else
                {
                    pos2=player2.Play();
                    turn = true;
                    Console.WriteLine("this was player 2 turn and he was in {0}", pos2);
                }
                if (pos1 == 100)
                {
                    Console.WriteLine("Player1 have won the game\n");
                    flag = false;
                }
                if (pos2 == 100)
                {
                    Console.WriteLine("Player2 have won the game\n");
                    flag = false;
                }


            }
        }
    }
}

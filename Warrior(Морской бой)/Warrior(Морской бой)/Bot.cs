using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warrior_Морской_бой_
{
    internal class Bot : Player       //Easy bot
    {
        public Bot(int[,] table, string name) : base(table, name)
        {
        }

        string fromIntToChar(in int index)
        {
            switch (index)
            {
                case 1:
                    return "A";
                case 2:
                    return "B";
                case 3:
                    return "C";
                case 4:
                    return "D";
                case 5:
                    return "E";
                case 6:
                    return "F";
                case 7:
                    return "G";
                case 8:
                    return "I";
                case 9:
                    return "J";
                case 10:
                    return "K";

                default:
                    return "Error";
            }
        }
        string coordinateGenerator()
        {
            Random random = new Random();
            int x =random.Next(1,11);
            int y = random.Next(1,11);

            string coordinates = "";
            coordinates += fromIntToChar(x);
            coordinates += y.ToString();

            return coordinates;
        }

        public override void attack(Player enemy) 
        {
            Console.WriteLine("Bot " + playerName + " is attacking!");

            bool step = true;
            string coordinate; 
            int x = 0;
            int y = 0;
            while (step)
            {
                if (hitCount == 20 || enemy.getHitCount() == 20)
                    return;

                coordinate = coordinateGenerator();
                Console.WriteLine("Bot request: " + coordinate);
                if (Coordinate(ref x, ref y, coordinate))
                {
                    string answer = enemy.requestAnswer(x, y);

                    switch (answer)
                    {
                        case "Missed":
                            Console.WriteLine("Missed");
                            return;
                        case "Hit":
                            Console.WriteLine("Hit");
                            playerTable.setAttackTable(x, y,true);
                            enemy.setPlayerTable(x, y, 2);
                            ++hitCount;
                            break;
                        case "Sank":
                            Console.WriteLine("Sank");
                            playerTable.setAttackTable(x, y, true);
                            enemy.setPlayerTable(x, y, 2);
                            ++hitCount;
                            break;                                  //there shall be more logic
                    }

                }
            }
        }
    }
}

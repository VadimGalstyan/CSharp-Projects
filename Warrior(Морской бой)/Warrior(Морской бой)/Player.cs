using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warrior_Морской_бой_
{
    internal class Player
    {
        protected Table playerTable;
        protected string playerName;
        protected int hitCount = 0;         //The table has 20 blocks that contain a part of boat or boat

        public Player(int[,] playerTable, in string playerName)
        {
            this.playerTable = new Table(playerTable);
            this.playerName = playerName;
        }
        protected int charToIndex(in char input)
        {
            switch (input)
            {
                case 'A':
                    return 0;
                case 'B':
                    return 1;
                case 'C':
                    return 2;
                case 'D':
                    return 3;
                case 'E':
                    return 4;
                case 'F':
                    return 5;
                case 'G':
                    return 6;
                case 'I':
                    return 7;
                case 'J':
                    return 8;
                case 'K':
                    return 9;

                default:
                    return -1;

            }

        }
        protected bool Coordinate(ref int x,ref int y,in string input)
        {
            if (input.Length < 2 ||  input.Length > 3)
                return false;
            if (charToIndex(input[0]) == -1)
                return false;

            if (input.Length == 2)
            {
                int tempX = 58 - input[1];
                int tempY = charToIndex(input[0]);

                if (tempX >=0 && tempX < 10 && tempY >= 0)
                {
                    x = tempX;
                    y = tempY;
                    return true;
                }
                else
                {
                    Console.WriteLine("Wrong input!");
                    return false;
                }
            }
            else
            {
                if(input.Length == 3 && input[1] == '1' && input[2] == '0')
                {
                    int tempX = 0;
                    int tempY = charToIndex(input[0]);

                    if (tempX >= 0 && tempX < 10 && tempY >= 0)
                    {
                        x = tempX;
                        y = tempY;
                        return true;
                    }
                    else
                    {
                        Console.WriteLine("Wrong input!");
                        return false;
                    }
                }
                else
                {
                    Console.WriteLine("Wrong input!");
                    return false;
                }
            }
        }

        protected bool surroundingCheck(in int x,in int y) //returns true if boat has 1 block,false if has more
        {
           
            if (x - 1 >= 0 && playerTable.getPlayerTable(x - 1, y) == 1)
            {
                return false;
            }
            if (x + 1 < 10 && playerTable.getPlayerTable(x + 1, y) == 1)
            {
                return false;
            }
            if (y - 1 >= 0 && playerTable.getPlayerTable(x, y - 1) == 1)
            {
                return false;
            }
            if (y + 1 < 10 && playerTable.getPlayerTable(x, y + 1) == 1)
            {
                return false;
            }

            return true;
        }
        public string requestAnswer(in int x, in int y)
        {
            if (playerTable.getPlayerTable(x,y) != 1 || playerTable.getPlayerTable(x, y) == 2)
            {
                return "Missed";
            }


            if(playerTable.getPlayerTable(x, y) == 1 )
            {
                if (surroundingCheck(x, y))
                {
                    return "Sank";
                }
                else
                {
                    return "Hit";
                }
            }
            return "Error";
        }
        public virtual  void attack(Player enemy)
        {
            Console.WriteLine(playerName + " is attacking!");
            printAttackTable();


            bool step = true;
            string coordinate; 
            int x = 0;
            int y = 0;
            while (step)
            {
                if (hitCount == 20 || enemy.getHitCount() == 20)
                    return;

                coordinate = Console.ReadLine();
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
                else
                {
                    Console.WriteLine("Wrong input!Try again!");
                }
            }
        }

        public int getHitCount()
        {
            return hitCount;
        }

        public void printPlayerTable()
        {
            playerTable.printPlayerTable();
        }

        public void printAttackTable()
        {
            playerTable.printAttackTable();
        }

        public void setPlayerTable(in int i, in int j, in int input)
        {
            playerTable.setPlayerTable(i, j,input); 
        }
    }
}

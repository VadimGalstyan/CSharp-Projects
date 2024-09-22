using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warrior_Морской_бой_
{
    internal class Table 
    {
        const int row = 10;
        const int col = 10;

        int[,] _playerTable;
        //=  new int[row,col]        //1 is part of boat,0 is empty block
        //                    {
        //                          { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
        //                          { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
        //                          { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
        //                          { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
        //                          { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
        //                          { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
        //                          { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
        //                          { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
        //                          { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
        //                          { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }

        //                    };
        bool[,] _attackTable = new bool[row, col]
                            {
                                { false, false, false, false, false, false, false, false, false, false },
                                { false, false, false, false, false, false, false, false, false, false },
                                { false, false, false, false, false, false, false, false, false, false },
                                { false, false, false, false, false, false, false, false, false, false },
                                { false, false, false, false, false, false, false, false, false, false },
                                { false, false, false, false, false, false, false, false, false, false },
                                { false, false, false, false, false, false, false, false, false, false },
                                { false, false, false, false, false, false, false, false, false, false },
                                { false, false, false, false, false, false, false, false, false, false },
                                { false, false, false, false, false, false, false, false, false, false }
                            };

        public Table(int[,] playerTable)
        {
            _playerTable = playerTable;
        }
        public void printPlayerTable()
        {
            for(int i = 0;i < 10;++i)
            {
                Console.Write((i == 0 ? "" : " ") + (10 - i) + "  ");
                for (int j = 0;j < 10;++j)
                {
                    Console.Write(_playerTable[i,j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("    A B C D E F G I J K");
        }

        public void printAttackTable()
        {
            for (int i = 0; i < 10; ++i)
            {
                Console.Write((i == 0 ? "" : " ")  + (10 - i) + "  ");
                for (int j = 0; j < 10; ++j)
                {
                    Console.Write(_attackTable[i,j] ? "X" : 0 + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("    A B C D E F G I J K");

        }


        public int getPlayerTable(in int i,in int j)
        {
            return _playerTable[i,j];
        }
        public bool getAttackTable(in int i, in int j)
        {
            return _attackTable[i, j];
        }

        public void setPlayerTable(in int i, in int j, in int input)
        {
            _playerTable[i, j] = input;
        }
        public void setAttackTable(in int i, in int j,in bool input)
        {
            _attackTable[i, j] = input;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku
{
    internal class Table
    {
        //private char[,] table = new char[9,9];  //For input with console

        //private char[,] table ={
        //                           { '3', '0', '6', '5', '0', '8', '4', '0', '0'},
        //                           { '5', '2', '0', '0', '0', '0', '0', '0', '0'},
        //                           { '0', '8', '7', '0', '0', '0', '0', '3', '1'},
        //                           { '0', '0', '3', '0', '1', '0', '0', '8', '0'},
        //                           { '9', '0', '0', '8', '6', '3', '0', '0', '5'},
        //                           { '0', '5', '0', '0', '9', '0', '6', '0', '0'},
        //                           { '1', '3', '0', '0', '0', '0', '2', '5', '0'},
        //                           { '0', '0', '0', '0', '0', '0', '0', '7', '4'},
        //                           { '0', '0', '5', '2', '0', '6', '3', '0', '0'}
        //                        };

        //private char[,] table = {
        //                            { '0', '0', '0', '2', '6', '0', '7', '0', '1' },
        //                            { '6', '8', '0', '0', '7', '0', '0', '9', '0' },
        //                            { '1', '9', '0', '0', '0', '4', '5', '0', '0' },
        //                            { '8', '2', '0', '1', '0', '0', '0', '4', '0' },
        //                            { '0', '0', '4', '6', '0', '2', '9', '0', '5' },
        //                            { '0', '5', '0', '0', '0', '3', '0', '2', '8' },
        //                            { '0', '0', '9', '3', '0', '0', '0', '7', '4' },
        //                            { '0', '4', '0', '0', '5', '0', '0', '3', '6' },
        //                            { '7', '0', '3', '0', '1', '8', '0', '0', '0' }
        //                        };

        private char[,] table =   {
                                    { '0', '0', '0', '0', '0', '0', '0', '0', '1' },
                                    { '0', '0', '0', '0', '0', '0', '0', '0', '0' },
                                    { '0', '0', '0', '0', '0', '0', '0', '0', '0' },
                                    { '0', '0', '0', '0', '0', '0', '0', '0', '0' },
                                    { '0', '0', '0', '0', '0', '0', '0', '0', '0' },
                                    { '0', '0', '0', '0', '0', '0', '0', '0', '0' },
                                    { '0', '0', '0', '0', '0', '0', '0', '0', '0' },
                                    { '0', '0', '0', '0', '0', '0', '0', '0', '0' },
                                    { '5', '0', '0', '0', '0', '0', '0', '0', '0' }
                                  };

        private bool rowCheck(char element, int row, int col)
        {
            if (element == '0')
                return true;

            for (int k = 0; k < 9; ++k)
            {
                if (k != col && element == table[row, k])
                {
                    return false;
                }
            }
            return true;

        }
        private bool colCheck(char element, int row, int col)
        {
            if (element == '0')
                return true;

            for (int k = 0; k < 9; ++k)
            {
                if (k != row && element == table[k, col])
                {
                    return false;
                }
            }
            return true;

        }

        private bool subgridCheck(char element, int row1, int col1)
        {
            if (element == '0')
            {
                return true;
            }

            int row = row1;
            int col = col1;

            if (row < 3)
            {
                row = 0;
            }
            else
            {
                if (row < 6)
                {
                    row = 3;
                }
                else
                {
                    row = 6;
                }
            }

            if (col < 3)
            {
                col = 0;
            }
            else
            {
                if (col < 6)
                {
                    col = 3;
                }
                else
                {
                    col = 6;
                }
            }

            for (int k = row; k < row + 3; ++k)
            {
                for (int l = col; l < col + 3; ++l)
                {

                    if ((k != row1 || l != col1) && element == table[k, l])
                    {
                        return false;
                    }
                }
            }
            return true;
        }


        public Table()
        {

            //char tempChar;
            //bool conversion;
            //for (int i = 0; i < 9; ++i)
            //{
            //    Console.WriteLine("Input the elements of row N" + (i + 1) + "(0 means that square is empty).");
            //    for (int j = 0; j < 9; ++j)
            //    {
            //        conversion = char.TryParse(Console.ReadLine(), out tempChar);
            //        if (!conversion)
            //        {
            //            Console.WriteLine("Wrong input!Try again!(from 0 to 9");
            //            --j;
            //            continue;
            //        }
            //        if (!char.IsDigit(tempChar))
            //        {
            //            Console.WriteLine("Wrong input!Try again!(from 0 to 9");
            //            --j;
            //            continue;
            //        }

            //        bool continuePoint = false;
            //        if (!rowCheck(tempChar, i, j))
            //        {
            //            Console.WriteLine("There is that digit in this row.Try again!");
            //            --j;
            //            continuePoint = true;
            //            break;
            //        }


            //        if (!continuePoint)
            //        {
            //            if (!colCheck(tempChar, i, j))
            //            {
            //                Console.WriteLine("There is that digit in this column.Try again!");
            //                --j;
            //                continuePoint = true;
            //                break;
            //            }

            //        }

            //        if (!continuePoint)
            //        {

            //            if (!subgridCheck(tempChar, i, j))
            //            {
            //                Console.WriteLine("There is that digit in this subgrid(3x3).Try again!");
            //                --j;
            //                continuePoint = true;
            //                break;
            //            }

            //        }

            //        table[i, j] = tempChar;
            //    }
            //}

        }



            public void printTable()
            {
                for (int i = 0; i < 9; ++i)
                {
                    if (i > 0 && i % 3 == 0)
                    {
                        Console.WriteLine();
                    }


                    for (int j = 0; j < 9; ++j)
                    {
                        if (j > 0 && j == 3 || j == 6)
                            Console.Write("| ");

                         Console.Write("|" + table[i, j]);  
                    }
                    Console.WriteLine("|");
                }
            }

            public bool Solve()
            {
                for (int i = 0; i < 9; ++i)
                {
                    for (int j = 0; j < 9; ++j)
                    {
                        if (table[i, j] == '0')
                        {
                            for (int k = 1; k <= 9; ++k)
                            {
                                char temporary = (char)('0' + k);
                                if (rowCheck(temporary, i, j) && colCheck(temporary, i, j) && subgridCheck(temporary, i, j))
                                {
                                    table[i, j] = temporary;
                                    if (Solve())
                                    {
                                        return true;
                                    }

                                    table[i, j] = '0';
                                }


                            }

                            return false;
                        }
                    }
                }
                return true;
            }

    }

}
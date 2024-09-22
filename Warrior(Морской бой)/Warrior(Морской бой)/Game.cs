using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warrior_Морской_бой_
{
    internal class Game
    {
        public void start(Player player1,Player player2)
        {
            while (player1.getHitCount() < 20 && player2.getHitCount() < 20)
            {
                player1.attack(player2);
                player2.attack(player1);
            }

            if( player1.getHitCount() == 20)
                Console.WriteLine("The winner is Player1!!!");
            if(player2.getHitCount() == 20)
                Console.WriteLine("The winner is Player2!!!");

            Console.WriteLine("Player1 tables.");
            Console.WriteLine("Player1 table:");
            player1.printPlayerTable();
            Console.WriteLine("Player1 attack table:");
            player1.printAttackTable();

            Console.WriteLine();

            Console.WriteLine("Player2 tables.");
            Console.WriteLine("Player2 table:");
            player2.printPlayerTable();
            Console.WriteLine("Player2 attack table:");
            player2.printAttackTable();
        }

        public void startWithBot(Player player1,Player bot)
        {
            while (player1.getHitCount() < 20 && bot.getHitCount() < 20)
            {
                player1.attack(bot);
                bot.attack(player1);
            }

            if (player1.getHitCount() == 20)
                Console.WriteLine("The winner is Player1!!!");
            if (bot.getHitCount() == 20)
                Console.WriteLine("The winner is Bot!!!");

            Console.WriteLine("Player1 tables.");
            Console.WriteLine("Player1 table:");
            player1.printPlayerTable();
            Console.WriteLine("Player1 attack table:");
            player1.printAttackTable();

            Console.WriteLine();

            Console.WriteLine("Bot tables.");
            Console.WriteLine("Bot table:");
            bot.printPlayerTable();
            Console.WriteLine("Bot attack table:");
            bot.printAttackTable();
        }
    }
}

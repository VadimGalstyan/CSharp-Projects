

using Warrior_Морской_бой_;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] player1Table = new int[10, 10]        //1 is part of boat,0 is empty block
                                {
                                      { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                                      { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                                      { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                                      { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                                      { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                                      { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                                      { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                                      { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                                      { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                                      { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }

                                };
            int[,] player2Table = new int[10, 10]        //1 is part of boat,0 is empty block
                                {
                                      { 1, 1, 1, 1, 0, 0, 0, 0, 0, 0 },
                                      { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                                      { 1, 0, 1, 1, 1, 0, 0, 0, 0, 0 },
                                      { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                                      { 1, 0, 1, 1, 1, 0, 0, 0, 0, 0 },
                                      { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                                      { 1, 0, 0, 1, 1, 0, 0, 0, 0, 0 },
                                      { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                                      { 1, 0, 0, 1, 1, 0, 1, 1, 0, 0 },
                                      { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }

                                };

            Player player1 = new Player(player1Table,"Player1");
            Player player2 = new Player(player2Table,"Player2");
            Bot bot = new Bot(player1Table, "Gio");
                
            Game game = new Game();
            game.startWithBot(player2 , bot);
            //game.start(player1,player2);

        }
    }
}

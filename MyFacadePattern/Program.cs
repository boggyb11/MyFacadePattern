using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyFacadePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            BossBattle bossBattle = new BossBattle();
            Player player = new Player("Ben");
            bool canFightBoss = bossBattle.CanChallengeBoss(player);

            Console.WriteLine($"Player {(canFightBoss ? "Can fight the boss!" : "cannot fight the boss")}");

            Console.ReadKey();
        }
    }
}

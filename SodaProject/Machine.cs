using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaProject
{
    class Machine
    {
        List<Coin> MachineCoins = new List<Coin>();
        Coin coin;
        Cans cans;
        public Machine()
        {
            
        }
        public void machineMenu()
        {
            Console.WriteLine("---------------------");
            Console.WriteLine("| (1)   [Grape]     |");
            Console.WriteLine("| (2)   [Orange]    |");
            Console.WriteLine("| (3)   [Meat]      |");
            Console.WriteLine("---------------------");
        }
        public void currentTotal()
        {
            coin.addCoins();
        }

    }
}

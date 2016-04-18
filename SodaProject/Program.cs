using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaProject
{
    class Program
    {
        static void Main(string[] args)
        {
            bool endProgram = false;
            while (endProgram == false)
            {
                Machine machine = new Machine();
                Coin newPocket = new Coin();
                machine.machineMenu();
                newPocket.addCoins();
                machine.addSoda();
                machine.startingMachineCoins();
                machine.inputCoins();
                Console.WriteLine(newPocket.coinContainer.Count);


                

                machine.purchaseSoda();
            }
            Console.ReadLine();
        }
    }
}

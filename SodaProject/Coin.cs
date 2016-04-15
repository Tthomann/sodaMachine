using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaProject
{
    class Coin
    {
        List<Coin> coinContainer = new List<Coin>();
        Quarter quarter;
        Nickle nickle;
        Dime dime;
        Penny penny;
        public double coinValue;
        int numberOfCoins;
        public Coin()
        {

        }
        public void addCoins()
        {
            for(numberOfCoins = 0; numberOfCoins < 20; numberOfCoins++)
            {
                coinContainer.Add(new Quarter());
            }
            for (numberOfCoins = 0; numberOfCoins < 20; numberOfCoins++)
            {
                coinContainer.Add(new Nickle());
            }
            for (numberOfCoins = 0; numberOfCoins < 10; numberOfCoins++)
            {
                coinContainer.Add(new Dime());
            }
            for (numberOfCoins = 0; numberOfCoins < 50; numberOfCoins++)
            {
                coinContainer.Add(new Penny());
            }
        }
    }
}

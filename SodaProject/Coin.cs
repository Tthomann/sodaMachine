using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaProject
{
    class Coin 
    {
        public List<Coin> coinContainer = new List<Coin>();
        public decimal coinValue;
        public decimal totalInputValue;
        int numberOfCoins;
        public Coin()
        {

        }
        public void addCoins()
        {
            for(numberOfCoins = 0; numberOfCoins < 20; numberOfCoins++)
            {
                coinContainer.Add(new Quarter());
              totalInputValue += 0.25m;
            }
            for (numberOfCoins = 0; numberOfCoins < 20; numberOfCoins++)
            {
                coinContainer.Add(new Nickle());
                totalInputValue += 0.15m;
            }
            for (numberOfCoins = 0; numberOfCoins < 10; numberOfCoins++)
            {
                coinContainer.Add(new Dime());
                totalInputValue += 0.10m;
            }
            for (numberOfCoins = 0; numberOfCoins < 50; numberOfCoins++)
            {
                coinContainer.Add(new Penny());
               totalInputValue += 0.01m;
            }
        }
    }
}

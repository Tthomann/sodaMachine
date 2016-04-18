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
        List<Coin> TransactionCoins = new List<Coin>();
        public List<Cans> stockCans = new List<Cans>();
        Cans can = new Cans();
        Coin coin = new Coin();
        Grape grape = new Grape();
        Orange orange = new Orange();
        Meat meat = new Meat();
        int userInput;
        int startingCoins;
        Quarter quarter = new Quarter();
        Nickle nickle = new Nickle();
        Dime dime = new Dime();
        Penny penny = new Penny();
        public bool finished;
        public Machine()
        {
            
        }
        public void machineMenu()
        {
            Console.WriteLine("");
            Console.WriteLine("---------------------");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("| (1)   [Grape]     |");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("| (2)   [Orange]    |");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("| (3)   [Meat]      |");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("---------------------");
            Console.WriteLine("");
        }
        public void startingMachineCoins()
        {
            {
                for (startingCoins = 0; startingCoins < 20; startingCoins++)
                {
                    MachineCoins.Add(quarter);
                }
                for (startingCoins = 0; startingCoins < 20; startingCoins++)
                {
                    MachineCoins.Add(nickle);
                }
                for (startingCoins = 0; startingCoins < 10; startingCoins++)
                {
                    MachineCoins.Add(dime);
                }
                for (startingCoins = 0; startingCoins < 50; startingCoins++)
                {
                    MachineCoins.Add(penny);
                }
            }
        }
        public void addSoda()
        {
            for (int i = 0; i < 10; i++)
            {
                stockCans.Add(new Grape());
                stockCans.Add(new Orange());
                stockCans.Add(new Meat());
            }
        }
        public void inputCoins()
        {
      

            while (finished == false)
            {
                Console.WriteLine("");
                Console.WriteLine("type 1 to add a quarter to the machine");
                Console.WriteLine("type 2 to add a nickle to the machine");
                Console.WriteLine("type 3 to add a dime to the machine");
                Console.WriteLine("type 4 to add a penny to the machine");
                Console.WriteLine("type 0 to stop putting change in the machine");
                Console.WriteLine("");
                userInput = Convert.ToInt32(Console.ReadLine());
                if (userInput == 1)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("you've added a quarter to the machine");
                    Console.ForegroundColor = ConsoleColor.White;
                    TransactionCoins.Add(quarter);
                    MachineCoins.Add(quarter);
                    coin.totalInputValue += quarter.coinValue;
                    coin.coinContainer.Remove(quarter);
                }
                else if (userInput == 2)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("you've added a nickle to the machine");
                    Console.ForegroundColor = ConsoleColor.White;
                    TransactionCoins.Add(nickle);
                    MachineCoins.Add(nickle);
                    coin.totalInputValue += nickle.coinValue;
                    coin.coinContainer.Remove(nickle);
                }
                else if (userInput == 3)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("you've added a dime to the machine");
                    Console.ForegroundColor = ConsoleColor.White;
                    TransactionCoins.Add(dime);
                    MachineCoins.Add(dime);
                    coin.totalInputValue += dime.coinValue;
                    coin.coinContainer.Remove(dime);
                }
                else if (userInput == 4)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("you've added a penny to the machine");
                    Console.ForegroundColor = ConsoleColor.White;
                    TransactionCoins.Add(penny);
                    MachineCoins.Add(penny);
                    coin.totalInputValue += penny.coinValue;
                    coin.coinContainer.Remove(penny);
                }
                else
                {
                    finished = true;
                    Console.WriteLine("");
                    Console.WriteLine("please select an option");
                    break;
                }
            }
        }
        public void getChange()
        {
            while (coin.totalInputValue != 0)
            {
                Console.WriteLine("change left to return: " + coin.totalInputValue);
                if (coin.totalInputValue == 0)
                {
                    Console.WriteLine("change return has completed");
                    break;
                }
                
                else if (coin.totalInputValue >= quarter.coinValue)
                {
                    Console.WriteLine("a quarter as been return to the customer");
                    coin.totalInputValue -= 0.25m;
                    coin.coinContainer.Add(quarter);
                    
                    
                    MachineCoins.Remove(quarter);
                    
                }
                else if (coin.totalInputValue >= dime.coinValue && coin.totalInputValue < 0.24m)
                {
                    Console.WriteLine("a dime as been return to the customer");
                    coin.totalInputValue -= 0.10m;
                    coin.coinContainer.Add(dime);
                    
             
                    MachineCoins.Remove(dime);

                }
                else if (coin.totalInputValue < dime.coinValue && coin.totalInputValue > 0.04m)
                {
                    Console.WriteLine("a nickle as been return to the customer");
                    coin.totalInputValue -= 0.05m;
                    coin.coinContainer.Add(nickle);
                    
                
                    MachineCoins.Remove(nickle);
                    
                }
                
                else if (coin.totalInputValue < 0.05m)
                {
                    Console.WriteLine("a penny as been return to the customer");
                    coin.totalInputValue -= 0.01m;
                    coin.coinContainer.Add(penny);
                    
                   
                    MachineCoins.Remove(penny);
                    
                }
                else
                {
                    Console.WriteLine("change has been given back");
      
                    break;
                }
            }
        }

            public void purchaseSoda() {
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("----------------------------");
            Console.WriteLine("| type 1 to buy grape soda  |");
            Console.WriteLine("| type 2 to buy orange soda |");
            Console.WriteLine("| type 3 to buy meat soda   |");
            Console.WriteLine("-----------------------------");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("");
            userInput = Convert.ToInt32(Console.ReadLine());
                if (stockCans.Count == 0)
                {
                Console.Clear();
                Console.WriteLine("no cans left.");
                }
                if (userInput == 1)
                {
                Console.Clear();
                if (grape.canPrice > coin.totalInputValue)
                    {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("not enough money to buy soda of that type");
                    Console.ForegroundColor = ConsoleColor.White;
                    

                    }
                    else if (grape.canPrice < coin.totalInputValue)
                    {
                    Console.WriteLine("");
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("customer has bought grape soda!");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("");
                    coin.totalInputValue -= grape.canPrice;
                        getChange();
                        stockCans.Remove(grape);
                
                    }
                }
                if (userInput == 2)
                {
                Console.Clear();
                if (orange.canPrice > coin.totalInputValue)
                    {
                        Console.WriteLine("not enough money to buy soda of that type");
                    }
                    else if (orange.canPrice < coin.totalInputValue)
                    {
                    Console.WriteLine("");
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("customer has bought orange soda!");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("");
                    coin.totalInputValue -= orange.canPrice;
                        getChange();
                        stockCans.Remove(orange);
                   
                }
                }
                if (userInput == 3)
                {
                Console.Clear();
                if (meat.canPrice > coin.totalInputValue)
                    {
                        Console.WriteLine("not enough money to buy soda of that type");
                    }
                    else if (coin.totalInputValue > meat.canPrice)
                    {
                    Console.WriteLine("");
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("customer is stupid and bought 'meat' soda...");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("");
                    coin.totalInputValue -= meat.canPrice;
                        getChange();
                        stockCans.Remove(meat);
                 
                }
                }
            }
           
    }
            
        }




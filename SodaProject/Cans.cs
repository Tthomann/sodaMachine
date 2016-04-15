using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaProject
{
    class Cans
    {
        List<Cans> stockCans = new List<Cans>();
        Grape grapeSoda;
        Orange orangeSoda;
        Meat meatSoda;
        public double canPrice;
        public string sodaType;
        public Cans()
        {
            
        }
        public void addSoda()
        {
            for (int i = 0; i < 100; i++) {
                stockCans.Add(new Grape());
                stockCans.Add(new Orange());
                stockCans.Add(new Meat());
            }
        }
    }
}

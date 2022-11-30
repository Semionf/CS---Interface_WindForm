using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    internal interface Item
    {
        int getPrice();
        string Name();
    }
    public class Cola : Item
    {
        public int getPrice()
        {
            return 10;
        }
        public string Name()
        {
            return "Cola - 10";
        }
    }
    public class Kinli : Item
    {
        public int getPrice()
        {
            return 11;
        }
        public string Name()
        {
            return "Kinli - 11";
        }
    }
}

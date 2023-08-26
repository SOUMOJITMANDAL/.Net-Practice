using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Player
    {
        public string name = "Soumojit";
        public int level = 0;
        private int health = 56; // we cannot access thsi directly
        public int getHealth()
        {
            return health; // we can acess protected variable by creating its own member functions 
        }
        public void setHealth(int h)
        {                            // function to set health 
            health = h;
        }
    }
}


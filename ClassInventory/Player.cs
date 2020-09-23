using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassInventory
{
    class Player
    {
        public string name;
        public int age;
        public string position;
        public string team; 

        public Player (string _name, int _age, string _position, string _team)
        {
            name = _name;
            age = _age;
            position = _position;
            team = _team; 
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    internal class Bush
    {
        public int Name;
        public List<int> Neigh;

        public Bush(int name, List<int> neigh)
        {
            Name = name;
            Neigh = neigh;
        }
        
        public Bush(int name)
        {
            Name = name;
            Neigh = new List<int> { };
        }
    }
}

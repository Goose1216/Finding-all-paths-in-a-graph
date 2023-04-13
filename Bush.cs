using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    internal class Bush<T>
    {
        public T Name;
        public List<Bush<T>> Neigh;

        public Bush(T name, List<Bush<T>> neigh)
        {
            Name = name;
            Neigh = neigh;
        }
        
        public Bush(T name)
        {
            Name = name;
            Neigh = new List<Bush<T>> { };
        }
    }
}

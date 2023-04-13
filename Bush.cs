using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    internal class Bush
    {
        private int name;
        private List<int> neigh;
        public char Name { get; }
        public string Neigh {
            get
            {
                string res = String.Empty;
                foreach(var item in neigh)
                {
                    res += item.ToString() + ", ";
                }
                res = res[..^2];
                return res;
            }
        }

        public Bush(int name, List<int> neigh)
        {
            this.name = name;
            this.neigh = neigh;
        }
        public Bush(int name, int n)
        {
            this.name = name;
            this.neigh = new List<int> { n };
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect
{
    class Solutions
    {
        string description;
        bool bugResolved = false;
     

        public Solutions(string d, bool s)
        {
            description = d;
            bugResolved = s;
        }

        public string Description
        {
            get { return description; }
        }
        

        public bool BugsResolved
        {
            get { return bugResolved; }
        }
        

    }
}

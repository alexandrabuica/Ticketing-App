using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect
{
    class Price
    {
        private string payment;
        private int number;
        private string support;
        private float packageValue;

        public Price (string p, int n, string s, float pV)
        {
            payment = p;
            number = n;
            support = s;
            packageValue = pV;
        }

        public override string ToString()
        {
            return "Package with payment " + payment + " with number of client users " + number + " providing " + support + " support has a price of " 
                + packageValue + " euros/month.";
        }
    }
}

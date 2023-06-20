using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public struct Currency
    {
        public string Curr;
        public decimal Amount;

        public Currency(string Curr, decimal Amount)
        {
            this.Curr = Curr;
            this.Amount = Amount >= 0 ? Amount : 0;
        }
    }
}

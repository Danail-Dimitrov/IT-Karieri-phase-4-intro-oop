using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamPrep
{
    class Pair
    {
        private int first;
        private int last;

        public int First
        {
            get
            {
                return first;
            }
            set
            {
                first = value;
            }
        }
        public int Last
        {
            get
            {
                return last;
            }
            set
            {
                last = value;
            }
        }

        public Pair(int first, int last)
        {
            First = first;
            Last = last;
        }

        public override string ToString()
        {
            return $"{first} {last}";
        }

        public int Difference()
        {
            int difference = first - last;
            if (difference < 0)
            {
                return difference * -1;
            }
            return difference;
        }
    }
}

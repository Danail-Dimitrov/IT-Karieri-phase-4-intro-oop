using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamPrep
{
    class CapacityList
    {
        private int count;
        private const int InitialCapacity = 2;
        private Pair[] items;

        private int startIndex = 0; //показва първият индекс, от който започваме да сумираме текущите елементи
        private int nextIndex = 0; //показва поредният индекс, на който можем да поставим елемент

        public CapacityList(int capacity = InitialCapacity)
        {
            this.items = new Pair[capacity];
        }

        public int Count
        {
            get
            {
                return count;
            }
            private set
            {

            }
        }

        public Pair this[int index]
        {
            get
            {
                return items[index];
            }
            set
            {
                items[index] = value;
            }
        }

        //====================================================================================================================================

        public void Add(Pair item)
        {
            if (count != items.Length)
            {

            }       
        }
        public Pair SumIntervalPairs()
        {
            //TODO: сумирайте двойките от startIndex до nextIndex
        }

        public Pair Sum()
        {
            //TODO: сумирайте двойките от 0 до this.Count – всички двойки, които имат право да участват в класирането
        }


        public void PrintCurrentState()
        {
            //TODO: отпечатайте всички двойки от 0 до nextIndex
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


namespace ConsoleApp1
{
    class ArrayList<T>
    {
        //fields
        private T[] items;
        private int count;

        //constructor
        public ArrayList ()
        { }
        public ArrayList (T[] data)
        {          
            foreach(var item in data)
            {
                Add(item);
            }       
        }

        //index
        public T this[int index]
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

        //geter
        public int Count
        {
            get
            {
                return count;
            }
            private set
            {
                count = value;
            }
        }

        //public methods
        public void Add (T value)
        {
            if(items == null)
            {
                items =new T[4];
            }

            if(Count < items.Length)
            {
                items[count] = value;
                count++;
            }
            else
            {
                items = Resize();
                items[count] = value;
                count++;
            }
        }
        public T RemoveAt (int index)
        {
            T element = items[index];
            Shift(index);

            return default(T);
        }
        public int Lenght ()
        {
            int a = items.Length;
            return a;
        }
        public void Insert (int index, T item)
        {
            if(Count == items.Length)
            {
                items = Resize();
            }

            for(int i = Count; i > index; i--)
            {
                items[i] = items[i - 1];
            }
            items[index] = item;
            count++;
        }

        //private methods
        private void Shift (int index)
        {
            for(int i = index ; i <= Count; i++)
            {
                items[i] = items[i + 1];
            }
            count--;
        }
        private T[] Resize ()
        {
            T[] newArr = new T[items.Length * 2];

            for(int i = 0 ; i < count ; i++)
            {
                newArr[i] = items[i];
            }

            return newArr;
        }

        //overrides
        public override string ToString ()
        {
            var sb = new StringBuilder();
            foreach(var item in items)
            {
                sb.Append(item + "\n");
            }
            return sb.ToString();
        }
    }
}

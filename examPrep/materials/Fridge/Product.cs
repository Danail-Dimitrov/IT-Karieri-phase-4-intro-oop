using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamPrep2
{
    public class Product
    {
        private string name;
        private Product next;

        public Product(string name)
        {
            this.name = name;
        }

        public string Name { get => name; set => name = value; }
        public Product Next { get => next; set => next = value; }

        public override string ToString()
        {
            return $"Product {name}";
        }
    }
}

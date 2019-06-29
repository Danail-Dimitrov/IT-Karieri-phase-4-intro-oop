using System.Text;
using System.Linq;
using System.Collections.Generic;

namespace ExamPrep2
{
    public class Fridge
    {
        private Product head;
        private Product tail;
        private int count;

        public Fridge() { }

        public int Count
        {
            get { return count; }
        }

        public void AddProduct(string productName)
        {
            count++;

            if (head == null)
            {
                head = tail = new Product(productName);
            }
            else
            {
                var newProduct = new Product(productName);
                tail.Next = newProduct;
                tail = newProduct;
            }
        }

        public string[] CookMeal(int start, int end)
        {
            var meals = ProvideInformationAboutAllProducts();

            if(end > meals.Length)
            {
                end = meals.Length;
            }

            var result = new List<string>();

            for (int i = start; i < end; i++)
            {
                result.Add(meals[i]);
            }

            return meals;
        }

        public string RemoveProductByIndex(int index)
        {
            if (index >= count)
            {
                return null;
            }
            return RemoveProductByName("", index);
        }

        public string RemoveProductByName(string name = "", int index = -1)
        {
            int countElements = 0;
          
            if (head.Name == name || countElements == index)
            {
                name = head.Name;
                head = head.Next;
                count--;
                return name;
            }
            Product currentProduct = head;

            while (currentProduct != null)
            {
                if (currentProduct.Next.Name == name || countElements + 1 == index)
                {
                    if (currentProduct.Next == tail || countElements == count)
                    {
                        name = tail.Name;
                        tail = currentProduct;
                        tail.Next = null;
                    }
                    else
                    {
                        name = currentProduct.Next.Name;
                        currentProduct.Next = currentProduct.Next.Next;
                    }
                    count--;
                    return name;
                }
                currentProduct = currentProduct.Next;
                countElements++;
            }
            return null;
        }

        public bool CheckProductIsInStock(string name)
        {
            Product currentProduct = head;

            while (currentProduct != null)
            {
                if (currentProduct.Name == name)
                {
                    return true;
                }
                currentProduct = currentProduct.Next;
            }
            return false;
        }

        public string[] ProvideInformationAboutAllProducts()
        {
            var allProducts = new List<string>();

            Product currentProduct = head;

            while (currentProduct != null)
            {
                allProducts.Add(currentProduct.ToString());
                currentProduct = currentProduct.Next;
            }
            return allProducts.ToArray();
        }
    }
}
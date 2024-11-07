using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace yp_3
{
    public class Product
    {
        // Поля
        protected string name;
        protected double price;
        protected int count;
        protected string art;
        protected string color;

        // Конструктор
        public Product(string name, double price,int count,string art,string color)
        {
            this.name = name;
            this.price = price;
            this.count = count;
            this.art = art;
            this.color = color;
        }

        // Функция определения качества
        public virtual double CalculateQuality()
        {
            return price/count; 
        }

        // Вывод информации
        public virtual string DisplayInfo()
        {
            return $"Name: {name} Price: {price:C} Count: {count}  Art:{art} Color:{color}";
        }

        // Перегрузки методов добавления
        public static List<Product> AddProduct(List<Product> products, Product product)
        {
            products.Add(product);
            return products;
        }

        public static List<Product> AddProduct(List<Product> products, string name, double price,int count, string art, string color)
        {
            products.Add(new Product(name, price,count, art, color));
            return products;
        }

        public static Queue<Product> AddProduct(Queue<Product> products, Product product)
        {
            products.Enqueue(product);
            return products;
        }

        // Перегрузки методов удаления
        public static List<Product> RemoveProduct(List<Product> products, Product product)
        {
            products.Remove(product);
            return products;
        }

        public static List<Product> RemoveProduct(List<Product> products, string name)
        {
            products.RemoveAll(p => p.name == name);
            return products;
        }

        public static Queue<Product> RemoveProduct(Queue<Product> products)
        {
            products.Dequeue();
            return products;
        }



    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment9
{
    internal class Program
    {
        static void Main(string[] args)
        {

        product pro = new product();

        pro.Id= 1;
        pro.Name= "DEll Laptop";
        pro.Price = 40000;

        Console.WriteLine($"\n Id {pro.Id} \n Product Name : {pro.Name} \n  Product Price : {pro.Price}");

        }
    }
}

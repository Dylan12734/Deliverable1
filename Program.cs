using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

internal class Program
{
    private static void Main(string[] args)
    {
        int s1 = 100;
        int c1 = 40;
        int d1 = 60;
        Console.WriteLine("Welcome to the restocking tool.");
        Console.WriteLine("How many sodas have sold today? "+ s1 +" are in stock,");
        int s2 = Convert.ToInt32(Console.ReadLine());
        int s3 = s1 - s2;
        if (s2 > s1)
        {
            Console.WriteLine("That value is too high. Stock not adjusted");
        }
        else
        {
            Console.WriteLine("there are"+ s3+ "sodas left");
        }
        Console.WriteLine("how many chips haved been sold today ? "+ c1+" are in stock");
        int c2 = Convert.ToInt32(Console.ReadLine());
        int c3 = c1 - c2;
        if (c2 > c1)
        {
            Console.WriteLine("That value is too high. Stock not adjusted");
        }
        else
        {
            Console.WriteLine("There are "+ c3+ "chips left");
        }
        Console.WriteLine("how much candy have you sold today? "+ d1+" are left in stock");
        int d2 = Convert.ToInt32(Console.ReadLine());
        int d3 = d1 - d2;
        if (d2 >d1)
        {
            Console.WriteLine("That value is too high. Stock not adjusted");
        }
        else
        {
            Console.WriteLine("there is "+ d3+" candies left");
        }
        Console.WriteLine("Thank you for filling out the values. Here's what needs to be restocked");
        if (s3 <= 40)
        {
            Console.WriteLine("Soda needs to be restocked");
        }
        if (c3 <= 20)
        {
            Console.WriteLine("Chips need to be restocked");
        }
        if (d3 <= 40)
        {
            Console.WriteLine("Candy needs to be restocked");
        }
        Console.WriteLine("Goodbye!");
        {

        }
    }
}
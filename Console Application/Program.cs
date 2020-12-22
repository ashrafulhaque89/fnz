﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace DesignSolution
{
    class Program
    {
        public void AddCustomer(List<Customers> customers, string fname, string lname, DateTime DOB, string gender)
        {
            var customer = new Customers()
            {
                First_name = fname,
                Last_name = lname,
                DOB = DOB,
                Gender = gender
            };
            customers.Add(customer);
            if(customers.Count() == 1)
            {
                customer.Customers_id = 1;
            }
            else if(customers.Count() > 1)
            {
                customer.Customers_id = customers.Count();
            }
        }

        public static int CalculateAverage(Customers[] customers, string gender)
        {
            return (int)(DateTime.Now.Year - customers.Where(x => x.Gender == gender).Select(x => x.DOB.Year).ToArray().Average());
        }

        public void PrintReport(int Average, string gender)
        {
            Console.WriteLine();
            Console.WriteLine($"   {gender} Average Age:");
            Console.WriteLine();
            Console.WriteLine("          " + Average);
            Console.WriteLine();
        }

        public void PrintCustomerList(List<Customers> customers)
        {
            Console.WriteLine("**************Customers List****************");
            foreach(Customers item in customers)
            {
                Console.WriteLine();
                Console.WriteLine("   Id : " + item.Customers_id);
                Console.WriteLine("   First Name : " + item.First_name);
                Console.WriteLine("   Last Name : " + item.First_name);
                Console.WriteLine("   DOB : " + item.DOB);
                Console.WriteLine("   Age : " + item.Current_Age);
                Console.WriteLine("   Gender : " + item.Gender);
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            Program program = new Program();
            List<Customers> Customers_list = new List<Customers>();
            program.AddCustomer(Customers_list, "John", "Rowley", new DateTime(1978, 2, 5), "Male");
            program.AddCustomer(Customers_list, "Declan", "Munroe", new DateTime(1992, 4, 6), "Female");
            program.AddCustomer(Customers_list, "Colm", "O'hara", new DateTime(2003, 3, 15), "Male");
            program.AddCustomer(Customers_list, "Simon", "Blair", new DateTime(2008, 2, 23), "Female");
            program.AddCustomer(Customers_list, "Blake", "Bailley", new DateTime(2000, 12, 13), "Other");
            program.PrintCustomerList(Customers_list);
            program.PrintReport(CalculateAverage(Customers_list.ToArray(), "Male"), "Male");
            program.PrintReport(CalculateAverage(Customers_list.ToArray(), "Female"), "Female");
            program.PrintReport(CalculateAverage(Customers_list.ToArray(), "Other"), "Other");
            Console.ReadKey();
        }
    }
}
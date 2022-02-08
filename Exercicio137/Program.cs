using System;
using System.Collections.Generic;
using Exercicio137.Entities;

namespace Exercicio137
    {
    class Program
        {
        static void Main(string[] args)
            {
            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());
            List<TaxPayer> list = new List<TaxPayer>();

            for (int i = 1; i <= n; i++)
                {
                Console.WriteLine($"Tax payer #{i} data:");
                Console.Write("Individual or company (i/c)?");
                char c = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual Income: ");
                double anualIncome = double.Parse(Console.ReadLine());

                if (c == 'i')
                    {
                    Console.Write("Health expenditures: ");
                    double healthExpenditures = double.Parse(Console.ReadLine());
                    list.Add(new Individual(name, anualIncome, healthExpenditures));
                    }
                else
                    {
                    Console.Write("Number of employees: ");
                    int numberOfEmployees = int.Parse(Console.ReadLine());
                    list.Add(new Company(name, anualIncome, numberOfEmployees));
                    }
                }
            Console.WriteLine();
            foreach(TaxPayer tx in list)
                {
                Console.WriteLine("TAX PAYED: ");
                Console.Write(tx);
                }
            }
        }
    }

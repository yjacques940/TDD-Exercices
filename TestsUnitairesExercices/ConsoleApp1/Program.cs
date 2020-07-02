using System;
using System.Collections.Generic;
using TestsUnitairesExercices.FizzBuzz;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello World! Choose a number!");
			var value = Console.ReadLine();
			Console.WriteLine("Calculating numbers.");
			Console.WriteLine("Calculating numbers..");
			Console.WriteLine("Calculating numbers...");
			ShowFizzBuzz(value);
			
			Console.ReadKey(true);
		}

		private static void ShowFizzBuzz(string value)
		{
			var fizzBuzz = new CalculateurReponse();
			var liste = fizzBuzz.ObtenirListe(Convert.ToInt32(value));
			liste.ForEach(c => Console.WriteLine(c));
		}
	}
}

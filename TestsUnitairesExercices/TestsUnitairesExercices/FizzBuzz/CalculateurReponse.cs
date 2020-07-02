using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace TestsUnitairesExercices.FizzBuzz
{
	public class CalculateurReponse
	{
		public List<string> ObtenirListe(int maximum)
		{
			var list = new List<string>();
			for (int i = 1; i <= maximum; i++)
			{
				list.Add(ObtenirReponse(i));
			}
			return list;
		}

		public string ObtenirReponse(int number)
		{
			if (IsMultipleOf(number, 5) && IsMultipleOf(number, 3))
				return "FizzBuzz";
			if (IsMultipleOf(number, 5))
				return "Buzz";
			if (IsMultipleOf(number, 3))
				return "Fizz";
			return number.ToString();
		}

		public bool IsMultipleOf(int number, int diviseur)
		{
			return number % diviseur == 0;
		}
	}
}

using System;
using System.Collections.Generic;
using System.Text;

namespace TestsUnitairesExercices.Cible_exercice_3
{
	public class RapporteurExTrois : IRapporteurExTrois
	{
		public bool EstPlein()
		{
			return false;
		}
		public void Rapporter(string message)
		{
			throw new Exception("NOT IMPLEMENTED");
		}
	}
}

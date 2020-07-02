using System;
using System.Collections.Generic;
using System.Text;

namespace TestsUnitairesExercices.Cible
{
	public class Cible
	{
		private IRapporteur rapporteur;

		public Cible(IRapporteur rapporteur)
		{
			this.rapporteur = rapporteur;
		}

		public bool PreVerifier(int montant)
		{
		    if(montant > 1000) {
		       rapporter("WARN plus de 1000!");
		       return false;
		    }
			return true;
		}

		private void rapporter(String msg)
		{
			rapporteur.Rapporter(msg);
		}
	}

	public class Rapporteur : IRapporteur
	{

		public bool EstPlein()
		{
			return false;
		}

		public void Rapporter(String message)
		{
			throw new Exception("NOT IMPLEMENTED");
		}

	}

	public interface IRapporteur
	{
		void Rapporter(String message);
	}
}

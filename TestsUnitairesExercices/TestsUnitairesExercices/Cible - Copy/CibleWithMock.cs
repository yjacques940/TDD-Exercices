using System;

namespace TestsUnitairesExercices
{
	public class CibleWithMock
	{
		private IRapporteurWithMock rapporteur;

		public CibleWithMock(IRapporteurWithMock rapporteur)
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

	public class RapporteurWithMock : IRapporteurWithMock
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

	public interface IRapporteurWithMock
	{
		void Rapporter(String message);
	}
}

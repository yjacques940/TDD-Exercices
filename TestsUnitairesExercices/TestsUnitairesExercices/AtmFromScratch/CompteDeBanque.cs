namespace TestsUnitairesExercices.AtmFromScratch
{
	public class CompteDeBanque : ICompteDeBanque
	{
		private int montantDuCompte;

		public CompteDeBanque(int montantDuCompte)
		{
			this.montantDuCompte = montantDuCompte;
		}

		public bool EstVide()
		{
			return montantDuCompte == 0;
		}

		public bool PeutRetirerArgent(int montantARetirer)
		{
			if (EstVide() || !MontantARetirerPlusPetitOuEgalQueMontantDuCompte(montantARetirer))
				return false;
			return true;
		}

		private bool MontantARetirerPlusPetitOuEgalQueMontantDuCompte(int montantARetirer)
		{
			return montantARetirer <= montantDuCompte;
		}

		public void RetirerArgent(int montantARetirer)
		{
			montantDuCompte = montantDuCompte - montantARetirer;
		}

		public void RollbackArgent()
		{
			montantDuCompte = 100;
		}
	}
}

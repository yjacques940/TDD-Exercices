namespace TestsUnitairesExercices.AtmFromScratch
{
	public class ServiceDeRetrait
	{
		private IDistributeur distributeur;

		public ServiceDeRetrait(IDistributeur distributeur)
		{
			this.distributeur = distributeur;
		}

		public bool RetirerArgent(ICompteDeBanque compteDeBanque, int montantARetirer)
		{
			if (!compteDeBanque.PeutRetirerArgent(montantARetirer))
				return false;

			try
			{
				compteDeBanque.RetirerArgent(montantARetirer);
				distributeur.Distribuer(montantARetirer);
			}
			catch
			{
				compteDeBanque.RollbackArgent();
				return false;
			}
			return true;
		}
	}
}

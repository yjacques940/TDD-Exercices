namespace TestsUnitairesExercices.AtmFromScratch
{
	public interface ICompteDeBanque
	{
		bool PeutRetirerArgent(int montantARetirer);
		void RollbackArgent();
		void RetirerArgent(int montantARetirer);
	}
}

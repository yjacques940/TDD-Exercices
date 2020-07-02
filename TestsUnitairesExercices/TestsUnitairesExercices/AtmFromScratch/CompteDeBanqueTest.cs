using NUnit.Framework;

namespace TestsUnitairesExercices.AtmFromScratch
{
	[TestFixture]
	class CompteDeBanqueTest
	{
		[Test]
		public void CompteVide_QuandValiderCompte_DevraitRetournerCompteVide()
		{
			var compteDeBanque = new CompteDeBanque(0);
			var montantARetirer = 0;

			var compteValide = compteDeBanque.PeutRetirerArgent(montantARetirer);

			Assert.False(compteValide);
		}

		[Test]
		public void CompteAvecArgent_QuandValiderCompte_DevraitRetournerCompteValide()
		{
			var compteDeBanque = new CompteDeBanque(100);
			var montantARetirer = 0;

			var compteValide = compteDeBanque.PeutRetirerArgent(montantARetirer);

			Assert.True(compteValide);
		}

		[Test]
		public void CompteAvecArgent_QuandRecoitMontantARetirerPlusPetitQueMontantDisponible_DevraitRetournerMontantPeutEtreRetire()
		{
			var compteDeBanque = new CompteDeBanque(100);
			var montantARetirer = 50;

			var comptePeutRetirerMontant = compteDeBanque.PeutRetirerArgent(montantARetirer);

			Assert.True(comptePeutRetirerMontant);
		}

		[Test]
		public void CompteAvecArgent_QuandRetirerToutArgentDansLeCompte_DevraitRetournerMontantPeutEtreRetire()
		{
			var compteDeBanque = new CompteDeBanque(100);
			var montantARetirer = 100;

			var comptePeutRetirerMontant = compteDeBanque.PeutRetirerArgent(montantARetirer);

			Assert.True(comptePeutRetirerMontant);
		}
	}
}

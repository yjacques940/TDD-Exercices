using System;
using System.Collections.Generic;
using System.Text;
using Moq;
using NUnit.Framework;

namespace TestsUnitairesExercices.Cible_exercice_3
{
	[TestFixture]
	class CibleExTroisTests
	{
		private CibleExTrois Cible { get; set; }
		private Mock<IRapporteurExTrois> mockRapporteur { get; set; }

		[SetUp]
		public void OnInitialize()
		{
			mockRapporteur = new Mock<IRapporteurExTrois>();
			Cible = new CibleExTrois(mockRapporteur.Object);
		}

		[Test]
		public void ValidateSolde_WhenLessThan1000_ShouldBeTrue()
		{
			var montantValide = 500;

			var resultat = Cible.PreVerifier(montantValide);

			Assert.True(resultat);
		}

		[Test]
		public void ValidateSolde_WhenIs1000_ShouldBeTrue()
		{
			var montant = 1000;

			var resultat = Cible.PreVerifier(montant);

			Assert.True(resultat);
		}

		[Test]
		public void ValidateSolde_WhenIsHigherThan1000_ShouldBeFalse()
		{
			var montant = 1001;

			var resultat = Cible.PreVerifier(montant);

			Assert.False(resultat);
		}

		[Test]
		public void RapporteurPlein_WhenVerifier_ShouldReturnFalse()
		{
			var montant = 123;
			mockRapporteur.Setup(c => c.EstPlein()).Returns(true);
			var cible = new CibleExTrois(mockRapporteur.Object);

			var resultat = cible.PreVerifier(montant);

			Assert.False(resultat);
		}

		[Test]
		public void RapporteurPasPlein_WhenVerifier_ShouldReturnTrue()
		{
			var montant = 123;
			mockRapporteur.Setup(c => c.EstPlein()).Returns(false);
			var cible = new CibleExTrois(mockRapporteur.Object);

			var resultat = cible.PreVerifier(montant);

			Assert.True(resultat);
		}
	}
}

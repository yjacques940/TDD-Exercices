using System;
using Moq;
using NUnit.Framework;
using TestsUnitairesExercices.Cible;

namespace TestsUnitairesExercices
{
	[TestFixture]
	class CibleWithMockTests
	{
		private CibleWithMock Cible { get; set; }

		[SetUp]
		public void OnInitialize()
		{
			var mockRapporteur = new Mock<IRapporteurWithMock>();
			Cible = new CibleWithMock(mockRapporteur.Object);
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
	}
}

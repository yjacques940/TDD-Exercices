using System;
using System.Collections.Generic;
using System.Text;
using DevExpress.RichEdit.Export;
using NUnit.Framework;

namespace TestsUnitairesExercices.Cible
{
	[TestFixture]
	class CibleTests
	{
		private Cible Cible { get; set; }

		[SetUp]
		public void OnInitialize()
		{
			Cible = new Cible(new RapporteurDetail());
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

	public class RapporteurDetail : IRapporteur
	{
		public bool EstPlein()
		{
			return false;
		}

		public void Rapporter(String message)
		{
		}
	}

	
}

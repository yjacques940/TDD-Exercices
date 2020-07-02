using Moq;
using NUnit.Framework;
using System;

namespace TestsUnitairesExercices.AtmFromScratch
{
	[TestFixture]
	class AtmTests
	{
		private int montantARetirer = 50;
		private ServiceDeRetrait serviceDeRetrait;

		[SetUp]
		public void Initialize()
		{
			var distributeur = new Mock<IDistributeur>();
			serviceDeRetrait = new ServiceDeRetrait(distributeur.Object);
		}

		[Test]
		public void CompteVide_QuandDemanderRetrait_DevraitPasRetirerArgent()
		{
			var compteDeBanque = new CompteDeBanque(0);

			var argentAEteRetiree = serviceDeRetrait.RetirerArgent(compteDeBanque, montantARetirer);

			Assert.False(argentAEteRetiree);
		}

		[Test]
		public void CompteAvecArgent_QuandDemanderRetrait_DevraitRetirerArgent()
		{
			var compteDeBanque = new CompteDeBanque(100);

			var argentAEteRetiree = serviceDeRetrait.RetirerArgent(compteDeBanque, montantARetirer);

			Assert.True(argentAEteRetiree);
		}

		[Test]
		public void CompteAvecArgent_QuandDistribuerArgentLanceException_DevraitRollBack()
		{
			var compteDeBanque = new Mock<ICompteDeBanque>();
			var distributeur = new Mock<IDistributeur>();
			compteDeBanque.Setup(c => c.PeutRetirerArgent(It.IsAny<int>())).Returns(true);
			distributeur.Setup(c => c.Distribuer(montantARetirer)).Throws(new Exception("Erreur Lors de la distribution"));
			var service = new ServiceDeRetrait(distributeur.Object);

			var argentAEteRetiree = service.RetirerArgent(compteDeBanque.Object, montantARetirer);
			
			compteDeBanque.Verify(c => c.RollbackArgent());
			Assert.False(argentAEteRetiree);
		}
	}
}

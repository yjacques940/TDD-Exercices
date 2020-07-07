using Elapse.CSharp.Paie.Domain;
using Elapse.CSharp.Paie.Domain.Banque;
using NUnit.Framework;

namespace Elapse.CSharp.Paie.DomainTest
{
	[TestFixture]
	class EmployeTests
	{
		double salaireAnnuel = 52000;
		private Employe employe;
		private NumeroCompteBancaire bankAccount;

		[SetUp]
		public void Initialize()
		{
			bankAccount = new NumeroCompteBancaire();
			employe = new Employe(bankAccount);
		}

		[Test]
		public void SalaireBrut_ParSemaine_ShouldReturnSalairePourUneSemaine()
		{
			employe.SetSalaireAnnuel(salaireAnnuel);

			var salaireParSemaine = employe.GetSalaireBrut(PaymentFrequency.Weekly);

			Assert.AreEqual(1000, salaireParSemaine);
		}

		[Test]
		public void SalaireBrut_ParAnnee_ShouldReturnSalairePourUneAnnee()
		{
			employe.SetSalaireAnnuel(salaireAnnuel);

			var salaireParSemaine = employe.GetSalaireBrut(PaymentFrequency.Annual);

			Assert.AreEqual(52000, salaireParSemaine);
		}
	}
}

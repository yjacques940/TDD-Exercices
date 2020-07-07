using Elapse.CSharp.Paie.Domain;
using Elapse.CSharp.Paie.Domain.Banque;
using Moq;
using NUnit.Framework;

namespace Elapse.CSharp.Paie.DomainTest
{
	[TestFixture]
    public class EntrepriseTest
    {
	    private NumeroCompteBancaire bankAccount;
	    private Employe employee;
	    private Mock<IServiceDePaiement> mockServiceDePaiement;

	    [SetUp]
	    public void Initialize()
	    {
		    bankAccount = new NumeroCompteBancaire();
		    employee = new Employe(bankAccount);
		    mockServiceDePaiement = new Mock<IServiceDePaiement>();
		}

	    [Test]
	    public void WhenGeneratePay_EveryEmployeeShouldHaveYearlySalary()
	    {
			var entreprise = new Entreprise(mockServiceDePaiement.Object, PaymentFrequency.Annual);
			entreprise.AjouterEmploye(employee);

			entreprise.GenererPaiesPourTousEmployes();

			Assert.True(employee.AUnSalaireAnnuel());
	    }

	    [Test]
	    public void WhenPayerEmployes_ShouldCallPayerOnServiceDePaiement()
	    {
		    var entreprise = new Entreprise(mockServiceDePaiement.Object, PaymentFrequency.Annual);
			entreprise.AjouterEmploye(employee);

			entreprise.PayerEmployes();

			mockServiceDePaiement.Verify(c =>
				c.Payer(It.IsAny<decimal>(), It.IsAny<NumeroCompteBancaire>()));
	    }
    }
}
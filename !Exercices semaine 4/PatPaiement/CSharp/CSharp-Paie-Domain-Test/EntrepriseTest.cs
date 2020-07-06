using Elapse.CSharp.Paie.Domain;
using Elapse.CSharp.Paie.Domain.Banque;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Elapse.CSharp.Paie.DomainTest
{
	[TestClass]
    public class EntrepriseTest
    {
	    [TestInitialize]
	    public void Initialize()
	    {

	    }

		

		[TestMethod]
	    public void GenerePaie_WhenPayerEmployes_ShouldGenererPaiePourChaqueEmploye()
	    {
			var entreprise = new Entreprise();
			var employe = new Employe(new NumeroCompteBancaire()); 
			entreprise.AjouterEmploye(employe);

			entreprise.GenererPaiesPourTousEmployes();

	    }
    }
}
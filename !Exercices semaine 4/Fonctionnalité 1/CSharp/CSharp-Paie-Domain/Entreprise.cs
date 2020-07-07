using Elapse.CSharp.Paie.Domain.Banque;
using System;
using System.Collections.Generic;

namespace Elapse.CSharp.Paie.Domain
{
	public class Entreprise
    {
	    private readonly IServiceDePaiement serviceDePaiement;
	    private readonly PaymentFrequency paymentFrequency;
	    private readonly IList<Employe> _employes = new List<Employe>();

        public Entreprise(IServiceDePaiement serviceDePaiement, PaymentFrequency paymentFrequency)
        {
	        this.serviceDePaiement = serviceDePaiement;
	        this.paymentFrequency = paymentFrequency;
        }

        public void AjouterEmploye(Employe alice)
        {
            _employes.Add(alice);
        }

        public bool AUnEmploye(Employe employe)
        {
            return _employes.Contains(employe);
        }

        public void GenererPaiesPourTousEmployes()
        {
	        foreach (var employe in _employes)
	        {
		        employe.SetSalaireAnnuel(GetRandomSalaireAnnuel());
	        }
        }

        private double GetRandomSalaireAnnuel()
        {
	        return new Random().Next(25000,50000);
        }

        public void PayerEmployes()
        {
	        foreach (var employe in _employes)
	        {
		        var montant = employe.GetSalaireBrut(paymentFrequency);
		        try
		        {
			        var montantToDecimal = Convert.ToDecimal(montant);
					serviceDePaiement.Payer(montantToDecimal, employe.GetBankAccount());
				}
		        catch (Exception e)
		        {
			        Console.WriteLine(e);
			        throw;
		        }
	        }
        }
    }
}
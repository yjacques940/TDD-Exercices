using Elapse.CSharp.Paie.Domain.Banque;

namespace Elapse.CSharp.Paie.Domain
{
	public class Employe
    {
	    private readonly NumeroCompteBancaire numeroCompteBancaire;
	    private double salaireAnnuel = 0;

	    public Employe(NumeroCompteBancaire numeroCompteBancaire)
	    {
		    this.numeroCompteBancaire = numeroCompteBancaire;
	    }

        public void SetSalaireAnnuel(double salaireAnnuel)
        {
	        this.salaireAnnuel = salaireAnnuel;
        }

        public bool AUnSalaireAnnuel()
        {
	        return salaireAnnuel > 0;
        }

        public double GetSalaireBrut(PaymentFrequency frequency)
        {
	        return salaireAnnuel / 52 * (double)frequency;
        }

        public NumeroCompteBancaire GetBankAccount()
        {
	        return numeroCompteBancaire;
        }
    }
}

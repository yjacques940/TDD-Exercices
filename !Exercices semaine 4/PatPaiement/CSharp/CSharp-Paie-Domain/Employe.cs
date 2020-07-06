using Elapse.CSharp.Paie.Domain.Banque;

namespace Elapse.CSharp.Paie.Domain
{
	public class Employe
    {
	    private int salaire;

	    public Employe(NumeroCompteBancaire numeroCompteBancaire)
        {
        }

        public void GeneratePay()
        {
	        salaire = 515161;
        }
    }
}

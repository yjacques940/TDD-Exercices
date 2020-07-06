using System.Collections.Generic;

namespace Elapse.CSharp.Paie.Domain
{
	public class Entreprise
    {
        private readonly IList<Employe> employees = new List<Employe>();

        public void AjouterEmploye(Employe alice)
        {
            employees.Add(alice);
        }

        public bool AUnEmploye(Employe employe)
        {
            return employees.Contains(employe);
        }

        public void GenererPaiesPourTousEmployes()
        {
	        foreach (var employe in employees)
	        {
		        employe.GeneratePay();
	        }
        }
    }
}
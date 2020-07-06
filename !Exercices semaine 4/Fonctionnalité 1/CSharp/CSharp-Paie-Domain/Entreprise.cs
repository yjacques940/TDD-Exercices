using System.Collections.Generic;

namespace Elapse.CSharp.Paie.Domain
{
    public class Entreprise
    {
        private readonly IList<Employe> _employes = new List<Employe>();

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

        }
    }
}
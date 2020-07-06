using System;
using Elapse.CSharp.Paie.Domain.Banque;

namespace Elapse.CSharp.Paie.BanqueAcme
{
    public class ServiceDePaimentAcme : IServiceDePaiement
    {
        void IServiceDePaiement.Payer(decimal montant, NumeroCompteBancaire numeroCompteDestination)
        {
            if ((new Random().Next(2) % 2) == 2)
            {
                throw new ServicesBancairesException("Erreur lors de l'appel au service");
            }
        }

    }
}

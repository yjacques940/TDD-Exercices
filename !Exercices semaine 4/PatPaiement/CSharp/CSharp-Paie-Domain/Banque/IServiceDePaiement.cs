namespace Elapse.CSharp.Paie.Domain.Banque
{

    public interface IServiceDePaiement
    {
        void Payer(decimal montant, NumeroCompteBancaire numeroCompteDestination);
    }

}

using System;
using System.Collections.Generic;
using System.Text;

namespace TestsUnitairesExercices.Cible_exercice_3
{
	public class CibleExTrois
	{
		private IRapporteurExTrois rapporteur;

		public CibleExTrois(IRapporteurExTrois rapporteur)
		{
			this.rapporteur = rapporteur;
		}

		public bool PreVerifier(int montant)
		{
			if(rapporteur.EstPlein()) {
			   return false;
			}

			if(montant > 1000) {
			   rapporteur.Rapporter("WARN plus de 1000!");
			   return false;
			}
			return true;
		}
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP4
{
    class ComptePayant : Compte
    {

        // Constructeurs
        public ComptePayant(double solde) : base(solde) { }
        public ComptePayant() : base(0) { }

        // Retrait argent
        public override void Retrait(double montant)
        {
            base.Retrait(montant + 5);
        }

        // Dépôt argent
        public override void Depot(double montant)
        {
            base.Depot(montant - 5);
        }

    }
}

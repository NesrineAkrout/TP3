using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP4
{
    class CompteEpargne : Compte
    {

        // Attributs
        private double taux = 0.06;

        // Constructeur
        public CompteEpargne(double solde) : base(solde){ 

        }

        // Calcul intérêt
        public void CalculInteret()
        {
            this.solde += this.Solde * this.taux;
        }
    }
}

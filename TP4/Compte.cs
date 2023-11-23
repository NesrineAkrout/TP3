using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP4
{
    class Compte
    {
        // Attributs
     
        protected double solde;
        private int code;
        private static int nbCompte = 0;

        // Propriétés
        public double Solde
        {
            get { return solde; }

        }
        public int Code
        {
            get { return code; }
        }

        // Constructeurs
        public Compte() : this(0) { }

        public Compte(double soldeInitial)
        {
            this.solde = soldeInitial;
            Compte.nbCompte++;
            this.code = Compte.nbCompte;
        }

        // Dépôt argent
        public virtual void Depot(double montant)
        {
            this.solde += montant;
        }

        // Retrait argent
        public virtual void Retrait(double montant)
        {
            this.solde -= montant;
        }

        // Afficher les détails du compte
        public override string ToString()
        {
            return "Votre solde actuel est " + this.solde + " dinars";
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Initialisation
            Compte compte = new Compte(100);
            CompteEpargne compteEpargne = new CompteEpargne(100);
            ComptePayant comptePayant = new ComptePayant(100);

            // Dépôt
            compte.Depot(20);
            compteEpargne.Depot(20);
            comptePayant.Depot(20);

            // Retrait
            compte.Retrait(10);
            compteEpargne.Retrait(10);
            comptePayant.Retrait(10);

            // Calculer l'intérêt
            compteEpargne.CalculInteret();

            // Affichage
            Console.WriteLine(compte);
            Console.WriteLine(compteEpargne);
            Console.WriteLine(comptePayant);

        }
    }
}

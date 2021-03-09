using System;
using System.Collections.Generic;
using System.Text;

namespace localux
{
    class Modele
    {
        // Attributs privés
        private int id;
        private string libelle;
        private double tarifKmSupplementaire; // représente le tarif du km supplémentaire

        // Constructeur de la classe Modèle
        public Modele(int unId, string unLibelle, double unTarifKmSupp)
        {
            this.id = unId;
            this.libelle = unLibelle;
            this.tarifKmSupplementaire = unTarifKmSupp;
        }

        // Méthode
        public double GetTarifKmSupplementaire()
        { // retourne le tarif du km supplémentaire
            return 0;
        }
        }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace localux
{
    class LocationSansChauffeur : Location
    {
        //Attributs privés
        private double nbKmDepart; // kilométrage au compteur lors du retrait du véhicule
        private double nbKmRetour; // kilométrage au compteur lors de la restitution
        private FormuleSansChauffeur laFormuleSansChauffeur;
        // Constructeur de la classe LocationSansChauffeur

        public LocationSansChauffeur(int unNumLoc, DateTime uneDate,
        double unMontantRegle, double unNbKmDepart, Vehicule unVehicule, FormuleSansChauffeur uneFormuleSansChauffeur) : base (unNumLoc, uneDate, unMontantRegle, unVehicule)
        {
            this.nbKmDepart = nbKmDepart;
            this.nbKmRetour = nbKmRetour;
            this.laFormuleSansChauffeur = uneFormuleSansChauffeur;
        }
// …

        // Méthodes
        // méthode qui permet de modifier le nombre de kms lu au compteur lors de la
        // restitution du véhicule
        public void SetNbKmRetour(double nbKm)
        {
           this.nbKmRetour = nbKm;
        }

        // méthode qui permet d’obtenir le surplus à régler au titre du dépassement du forfait
        // kilométrique
        public double GetMontantDepasForfait()
        {
            double KmInclus = laFormuleSansChauffeur.GetNbKmInclus();
            double KmParcourus = this.nbKmRetour - this.nbKmDepart;
            if (KmParcourus > KmInclus)
            {
                double KmDepas = KmParcourus - KmInclus;
                Modele leModele = unVehicule.GetleModele();
                double TarifKmDepas = leModele.GetTarifKmSupplementaire();
                double MontantDepas = KmDepas * TarifKmDepas;
            }
            else
            {
                double MontantDepas = 0;
                return MontantDepas;
            }
        }
    }
}

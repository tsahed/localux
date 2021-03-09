using System;
using System.Collections.Generic;
using System.Text;

namespace localux
{
    class FormuleSansChauffeur : Formule
    {
        // Attributs privés
        private int duree; // durée de la location en heures
        private double nbKmInclus; // forfait kilométrique

        // Constructeur de la classe FormuleSansChauffeur qui appelle le constructeur de la classe mère
        // grâce à la syntaxe :base(…)

        public FormuleSansChauffeur(int unId, string unLibelle, int uneDuree,
        double unNbKmInclus) : base(unId, unLibelle)
        {
            this.duree = uneDuree;
            this.nbKmInclus = unNbKmInclus;
        }

        // Méthodes
        /*public double GetNbKmInclus()
        { // retourne le forfait kilométrique }
            public int GetDuree()
            { // retourne la durée }

                public double GetTarif(Modele unModele)
                { // retourne le tarif de la formule sans chauffeur

                    // pour le modèle de véhicule passé en paramètre}
                }*/
    }
}

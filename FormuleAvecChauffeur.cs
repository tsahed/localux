using System;
using System.Collections.Generic;
using System.Text;

namespace localux
{
    class FormuleAvecChauffeur : Formule
    {
        // Attributs privés
        private string lieu;
        private double tarif;

        // Constructeur de la classe FormuleAvecChauffeur qui appelle le constructeur de la classe mère
        // grâce à la syntaxe :base(…)

        public FormuleAvecChauffeur(int unId, string unLibelle,
        string unLieu, double unTarif) : base(unId, unLibelle)
        {
            this.lieu = unLieu;
            this.tarif = unTarif;
        }

        // Méthodes
       /* public string GetLieu()
        { // retourne le lieu }
            public double GetTarif()
            { // retourne le tarif de la formule avec chauffeur }
            }*/
        } 
}

using System;
using System.Collections.Generic;
using System.Text;

namespace localux
{
    class LocationAvecChauffeur : Location
    {
        //Attribut privé
        private FormuleAvecChauffeur laFormuleAvecChauffeur;

        // Constructeur de la classe LocationAvecChauffeur qui appelle le constructeur de la classe mère
        // grâce à la syntaxe : base(…)

        public LocationAvecChauffeur(int unNumLoc, DateTime uneDate,
        double unMontantRegle, Vehicule unVehicule,
        FormuleAvecChauffeur uneFormuleAvecChauffeur) : base(unNumLoc,
        uneDate, unMontantRegle, unVehicule)
        {
            this.laFormuleAvecChauffeur = uneFormuleAvecChauffeur;
        }
    }
}

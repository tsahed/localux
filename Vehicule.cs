using System;
using System.Collections.Generic;
using System.Text;

namespace localux
{
    class Vehicule
    {
        // Attributs privés
        private string immatriculation;
        private DateTime dateAchat;
        private Modele leModele;

        // Constructeur de la classe Vehicule
        public Vehicule(string uneImmat, DateTime uneDate, Modele unModele)
        {
            this.immatriculation = uneImmat;
            this.dateAchat = uneDate;
            this.leModele = unModele;
        }

        // Méthode
        /*public Modele GetLeModele()
        { // retourne le modèle du véhicule 
        }*/
        }
}

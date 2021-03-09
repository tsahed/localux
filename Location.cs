using System;
using System.Collections.Generic;
using System.Text;

namespace localux
{
    abstract class Location
    {
        // Attributs privés
        private int numLocation; // numéro de la location
        private DateTime dateLocation;
        private double montantRegle; // montant total réglé pour la location
        private Vehicule leVehicule;

        // Constructeur de la classe Location
        public Location(int unNumLoc, DateTime uneDate, double unMontantRegle,
        Vehicule unVehicule)
        {
            this.numLocation = unNumLoc;
            this.dateLocation = uneDate;
            this.montantRegle = unMontantRegle;
            this.leVehicule = unVehicule;
        }

        // Méthodes
        /*public Vehicule GetLeVehicule()
        { // retourne le véhicule concerné par la location }
            public double GetMontantRegle()
            { // retourne le montant total réglé par le client }
            }*/
    }
}
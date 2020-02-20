using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPE
{
    class Matériaux
    {
        private string couleur;
        private string nom;
        private int prix;
        


        public Matériaux(string coul, string nom, int prixU)
        {
            this.couleur = coul;
            this.nom = nom;
            this.prix = prixU;
        }

        public string getNom()
        {
            return nom;
        }

        public void setNom (string nvNom)
        {
            this.nom = nvNom;
        }

        public int getPrix()
        {
            return prix;
        }

        public void setPrix(int nvPrix)
        {
            this.prix = nvPrix;
        }

        public override string ToString()
        {
            return couleur + "  est de couleur : " + ""  + nom + "" + "  et le prix unitaire est de : " + prix;
        }
    }
}

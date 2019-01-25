using System;
using System.Collections.Generic;
using System.Text;

namespace Reconstruction
{
   
    class Batiment
    {
        public enum TypeBatiment { RESIDENTIEL, COMMERCIALE, INDUSTRIEL };
        private string nom;
        private int nbPieces;
        private int prixConstruction;
        private int largeur;
        private int longeur;
        private TypeBatiment typeBatiment;
        


        public void Initialiser(string _nom, int _nbPieces,int _prixConstruction, int _largeur, int _longeur, TypeBatiment _typeBatiment )
        {
            nom = _nom;
            nbPieces = _nbPieces;
            prixConstruction = _prixConstruction;
            largeur = _largeur;
            longeur = _longeur;
            typeBatiment = _typeBatiment;

        }
        public void Afficher ()
        {
            Console.WriteLine(nom + "(" + typeBatiment + ")---------> " + nbPieces + "(P/)" + prixConstruction + "$/" + CalculerSurface() + "m2");
        }

        public string GetNom ()
        {
            return nom;
        }
        public int GetNbPieces ()
        {
            return nbPieces;
        }
        public int GetPrixConstruction()
        {
            return prixConstruction;
        }
        public int GetLargeur()
        {
            return largeur;
        }
        public int GetLongeur()
        {
            return longeur;
        }
        public TypeBatiment GetTypeBatiment()
        {
            return typeBatiment;
        }
        private int CalculerSurface()
        {

            return longeur * largeur;
        }
    }
}

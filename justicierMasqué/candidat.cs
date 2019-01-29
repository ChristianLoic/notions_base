using System;
using System.Collections.Generic;
using System.Text;

namespace justicierMasqué
{
    class Candidat
    {
        private string surnom;
        private string nom;
        private string superPouvoir;
        public bool select;
        public void Initialiser(string _surnom, string _nom, string _superPouvoir)      // l"initialisation du candidat ,des caracteristiques du candidat //
        {
            surnom = _surnom;
            nom = _nom;
            superPouvoir = _superPouvoir;
        }
        public string GetSurnom()                                           //fonction qui donne un acces limiter au surnom //
        {

            return surnom;

        }
        public string GetNom()                                              //fonction qui donne un acces limiter au nom //
        {

            return nom;

        }
        public string GetSuperPouvoir()                                 //fonction qui donne un acces limiter au superPouvoir //
        {                       
            return superPouvoir;
        }

        public void Refuser()                          //le candidat  refuser doit rester ici//
        {
           

            select = false;
        }
        
        public void Accepter()                           //le candidat  refuser doit rester ici//
        {
            select = true;
        }
            
        
       
        public bool EstSelectionne()                             //va retourner le statut du candidat si il est selectionne ou pas //
        {

            return select;
          
            
        }
        

        public void Afficher()                                 //affiche le candidat , ses caracteristiques specifiques //
        {
            Console.WriteLine(" Surnom  :" + surnom);
            Console.WriteLine(" Nom  :" + nom);
            Console.WriteLine(" SuperPouvoir  :" + superPouvoir);
        }
        
    }
    
}




    


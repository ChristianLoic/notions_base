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
        public void Initialiser(string _surnom, string _nom, string _superPouvoir)      // l"initialisation des caracteristiques du candidat //
        {
            surnom = _surnom;
            nom = _nom;
            superPouvoir = _superPouvoir;
        }
        public string GetSurnom()
        {

            return surnom;

        }
        public string GetNom()
        {

            return nom;

        }
        public string GetSuperPouvoir()
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




    


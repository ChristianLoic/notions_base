using System;

namespace Reconstruction
{
    class Program
    {
        static void Main(string[] args)
        {



            Batiment batiment1 = new Batiment();
            batiment1.Initialiser("Maison de Hank Jones", 4, 50000, 12, 2, Batiment.TypeBatiment.RESIDENTIEL);
            Batiment batiment2 = new Batiment();
            batiment2.Initialiser("Buanderie Tremblay", 10, 100000, 300, 20, Batiment.TypeBatiment.COMMERCIALE);
            Batiment batiment3 = new Batiment();
            batiment3.Initialiser("Musee Marvel", 20, 250000, 62, 10, Batiment.TypeBatiment.RESIDENTIEL);
            Batiment batiment4 = new Batiment();
            batiment4.Initialiser("101 Corp", 4, 50000, 62, 2, Batiment.TypeBatiment.INDUSTRIEL);
            Batiment batiment5 = new Batiment();
            batiment5.Initialiser("Maison de Hank Jones", 4, 50000, 12, 2, Batiment.TypeBatiment.INDUSTRIEL);

            Batiment[] rue1 = { batiment1, batiment2, batiment3 };
            Batiment[] rue2 = { batiment4, batiment5};

            AfficherRue1(rue1);

            AfficherRue2( rue2);
            
        }
        static void AfficherRue1(Batiment[]rue)
        {
            Console.WriteLine("Afficher rue , methode #1");
            foreach (Batiment batiment in rue)
                batiment.Afficher();
        }
        static void AfficherRue2(Batiment[] rue)
        {
            Console.WriteLine("Afficher rue , methode #2");
            foreach (Batiment batiment in rue)
                Console.WriteLine(batiment.GetNom() + "(" + batiment.GetTypeBatiment() + ")");
        }

    }
}

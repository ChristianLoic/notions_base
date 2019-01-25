using System;

namespace notions_base
{
    class Program
    {
        static void Main(string[] args)
        {
            PremierJet();
            DeuxiemJet();
            TroisiemeJet(2);
            QuatriemeJet(79);
            CinquiemeJet();


            Console.ReadKey();
        }

        //2D4+4
        private static void PremierJet()
        {
            int resultat = 0;

            De d4 = new De();
            d4.Initialiser(4);
            d4.LancerDe();
            resultat = resultat + d4.GetValeur();

            d4.LancerDe();
            resultat = resultat + d4.GetValeur();

            resultat = resultat + 4;
            Console.WriteLine("(1)  " + resultat);

        }
        //6 fois 3D6//

        private static void DeuxiemJet()
        {
           
            De d6 = new De();
            d6.Initialiser(6);

            for (int i = 0; i < 6; i++)
            {
                int resultat = 0;
                d6.LancerDe();
                resultat += d6.GetValeur();
                d6.LancerDe();
                resultat += d6.GetValeur();
                d6.LancerDe();
                resultat += d6.GetValeur();
                Console.WriteLine("(2)    " + resultat);
            }

           
        }
        //d8+banus de force (en parametre)

        private static void TroisiemeJet(int x)
        {
            int resultat = 0;
            De d8 = new De();
            d8.Initialiser(8);

            d8.LancerDe();
            resultat = d8.GetValeur()+x;

            Console.WriteLine("(3) " + resultat);

        }

        //2d10//

        private static void  QuatriemeJet(int sucess)
        {

            int resultat = 0;
            
            De D10 = new De();
            D10.Initialiser(10);

           
            D10.LancerDe();
            resultat += 10*(D10.GetValeur());

            D10.LancerDe();
            resultat += D10.GetValeur();
           

            if (resultat>sucess)
            {
                Console.WriteLine("(4) "+resultat + ">"+ sucess);
            }
            else if (resultat==sucess)
            {
                Console.WriteLine("(4) "+resultat +"="+  sucess);
            }
            else
            {
                Console.WriteLine("(4) "+resultat +"<"+ sucess);
            }

        }

        //D20//

        private static void CinquiemeJet()
        {
            int resultat = 0;
            De d20 = new De();
            bool fin = false;
            int lance = 0;
            d20.Initialiser(20);

            while(fin==false)
            {
                lance++;
                d20.LancerDe();
                resultat = d20.GetValeur();

                if (resultat==20)
                {
                    Console.WriteLine("(5)Nombre de lancement de D20 :" + lance);
                    Console.WriteLine(">Resultat :" + resultat+ "- sucess");
                    fin = true;  
                }
               else if(resultat == 1)
                {
                    Console.WriteLine("(5)Nombre de lancement de D20 :" + lance);
                    Console.WriteLine(">Resultat :" + resultat + "- echec");
                    fin = true;
                }

            }

            
            

        
        }

    }
}
     

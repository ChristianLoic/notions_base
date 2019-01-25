using System;
using System.Collections.Generic;
using System.Text;

namespace notions_base
{
    class De
    {
        private int valeur;
        private int nbFaces;
        private Random rnd;

        public void Initialiser(int _nbFaces)
        {
            nbFaces = _nbFaces;
            rnd = new Random();
            valeur = 1;
        }

        public void LancerDe()
        {
            valeur = rnd.Next(nbFaces) + 1;

        }
        public int GetValeur()
        {
            return valeur;
        }

    }
}

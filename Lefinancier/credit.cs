using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lefinancier
{
    public class credit
    {
        public static void AfficherTableau_Amrt(double _capital, double _interet, double _NbMois, double _mensualite)
        {
            double CapitalRestantDu=_capital;
            double PartInteret_Mens;
            double PartCapital_Mens;
            for (int i = 1; i <= _NbMois; i++)
            {
                PartInteret_Mens = CapitalRestantDu * _interet;
                PartCapital_Mens = _mensualite - PartInteret_Mens;

                CapitalRestantDu = CapitalRestantDu - PartCapital_Mens;

                Console.Write("mois num:{0} / part intérêt : {1:#.0 } / part Kal : {2:#.0} / capital restant du :{3:#.0}/ mensualité {4} \n", i, PartInteret_Mens, PartCapital_Mens, CapitalRestantDu,_mensualite);
            }

            


        }



        public static double CalculMensualite(double _Capital, double _Interet, double _NbMois)
        {
            double a;


            double Q =( 1 - Math.Pow((1 + _Interet),- _NbMois));
            //Q = (1 - (1 + tm)puissance - n) 
            //    a = K x tm/ Q

            a = (_Capital * _Interet) / Q;
            
            return Math.Round(a,2);

        }

    }
}

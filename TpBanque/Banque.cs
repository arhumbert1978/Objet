using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPbanque
{
   public class Banque
    {
        //attributs
           private int nombreCompte;
           private Compte[] lesComptes;

        private string nomBanque;
        private string localisation;
        //Constructeur 

        public Banque(string _nom, string _loc)
            {
            this.localisation = _loc;
            this.nomBanque = _nom;
                lesComptes = new Compte[20];
            this.nombreCompte = 0;

            }
        //methodes
        private void AjouterCompte(Compte _unCompte)
        {

            this.lesComptes[nombreCompte] = _unCompte;
            nombreCompte++;
        }

        public void init()
        {
            Compte client1 = new Compte("123456", "Tournesol", 4500.50, -3000);

            Compte client2 = new Compte("678910", "Haddock", 500.50, -15000);
            Compte client3 = new Compte("101213", "Nestor", 4500, -500);
            this.AjouterCompte(client1);
            this.AjouterCompte(client2);
            this.AjouterCompte(client3);
        }


        public override string ToString()
        { string MesComptes = " Les differents comptes de la banque "+this.nomBanque+" basé à " + this.localisation+" sont :\n" ;

            for (int i = 0; i <this.nombreCompte; i++)
            {
                MesComptes+=this.lesComptes[i].ToString()+"\n" ;
            }
         

            //{
            //    MesComptes += unclient.ToString() + "/n";
            //}

            return MesComptes;
              
        }
        public Compte RendCompte(string _numeroCompte)
        {

            for (int i = 0; i < this.nombreCompte; i++)
            {
                if (_numeroCompte == lesComptes[i].GetNumero)
                {
                    return lesComptes[i];
                }
            }

            //if (lesComptes.Contains(_numeroCompte)==true)

            //{

            //}



            return null;
        }

        public bool Virement(string _numdebiteur, string _numbeneficiaire, double _montant)
        {
            if (RendCompte(_numdebiteur) != null && RendCompte(_numbeneficiaire) != null)
            {
                if ((RendCompte(_numdebiteur)).Debiter(_montant) == true)
                {
                    (RendCompte(_numbeneficiaire)).Crediter(_montant);
                    Console.WriteLine("Le virement a bien été effectué!!!Youpi");
                    return true;
                }
                else
                {
                    
                    Console.WriteLine("Virement refusé, dépassement de découvert autorisé");

                    return false;
                }




            }
            else
            {
                Console.WriteLine("Virement refusé, compte debiteur ou beneficiaire inexistant");
                return false;
            }


           


        }






    }

   
}

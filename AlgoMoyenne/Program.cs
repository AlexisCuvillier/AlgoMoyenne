using System;

namespace AlgoMoyenne
{
    class Program
    {

      

        static void Main(string[] args)
        {


            int[] valeurs = new int[10] { 15, 12, 3, 14, 5, 7, 18, 13, 1, 8};

         
           Console.WriteLine("Moyenne = " + GetMoyenne(valeurs));
            // Sur cet exemple, doit retourner 9.6


        }

     //   public calcul(float f)
    //    {
     
    //    }

      
        static float GetMoyenne(int[] valeurs)
        {

            // TODO: écrire cette fonction

            int size = valeurs.Length;
            float sum = 0;
          

            for (int i = 0; i < size; i++)
            {
                sum += valeurs[i];
            }

             float moyenne = sum / size;
          //  float f = moyenne;
            
            return moyenne;

            // Attention : Si le tableau de valeurs change, la fonction doit quand même marcher !
        }
    }
}


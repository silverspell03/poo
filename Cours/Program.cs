using System;
using System.Collections.Generic;

namespace Cours
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var prenoms  = new List<string> {"Joey","Gilles", "Johnson"} ;

            var inputPrenom = Console.ReadLine();

            if(prenoms.Contains(inputPrenom))
            {
                Console.WriteLine("Le prénom existe");
            }
            else
            {
                Console.WriteLine("Le prénom n'existe pas");
            }
            
            var nombres =  new List<int> {1,2,3,4,5};
            
            Console.WriteLine(nombres);
            Console.WriteLine("Entrez nombre à supprimer: ");
            var inputNombre = Console.ReadLine();

            int castNombre;

            int.TryParse(inputNombre, out castNombre);

            if (nombres.Contains(castNombre))
            {
                Console.WriteLine("Suppression du nombre");
                nombres.Remove(castNombre);
                Console.WriteLine(nombres);
            }
            else
            {
                Console.WriteLine("Nombre non présent");
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Text;

namespace Cours.Liste
{
    public class Exercice
    {
        private List<string> prenoms;
        private List<int> nombresRandom;
        private Random rnd;

        public Exercice()
        {
            prenoms = new List<string> { "Gilles", "Joey", "Connard" };
            rnd = new Random();
            nombresRandom = new List<int>();
            for (int i = 0; i < 100; i++)
            {
                nombresRandom.Add(rnd.Next(0, 100));
            }
        }

        public void ExerciceUn()
        {
            prenoms.ForEach(p => Console.WriteLine(p));
        }

        public void ExerciceDeux()
        {
            Console.WriteLine("Entrez un prénom: ");
            var inputPrenom = Console.ReadLine();

            if (prenoms.Contains(inputPrenom))
            {
                Console.WriteLine("Le prénom existe");
            }
            else
            {
                Console.WriteLine("Le prénom n'existe pas");
            }
        }

        public void ExerciceTrois()
        {
            var nombres = new List<int> { 1, 2, 3, 4, 5 };

            nombres.ForEach(n => Console.Write(n));
            Console.Write('\n');

            Console.WriteLine("Entrez nombre à supprimer: ");
            var inputNombre = Console.ReadLine();

            int castNombre;

            int.TryParse(inputNombre, out castNombre);

            if (nombres.Contains(castNombre))
            {
                Console.WriteLine("Suppression du nombre");
                nombres.Remove(castNombre);
                nombres.ForEach(n => Console.Write(n));
                Console.Write('\n');
            }
            else
            {
                Console.WriteLine("Nombre non présent");
            }

        }

        public void ExerciceQuatre()
        {
            List<int> tempListe = new List<int>(nombresRandom);

            tempListe.Sort();

            Console.WriteLine("Liste triée");
            tempListe.ForEach(n => Console.Write(n + ", "));
            Console.WriteLine();

            StringBuilder s = new StringBuilder();
            Console.WriteLine("Liste random");
            foreach (var n in nombresRandom)
            {
                s.Append(n);
                s.Append(',');
            }

            Console.WriteLine(s.ToString());
        }

        public void ExerciceCinq()
        {
            List<string> listePrenoms = new List<string>();
            while (true)
            {
                Console.WriteLine("Entrez un prénom (Q pour sortir, ENTER pour confirmer): ");
                string userInput =  Console.ReadLine();

                if (userInput == "Q")
                {
                    break;
                }
                else if(userInput == "")
                {
                    
                }
                else
                {
                    listePrenoms.Add(userInput);
                }
                
            }
            
            
        }
    }
}
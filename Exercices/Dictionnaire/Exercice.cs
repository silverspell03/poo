using System;
using System.Collections.Generic;
using System.Text;

namespace Cours.Dictionnaire
{
    public class Exercice
    {
        private Dictionary<string, string> pays = new Dictionary<string, string>();
        private Dictionary<string, double> produits = new Dictionary<string, double>();
        public void ExerciceSix()
        {
            pays.Add("FR", "France");
            pays.Add("BE", "Belgique");
            pays.Add("DE", "Allemagne");

            foreach (var pay in pays)
            {
                Console.WriteLine("{0} - {1}", pay.Key, pay.Value);
            }
        }

        public void ExerciceSept()
        {
            string userInput = "";
            userInput = Console.ReadLine();

            if (pays.ContainsKey(userInput))
            {
                Console.WriteLine("{0} - {1}", userInput, pays[userInput]);
            }
        }
        public void ExerciceHuit()
        {
            produits.Add("Pomme", 1.65);
            produits.Add("Banane", 1.89);
            produits.Add("Orange", 5.6);
            
            Console.WriteLine("Taper nom produit pour prix: ");
            
            string userInput = "";
            userInput = Console.ReadLine();

            try
            {
                Console.WriteLine(produits[userInput]);
            }
            catch (KeyNotFoundException)
            {
                Console.WriteLine("Produit non trouvé");
            }
        }

        public void ExerciceNeuf()
        {
            produits.Add("Pomme", 1.65);
            produits.Add("Banane", 1.89);
            produits.Add("Orange", 5.6);
            
            List<double> panier = new List<double>();
            Console.WriteLine("Tape nom produit pour remplir panier: ");
            
            string userInput = "";

            while (userInput != "stop")
            {
                userInput = Console.ReadLine();
                try
                {
                    panier.Add(produits[userInput]);
                }
                catch (KeyNotFoundException)
                {
                    Console.WriteLine("Produit non trouvé");
                }
            }

            double totalPanier = 0;
            panier.ForEach(n => totalPanier += n);
            
            Console.WriteLine(totalPanier);
        }

        public void ExerciceDix()
        {
            Console.WriteLine("Taper phrase");
            string userInput = "";
            userInput = Console.ReadLine();

            Dictionary<char, int> stat = new Dictionary<char, int>();
            foreach (var c in userInput)
            {
                if (stat.ContainsKey(c))
                {
                    stat[c]++;
                }
                else
                {
                    stat.Add(c, 1);
                }
            }

            foreach (var s in stat)
            {
                Console.WriteLine("{0} - {1}", s.Key, s.Value);
            }
        }
    }
}
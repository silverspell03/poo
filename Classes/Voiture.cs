using System;

namespace Cours.Classes
{
    public class Voiture
    {
        public string Modele { get; set; }

        public string Marque { get; set; }

        public int NombreDePortes
        {
            get;
            set
            {
                if (value < 3 || value > 5)
                {
                    field = value;
                }
                else
                {
                    throw new ArgumentException("Nombre de portes must be between 3 and 5");
                }
            }
        }

        public void AfficherDetails()
        {
            Console.WriteLine($"Modele: {Modele}, Marque: {Marque},  Nombre de portes: {NombreDePortes}");
        }
        
    }
}
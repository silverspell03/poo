using System.Diagnostics;

namespace heritage;

public class Voiture : Vehicule
{
    public int NombrePortes { get; set; }

    public Voiture(string marque, int annee, int nombrePortes) :  base(marque, annee)
    {
        this.NombrePortes = nombrePortes;
    }

    public override void Afficher()
    {
        Console.WriteLine($"Marque: {Marque} | Annee: {Annee} | Nombre de portes: {NombrePortes} portes");
    }
}
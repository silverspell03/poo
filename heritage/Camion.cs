namespace heritage;

public class Camion : Vehicule
{
    public int CapaciteChargement { get; set; }

    public Camion(string marque, int annee, int capaciteChargement) : base(marque, annee)
    {
        CapaciteChargement = capaciteChargement;
    }
    
    public override void Afficher()
    {
        Console.WriteLine($"Marque: {Marque} | Annee: {Annee} | Capacité: {CapaciteChargement} tonnes");
    }
}
namespace heritage;

public abstract class Vehicule
{
    public string Marque { get; set; }
    public int Annee { get; set; }

    public Vehicule(string marque, int annee)
    {
        Marque = marque;
        Annee = annee;
    }

    public abstract void Afficher();
}
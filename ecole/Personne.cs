namespace ecole;
public abstract class Personne 
{
    public string Nom { get; set; }
    public string Prenom { get; set; }

    public Personne(string nom, string prenom)
    {
        this.Nom = nom;
        this.Prenom = prenom;
    }

    public abstract void Afficher();
}

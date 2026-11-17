namespace ecole;
public class Enseignant : Personne
{
    public string Matiere { get; set; }

    public Enseignant(string nom, string prenom, string matiere) : base(nom, prenom)
    {
        this.Matiere = matiere;
    }

    public override void Afficher()
    {
        Console.WriteLine($"{this.Nom} : {this.Prenom} : {this.Matiere}");
    }
}

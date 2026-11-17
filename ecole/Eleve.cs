namespace ecole;
public class Eleve : Personne
{
    public string Matricule  { get; set; }
    public int Annee { get; set; }

    public Eleve(string nom, string prenom, string matricule, int annee) : base(nom, prenom)
    {
        Matricule = matricule;
        Annee = annee;
    }
    
    public override void Afficher()
    {
        Console.WriteLine($"{this.Nom} : {this.Prenom} : {this.Matricule} : {Annee}");
    }
}

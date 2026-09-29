namespace CoursPOO.Classes;

public class Livre
{
    public int Id { get; set; }
    public string Titre { get; set; }
    public string Auteur { get; set; }
    public string Annee { get; set; }
    
    public override string ToString() => $"Titre: {Titre}, Auteur: {Auteur},  Annee: {Annee}";
}
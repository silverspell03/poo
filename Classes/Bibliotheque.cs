namespace CoursPOO.Classes;

public class Bibliotheque
{
    private List<Livre> _livre = new List<Livre>();

    public void AjouterLivre(Livre livre)
    {
        _livre.Add(livre);
    }

    public void RetirerLivre(int id)
    {
        var livre = _livre.Find(livre => livre.Id == id);
        if (livre != null)
            _livre.Remove(livre);
    }
    public void AfficherLivres()
    {
        foreach (var livre in _livre)
            Console.WriteLine(livre);
    }

    public void RechercherLivre(string recherche)
    {
        foreach (var livre in _livre)
        {
            if (livre.Annee.Contains(recherche) || livre.Auteur.Contains(recherche) || livre.Titre.Contains(recherche))
                Console.WriteLine(livre);
        }
    }
}
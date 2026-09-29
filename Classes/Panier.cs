namespace CoursPOO.Classes;

public class Panier
{
    private List<Produit> _produits = new List<Produit>();
    public void AjouterProduit(params Produit[] p)
    {
        foreach (var produit in p)
            _produits.Add(produit);
    }

    public void SupprimerProduit(params Produit[] p)
    {
        foreach (var produit in p)
            _produits.Remove(produit);
    }

    public void AfficherPanier()
    {
        foreach (var produit in _produits)
        {
            Console.Write($"produit: {produit.Nom} \n Prix de {produit.Nom} : {produit.Prix}\n");
        }
        Console.WriteLine($"Prix total: {_produits.Sum(p => p.Prix)}");
    }
}
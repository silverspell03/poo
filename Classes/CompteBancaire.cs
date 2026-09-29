namespace CoursPOO.Classes;

public class CompteBancaire
{
    public string NumeroCompte { get; init; }
    private decimal Solde = 0;

    public void Deposer(int argent)
    {
        if (argent < 0)
        {
            throw new ArgumentOutOfRangeException("Impossible de déposer moins de 0 sous");
        }
        
        Solde = Solde += argent;
    }
    
    public void Retirer(int argent)
    {
        if (argent < 0)
        {
            throw new ArgumentOutOfRangeException("Impossible de retirer moins de 0 sous");
        }

        if (Solde < argent)
        {
            Console.WriteLine("Les huissiers arrivent attention");
        }
        
        Solde = Solde -= argent;
    }
    
    public void AfficherSolde()
    {
        Console.Write($"Numéro de compte: {NumeroCompte}\nSolde: {Solde}\n");
    }
}
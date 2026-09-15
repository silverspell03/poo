namespace Cours.Classes;

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
}
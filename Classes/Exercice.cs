namespace Cours.Classes;

public class Exercice
{
    public void ExerciceUn()
    {
        List<Voiture> voitures = new List<Voiture> {};
        for (int i = 0; i < 10; i++)
        {
            Voiture voiture = new Voiture();
            voitures.Add(voiture);
        }

        voitures.ForEach(voiture => voiture.AfficherDetails());
    }
    
    
}
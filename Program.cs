using System.Runtime.InteropServices.ComTypes;
using CoursPOO.Classes;

var bibliotheque = new Bibliotheque();
var livre1 = new Livre() {Annee = "2024", Auteur = "Moi meme", Titre = "Nulle ce livre"};
var livre2 = new Livre() {Annee = "2025", Auteur = "L'autre", Titre = "Trop bien le livre"};
var livre3 = new Livre() {Annee = "2022", Auteur = "aaaaa", Titre = "OOO"};
bibliotheque.AjouterLivre(livre1);
bibliotheque.AjouterLivre(livre2);
bibliotheque.AjouterLivre(livre3);

while (true)
{
    Console.Clear();
    Console.WriteLine("GESTION DE BIBLIOTHEQUE");
    Console.WriteLine("---------------------");
    Console.WriteLine("");
    Console.WriteLine("1 - Recherche par année, auteur ou année");
    Console.WriteLine("2 - Ajout d'un livre");
    Console.WriteLine("3 - Supprimer un livre");
    Console.WriteLine("4 - Afficher tous les livres");
    Console.WriteLine("");
    Console.Write("Entrez l'action voulue: ");
    if (!Int32.TryParse(Console.ReadLine(), out var action))
    {
        
    }
    
    switch (action)
    {
        case 1:
            var recherche = "";
            while (true)
            {
                Console.Write("Recherche: ");
                recherche = Console.ReadLine();
                if (recherche is null)
                {
                    Console.WriteLine("Entrez une vraie recherche");
                    continue;
                }
                break;
            }
            bibliotheque.RechercherLivre(recherche);
            Console.WriteLine("Appuyez sur une touche pour revenir au menu...");
            Console.ReadLine();
            break;
        case 2:
            Console.WriteLine("Ajout d'un livre");
            Console.Write("Auteur: ");
            var auteur = Console.ReadLine();
            Console.Write("Titre: ");
            var titre = Console.ReadLine();
            Console.Write("Année: ");
            var annee = Console.ReadLine();
            var livre = new Livre() { Auteur = auteur, Titre = titre, Annee =  annee };
            bibliotheque.AjouterLivre(livre);
            break;
        case 3:
            Console.WriteLine("Suppression d'un livre");
            while (true)
            {
                Console.Write("Id du livre: ");
                if (!Int32.TryParse(Console.ReadLine(), out int idLivre))
                {
                    Console.WriteLine("Pas un chiffre.");
                    continue;
                }
                bibliotheque.RetirerLivre(idLivre);
                break;
            }
            break;
        case 4:
            bibliotheque.AfficherLivres();
            Console.WriteLine("Appuyez sur une touche pour revenir au menu...");
            Console.ReadLine();
            break;
        default:
            Console.WriteLine("Mauvaise action, retour au menu");
            Thread.Sleep(1000);
            break;
    }
}

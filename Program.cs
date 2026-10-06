using CoursPOO.Classes;
using CoursPOO.Hotel;

var hotel = new Hotel();

Chambre chambre1 = new Chambre(2, 123213.4342m, TypeChambre.Simple);
Chambre chambre2 = new Chambre(2, 213.342m, TypeChambre.Simple);
Chambre chambre3 = new Chambre(2, 213.342m, TypeChambre.Simple);

hotel._chambres.Add(chambre1);
hotel._chambres.Add(chambre2);
hotel._chambres.Add(chambre3);

while (true)
{
    Console.Clear();
    Console.WriteLine("GESTION D'UN HOTEL");
    Console.WriteLine("---------------------");
    Console.WriteLine("1 - Ajouter une chambre");
    Console.WriteLine("2 - Lister les chambres");
    Console.WriteLine("3 - Rechercher chambre par type");
    Console.WriteLine("4 - Lister réservation(s)");
    Console.WriteLine("5 - Afficher chambres libres (période)");
    Console.WriteLine("6 - Annuler réservation(s)");
    Console.WriteLine("");
    Console.Write("Entrez l'action voulue: ");
    if (!Int32.TryParse(Console.ReadLine(), out var action))
    {

    }

    switch (action)
    {
        case 1:
            Console.WriteLine("Ajout d'une chambre");
            Console.Write("Prix: ");
            Decimal.TryParse(Console.ReadLine(), out decimal price);
            Console.Write("Capacité: ");
            Int32.TryParse(Console.ReadLine(), out int cap);
            Console.Write("Type de chambre: ");
            TypeChambre cTypeInput = TypeChambre.None;
            
            while (true)
            {
                var typeInput = Console.ReadLine();
                if (!Enum.TryParse<TypeChambre>(typeInput, ignoreCase: true, out cTypeInput))
                {
                    continue;
                }

                break;
            }

            Chambre chambre = new Chambre(cap, price, cTypeInput);
            hotel.AjouterChambre(chambre);
            break;
        case 2:
            Console.Clear();
            Console.WriteLine("Liste des chambres de l'hôtel: ");
            hotel.AfficherChambres();
            Console.ReadLine();
            break;
        case 3:
            Console.WriteLine("Recherche par type: ");
            Enum.TryParse(Console.ReadLine(), out TypeChambre typeSearch);
            hotel.AfficherChambresParType(typeSearch);
            break;
        case 4:
            Console.WriteLine("Liste des réservations: ");
            break;
        default:
            Console.WriteLine("Mauvaise action, retour au menu");
            break;
    }
}

namespace CoursPOO.Hotel;

public class Hotel
{
    public List<Chambre> _chambres;
    public List<Reservation> _reservations;

    public Hotel()
    {
        this._chambres = new List<Chambre>();
        this._reservations = new List<Reservation>();
    }

    public void AjouterChambre(Chambre chambre)
    {
        this._chambres.Add(chambre);
    }

    public void AfficherChambres()
    {
        foreach (var chambre in _chambres)
        {
            Console.WriteLine($"Numéro de chambre: {chambre.id}");
            Console.WriteLine($"Nombre de place: {chambre.capacity}");
            Console.WriteLine($"Type de chambre: {chambre.type.ToString()}");
        }
    }
    public void AfficherChambresParType(TypeChambre type)
    {
        _chambres.Sort();
        foreach (var chambre in _chambres)
        {
            if (chambre.type == type)
            {
                Console.WriteLine(chambre);
            }
        }
    }

    public void AnnulerReservation(Reservation reservation)
    {
        
    }
}
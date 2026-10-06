namespace CoursPOO.Hotel;

public class Reservation
{
    private Chambre _chambre {get; set;}

    private DateTime _dateDebut { get; set; }

    private DateTime _dateFin { get; set; }

    public string setDates(DateTime dateDebut, DateTime dateFin)
    {
        if (dateDebut > dateFin)
        {
            return "La date de fin est plus petite que celle de début.";
        }
        this._dateDebut = dateDebut;
        this._dateFin = dateFin;

        return "";
    }
}
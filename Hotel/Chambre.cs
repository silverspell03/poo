namespace CoursPOO.Hotel;

public class Chambre
{
    public int id { get; init; }
    public int capacity { get; private init; }
    private int _currentIndex = 0;

    public decimal price
    {
        get;
        private set
        {
            if (field < 0)
            {
                field = 0;
            }
        }
    }

    public TypeChambre type { get; set; }

    public Chambre(int capacity, decimal price, TypeChambre type)
    {
        this.id = _currentIndex;
        this.capacity = capacity;
        this.price = price;
        this.type = type;
        _currentIndex++;
    }
}
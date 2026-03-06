namespace Backend;

public class Invoice : IPay
{
    // Fields

    private float _quantity;
    private decimal _value;

    // Constructors

    public Invoice(int id, string description, Date date, float quantity, decimal value)
    {
        Description = description;
        Id = id;
        Quantity = quantity;
        Value = value;
        Date = date;
    }

    // Properties

    public string Description { get; set; } = null!;

    public int Id { get; set; }

    public float Quantity
    {
        get => _quantity;
        set => _quantity = ValidQuantity(value);
    }
    public decimal Value
    {
        get => _value;
        set => _value = ValidValue(value);
    }
    public Date Date { get; set; }

    // Methods
    public decimal GetValueToPay() => Value * (decimal)Quantity;
    public override string ToString()
    {
        return $"{Id}\t{Description}\n\t" +
               $"Value............: {Value,20:C2}\n\t" +
               $"Quantity.........: {Quantity,20:N2}\n\t" +
               $"Value to pay.....: {GetValueToPay(),20:C2}";
    }

    private float ValidQuantity(float quantity)
    {
        if (quantity < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(quantity), "Quantity must be greater than or equal to 0");
        }
        return quantity;
    }
    private decimal ValidValue(decimal value)
    {
        if (value < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(value), "Value must be greater than or equal to 0");
        }
        return value;
    }
}

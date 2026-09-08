public class Money
{
    public decimal Amount { get; }

    public Money(decimal amount)
    {
        Amount = amount;
    }

    public static Money operator +(Money a, Money b)
        => new(a.Amount + b.Amount);

    public static Money operator -(Money a, Money b)
        => new(a.Amount - b.Amount);

    public static Money operator -(Money a)
        => new(-a.Amount);

    public override string ToString()
        => $"{Amount:F2} руб.";
}
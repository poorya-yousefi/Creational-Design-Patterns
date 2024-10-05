namespace CreationalDesignPatterns.Prototype.CarFactory;

public class Car(int year, string color)
{
    public int Year { get; set; } = year;
    public string Color { get; set; } = color;

    public Car Clone()
    {
        return new Car(this.Year, this.Color);
    }
}

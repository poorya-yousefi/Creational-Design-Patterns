namespace CreationalDesignPatterns.AbstractFactory.UI_Theme.Interface;

public abstract class Button
{
    public string Color { get; init; }
    public string Text { get; set; }

    public void Render()
    {
        Console.WriteLine($"{Color}: {Text} >> Button");
    }
}
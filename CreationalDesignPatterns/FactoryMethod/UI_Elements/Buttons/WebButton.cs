namespace CreationalDesignPatterns.FactoryMethod.UI_Elements.Buttons;

public class WebButton : IButton
{
    public void Render()
    {
        Console.WriteLine("Rendering Web Button");
    }

    public void OnClick()
    {
        Console.WriteLine("OnClick Web button");
    }
}
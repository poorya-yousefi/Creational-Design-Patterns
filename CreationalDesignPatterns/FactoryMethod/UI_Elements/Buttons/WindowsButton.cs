namespace CreationalDesignPatterns.FactoryMethod.UI_Elements.Buttons;

public class WindowsButton : IButton
{
    public void Render()
    {
        Console.WriteLine("Rendering windows button");
    }

    public void OnClick()
    {
        Console.WriteLine("OnClick windows button");
    }
}
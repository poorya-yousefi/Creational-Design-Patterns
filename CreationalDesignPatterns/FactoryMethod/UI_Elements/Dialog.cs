namespace CreationalDesignPatterns.FactoryMethod.UI_Elements;

public abstract class Dialog
{
    abstract public IButton CreateButton();

    public void Render()
    {
        var button = CreateButton();
        button.OnClick();
        button.Render();
    }
}
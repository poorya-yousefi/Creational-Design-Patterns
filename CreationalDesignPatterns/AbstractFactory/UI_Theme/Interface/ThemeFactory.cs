namespace CreationalDesignPatterns.AbstractFactory.UI_Theme.Interface;

public abstract class ThemeFactory
{
    public abstract Button CreateButton();

    public void Render()
    {
        CreateButton().Render();
    }
}
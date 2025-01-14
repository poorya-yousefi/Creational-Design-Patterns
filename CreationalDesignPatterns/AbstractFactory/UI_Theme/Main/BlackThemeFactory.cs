using CreationalDesignPatterns.AbstractFactory.UI_Theme.Interface;

namespace CreationalDesignPatterns.AbstractFactory.UI_Theme.Main;

public class BlackThemeFactory : ThemeFactory
{
    public override Button CreateButton()
    {
        return new BlackButton("BlackButton");
    }
}
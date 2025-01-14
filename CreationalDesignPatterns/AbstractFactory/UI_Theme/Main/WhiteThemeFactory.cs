using CreationalDesignPatterns.AbstractFactory.UI_Theme.Interface;

namespace CreationalDesignPatterns.AbstractFactory.UI_Theme.Main;

public class WhiteThemeFactory : ThemeFactory
{
    public override Button CreateButton()
    {
        return new WhiteButton("WhiteButton");
    }
}
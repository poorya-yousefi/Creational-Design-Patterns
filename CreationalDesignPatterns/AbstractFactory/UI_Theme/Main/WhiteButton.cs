using CreationalDesignPatterns.AbstractFactory.UI_Theme.Interface;

namespace CreationalDesignPatterns.AbstractFactory.UI_Theme.Main;

public class WhiteButton : Button
{
    public WhiteButton(string text)
    {
        Color = "White";
        Text = text;
    }
}
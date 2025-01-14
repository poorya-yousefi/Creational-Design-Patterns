using CreationalDesignPatterns.AbstractFactory.UI_Theme.Interface;

namespace CreationalDesignPatterns.AbstractFactory.UI_Theme.Main;

public class BlackButton : Button
{
    public BlackButton(string text)
    {
        Color = "Black";
        Text = text;
    }
}
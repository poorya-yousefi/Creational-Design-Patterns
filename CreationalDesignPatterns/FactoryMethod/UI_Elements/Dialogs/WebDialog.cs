using CreationalDesignPatterns.FactoryMethod.UI_Elements.Buttons;

namespace CreationalDesignPatterns.FactoryMethod.UI_Elements.Dialogs;

public class WebDialog : Dialog
{
    public override IButton CreateButton() => new WebButton();
}
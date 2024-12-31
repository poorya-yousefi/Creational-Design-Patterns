using CreationalDesignPatterns.FactoryMethod.UI_Elements.Dialogs;

namespace CreationalDesignPatterns.FactoryMethod.UI_Elements;

public class Application
{
    private Dialog dialog;

    public void Run()
    {
        var config = "Web";

        dialog = config switch
        {
            "Windows" => new WindowsDialog(),
            "Web" => new WebDialog(),
            _ => throw new ArgumentException()
        };
        
        dialog.Render();
    }
}
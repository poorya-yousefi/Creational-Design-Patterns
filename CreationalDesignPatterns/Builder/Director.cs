namespace CreationalDesignPatterns.Builder;

public class Director
{
    public void BuildTypeA(IBuilder builder)
    {
        builder.Start();
        builder.Step1();
        builder.Step2();
        builder.Step3();
    }

    public void BuildTypeB(IBuilder builder)
    {
        builder.Start();
        builder.Step1();
        builder.Step3();
    }

    public void BuildTypeC(IBuilder builder)
    {
        builder.Start();
        builder.Step2();
        builder.Reset();
        builder.Step3();
    }
}

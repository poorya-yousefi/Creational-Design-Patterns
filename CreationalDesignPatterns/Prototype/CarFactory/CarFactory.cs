namespace CreationalDesignPatterns.Prototype.CarFactory;

public class CarFactory
{
    private Car carPrototype;

    public CarFactory(Car prototype) {
        this.carPrototype = prototype;
    }

    public Car createCar() {
        return carPrototype.Clone();
    }

}

class Car : IVehicle
{
    private int gasoline;

    public Car(int startingGasoline)
    {
        gasoline = startingGasoline;
    }

    public void Drive()
    {
        if (gasoline > 0)
        {
            Console.WriteLine("Driving");
        }
    }

    public bool Refuel(int amount)
    {
        gasoline += amount;
        return true;
    }
}

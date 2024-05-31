namespace Builder.StepwiseBuilder.Builders;

public static class CarBuilder
{
    public static ISpecifyCarType Create() => new Impl();

    private class Impl : ISpecifyCarType, ISpecifyWheelSize, IBuildCar
    {
        private readonly Car _car = new();

        public Car Build() => _car;

        public ISpecifyWheelSize OfType(CarType type)
        {
            _car.Type = type;
            return this;
        }

        public IBuildCar WithWheels(int size)
        {
            switch (_car.Type)
            {
                case CarType.Crossover when size is < 17 or > 20:
                case CarType.Sedan when size is < 15 or > 17:
                    throw new ArgumentException($"Wrong size of wheel for {_car.Type}");
            }

            _car.WheelSize = size;
            return this;
        }
    }
}
namespace AbstractFactoryDemo
{
    public class FactoryProducer
    {
        public static AbstractFactory GetFactory(bool isRounded)
        {
            if (isRounded)
            {
                return new RoundedShapeFactory();
            }
            else
            {
                return new ShapeFactory();
            }
        }
    }
}
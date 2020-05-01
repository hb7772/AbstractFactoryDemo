namespace AbstractFactoryDemo
{
    public abstract class AbstractFactory
    {
        public abstract IShape GetShape(ShapeType shapeType);
    }
}
namespace AbstractFactoryDemo
{
    public class ShapeFactory : AbstractFactory
    {
        public override IShape GetShape(ShapeType shapeType)
        {
            if (shapeType == ShapeType.Rectangle)
                {
                    return new Rectangle();
                }
            else if (shapeType == ShapeType.Square)
                {
                    return new Square();
                }
            return null;
        }
    }
}
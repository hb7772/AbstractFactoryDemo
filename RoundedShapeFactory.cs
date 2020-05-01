namespace AbstractFactoryDemo
{
    public class RoundedShapeFactory : AbstractFactory
    {
        public override IShape GetShape(ShapeType shapeType)
        {
            if (shapeType == ShapeType.Rectangle)
                {
                    return new RoundedRectangle();
                }
            else if (shapeType == ShapeType.Square)
                {
                    return new RoundedSquare();
                }
            return null;
        }
    }
}
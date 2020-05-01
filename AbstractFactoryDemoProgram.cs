using System;

namespace AbstractFactoryDemo
{
    class AbstractFactoryDemo
    {
        static void Main(string[] args)
        {
            AbstractFactory shapeFactory = FactoryProducer.GetFactory(false);
            IShape rectangle = shapeFactory.GetShape(ShapeType.Rectangle);
            rectangle.Draw();

            IShape square = shapeFactory.GetShape(ShapeType.Square);
            square.Draw();

            AbstractFactory roundedShapeFactory = FactoryProducer.GetFactory(true);
            IShape roundedRectangle = roundedShapeFactory.GetShape(ShapeType.Rectangle);
            roundedRectangle.Draw();

            IShape roundedSquare = roundedShapeFactory.GetShape(ShapeType.Square);
            roundedSquare.Draw();
        }
    }
}

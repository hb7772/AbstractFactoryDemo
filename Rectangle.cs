using System;

namespace AbstractFactoryDemo
{
    public class Rectangle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Inside Rectange::Draw() method");
        }
    }
}
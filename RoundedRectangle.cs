using System;

namespace AbstractFactoryDemo
{
    public class RoundedRectangle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Inside RoundedRectange::Draw() method");
        }
    }
}
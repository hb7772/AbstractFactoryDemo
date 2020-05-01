using System;

namespace AbstractFactoryDemo
{
    public class RoundedSquare : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Inside RoundedSquare::Draw() method");
        }
    }
}
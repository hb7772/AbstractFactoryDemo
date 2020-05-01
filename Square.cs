using System;

namespace AbstractFactoryDemo
{
    public class Square : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Inside Square::Draw() method");
        }
    }
}
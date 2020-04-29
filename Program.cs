using System;

namespace AdapterExercise
{
    // You are given an IRectangle interface and an extension method on it. Try to define 
    // a SquareToRectangleAdapter that adapts the square to the IRectangle interface. 

    public class Square
    {
        public int Side;
    }

    public interface IRectangle
    {
        int Width { get; }
        int Height { get; }
    }

    public static class ExtensionMethods
    {
        public static int Area(this IRectangle rc)
        {
            return rc.Width * rc.Height;
        }
    }

    public class SquareToRectangleAdapter : IRectangle
    {
        private int Side;
        public SquareToRectangleAdapter(Square square)
        {
            this.Side = square.Side;
        }
        public int Width => Side;
        public int Height => Side;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Square s = new Square { Side = 10 };
            SquareToRectangleAdapter adapter = new SquareToRectangleAdapter(s);
            Console.WriteLine(adapter.Area());
        }
    }
}

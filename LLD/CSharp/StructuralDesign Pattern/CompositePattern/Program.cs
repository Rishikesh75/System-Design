using System;
namespace CompositePattern
{
    public interface IGraphic
    {
        void Draw();
    }

    // Leaf - Line
    public class Line : IGraphic
    {
        public void Draw()
        {
            Console.WriteLine("Drawing a Line");
        }
    }

    // Leaf - Circle
    public class Circle : IGraphic
    {
        public void Draw()
        {
            Console.WriteLine("Drawing a Circle");
        }
    }

    // Composite - Group
    public class Group : IGraphic
    {
        // Group HAS IGraphic (Aggregation/Composition)
        private List<IGraphic> _graphics = new List<IGraphic>();

        public void Add(IGraphic graphic)
        {
            _graphics.Add(graphic);
        }

        public void Remove(IGraphic graphic)
        {
            _graphics.Remove(graphic);
        }

        public void Draw()
        {
            Console.WriteLine("Drawing a Group:");
            foreach (var graphic in _graphics)
            {
                graphic.Draw(); // Delegates drawing to children
            }
        }
    }




    public class Program
    {
        public static void Main(string[] args)
        {
            
        }
    }
    

}
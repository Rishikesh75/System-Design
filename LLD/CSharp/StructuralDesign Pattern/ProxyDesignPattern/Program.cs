using System;

namespace ProxyDesignPattern
{
    public interface IImage
    {
        void SetImage();
    }

    public class RealImage : IImage
    {
        public void SetImage()
        {
            Console.WriteLine("Real Image");
        }
    }

    public class ProxyImage : IImage
    {
        private IImage image;

        public ProxyImage()  // Make constructor public
        {
            image = new RealImage();
        }

        public void SetImage()
        {
            Console.WriteLine("Access via ProxyImage");
            image.SetImage();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            IImage img = new ProxyImage();
            img.SetImage();
        }
    }
}

using System;
namespace FactoryDesignPattern
{
    public interface IVechile
    {
        void Vechile();    
    }

    public class TwoWheeler : IVechile
    {
        public void Vechile()
        {
            Console.WriteLine("Two Wheeler Vechile");
        }
    }
    public class FourWheeler : IVechile
    {
        public void Vechile()
        {
            Console.WriteLine("This is FourVechile");
        }
    }


    public interface Factory
    { 
        IVechile CreateVechile();
    }

    public class TwoWheelerFactory : Factory
    { 
        public IVechile CreateVechile()
        {
            return new TwoWheeler();
        }
    }

    public class FourWheelerFactory : Factory
    {
        public IVechile CreateVechile()
        {
            return new TwoWheeler();
        }
    }
    public class Client
    {

        public IVechile vechile;

        public Client(IVechile vechile)
        {
            this.vechile = vechile;
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            TwoWheelerFactory twoWheelerFactory = new TwoWheelerFactory();

            FourWheelerFactory fourWheelerFactory = new FourWheelerFactory();

              Client client = new Client(twoWheelerFactory.CreateVechile());

              client.vechile.Vechile();


              
        }
    }
    


}



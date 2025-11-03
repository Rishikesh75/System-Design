using System;
namespace ProtoTypePattern
{

    public interface Iproduct
    {
        Iproduct clone();
    
    }

    public class TV : Iproduct
    {
        string tvName = "LG";

        public TV() { }
        public Iproduct clone()
        {
            return new TV();
        }
    }

    public class Prototype
    {
        Iproduct product;

        public Prototype(Iproduct prdouct)
        {
            this.product = prdouct;
        }

        public Iproduct CreateProtoType()
        {
            return product.clone();
        }
    }

    public class Program
    { 
        public static void Main(string[] args)
        {
            TV tv = new TV();
            Prototype p = new Prototype(tv);
            Iproduct tv2 = p.CreateProtoType();


        }
    
    }








}


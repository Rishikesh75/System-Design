//Changing the behaviour at the Runtime;
public interface FlyBehvaiour
{
    public void fly();
}
public interface QuackBehaviour
{
    public void quack();
}
public class FlywithWings implements FlyBehvaiour
{
    @Override
    public void fly()
    {
        System.out.println("I am Flying with Wingsat 20 feet High");
    }
}
public class NoFly implements FlyBehvaiour
{
    @Override
    public void fly()
    {
        System.out.println("I Cann't Fly");
    }
}
public class quack1 implements QuackBehaviour
{
    @Override
    public void quack()
    {
        System.out.println("I will Quack-1");
    }
}
public class quack2 implements QuackBehaviour
{
    @Override
    public void quack()
    {
        System.out.println("I will Quack-2");
    }
}
public class Duck
{
    public QuackBehaviour quackbehaviour;
    public FlyBehvaiour flybehaviour;
    public setflybehaviour(quack2 qb)
    {
        this.quackbehaviour = qb;
    }
    public setflybehaviour(quack1 qb)
    {
        this.quackbehaviour = qb;
    }
    public setquackbehaviour(NoFly fy)
    {
        this.flybehaviour = fy;
    }
    public setquackbehaviour(FlywithWings fy)
    {
        this.flybehaviour = fy;
    }
    public void  swim()
    {
        System.out.println("Duck is Swimming..");
    }
    public void display()
    {
        System.out.println("I am Duck Display function")
    }
}
public class StrategyPattern {
    public static void main(String[] args) {
        System.out.println("HelloWorld");
    }
}

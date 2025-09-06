using System;
using System.Collections.Generic;

// Mediator Interface
public interface IChatMediator
{
    void SendMessage(string message, User user);
    void AddUser(User user);
}

// Concrete Mediator
public class ChatMediator : IChatMediator
{
    private List<User> users = new List<User>();

    public void AddUser(User user)
    {
        users.Add(user);
    }

    public void SendMessage(string message, User sender)
    {
        foreach (var user in users)
        {
            // Don't send the message back to the sender
            if (user != sender)
            {
                user.Receive(message, sender.Name);
            }
        }
    }
}

// Colleague Abstract Class
public abstract class User
{
    protected IChatMediator mediator;
    public string Name { get; private set; }

    public User(IChatMediator mediator, string name)
    {
        this.mediator = mediator;
        this.Name = name;
    }

    public abstract void Send(string message);
    public abstract void Receive(string message, string senderName);
}

// Concrete Colleague
public class ChatUser : User
{
    public ChatUser(IChatMediator mediator, string name) : base(mediator, name) { }

    public override void Send(string message)
    {
        Console.WriteLine($"{Name} sends: {message}");
        mediator.SendMessage(message, this);
    }

    public override void Receive(string message, string senderName)
    {
        Console.WriteLine($"{Name} received from {senderName}: {message}");
    }
}

// Client
public class Program
{
    public static void Main(string[] args)
    {
        IChatMediator chatMediator = new ChatMediator();

        User user1 = new ChatUser(chatMediator, "Alice");
        User user2 = new ChatUser(chatMediator, "Bob");
        User user3 = new ChatUser(chatMediator, "Charlie");

        chatMediator.AddUser(user1);
        chatMediator.AddUser(user2);
        chatMediator.AddUser(user3);

        user1.Send("Hi Everyone!");
        user2.Send("Hello Alice!");
    }
}

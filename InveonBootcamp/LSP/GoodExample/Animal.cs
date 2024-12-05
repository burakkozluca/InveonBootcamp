namespace InveonBootcamp.LSP.GoodExample;

public abstract class Animal
{
    public abstract void Speak();
}

public class Dog : Animal
{
    public override void Speak()
    {
        Console.WriteLine("The dog barks.");
    }
}

public class Cat : Animal
{
    public override void Speak()
    {
        Console.WriteLine("The cat barks.");
    }
    // Speak metodunu geçersiz kılmıyoruz, varsayılan davranışı kullanıyoruz.
}

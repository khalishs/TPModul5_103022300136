using System;

class HaloGeneric
{
    public void SapaUser<T>(T input)
    {
        Console.WriteLine($"Halo user {input}");
    }
}

class Program
{
    static void Main()
    {
        HaloGeneric halo = new HaloGeneric();

        halo.SapaUser("Khalish"); 
    }
}


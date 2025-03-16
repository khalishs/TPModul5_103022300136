using System;

HEAD
class HaloGeneric
{
    public void SapaUser<T>(T input)
    {
        Console.WriteLine($"Halo user {input}");

class DataGeneric<T>
{
    private T data;
    public DataGeneric(T data)
    {
        this.data = data;
    }

    // Method untuk mencetak data
    public void PrintData()
    {
        Console.WriteLine($"Data yang tersimpan adalah: {data}");
 generic-class
    }
}

class Program
{
    static void Main()
    {
HEAD
        HaloGeneric halo = new HaloGeneric();

        halo.SapaUser("Khalish"); 
    }
}


        DataGeneric<long> dataNIM = new DataGeneric<long>(103022300136);

        dataNIM.PrintData();
    }
}


generic-class

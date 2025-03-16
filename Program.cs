using System;

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
    }
}

class Program
{
    static void Main()
    {
        DataGeneric<long> dataNIM = new DataGeneric<long>(103022300136);

        dataNIM.PrintData();
    }
}



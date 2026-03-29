using System;

namespace KPL5
{
    public class DataGeneric<T>
{
    private T data;

    public DataGeneric(T data)
    {
        this.data = data;
    }

    public void PrintData()
    {
        Console.WriteLine($"Data yang tersimpan adalah: {this.data}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        DataGeneric<string> dataNIM = new DataGeneric<string>("103022400068");
        dataNIM.PrintData();
    }
}
}
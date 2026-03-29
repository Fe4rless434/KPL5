using System;

namespace KPL5
{

    public class HaloGeneric
    {
        public void SapaUser<T>(T user)
        {
            Console.WriteLine($"Halo user {user}");
        }
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

                HaloGeneric halo = new HaloGeneric();
                halo.SapaUser<string>("Dhaifullah");

                DataGeneric<string> dataNIM = new DataGeneric<string>("103022400068");
                dataNIM.PrintData();

            }
        }
    }
}
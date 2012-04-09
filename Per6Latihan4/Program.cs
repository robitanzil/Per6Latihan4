using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Per6Latihan4
{
    class Program
    {
        static void Main(string[] args)
        {
            AddressInternational ai = new AddressInternational("40132");

            ai.Street = "Jalan Dago";
            // ai.ZipCode = "40132";
            ai.Country = "Indonesia";

            ai.CetakAlamat();

            Console.ReadLine();
        }
    }
}

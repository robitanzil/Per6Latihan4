using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Per6Latihan4
{
    class Address
    {
        public string Street { get; set; }
        public string ZipCode { get; set; }

        public Address(string ZipCode)
        {
            this.ZipCode = ZipCode;
        }

        public virtual void CetakAlamat()
        {
            Console.WriteLine(Street + Environment.NewLine + ZipCode);
        }
    }
}

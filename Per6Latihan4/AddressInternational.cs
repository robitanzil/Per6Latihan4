using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Per6Latihan4
{
    class AddressInternational : Address
    {
        public string Country { get; set; }

        public AddressInternational(string ZipCode)
            : base(ZipCode)
        {
            
        }

        public override void CetakAlamat()
        {
            base.CetakAlamat();
            Console.WriteLine(Country);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Letter_Distributor_Client
{
    class Letter
    {
        private string Name { get; set; }
        private string Address { get; set; }
        private int PostalCode { get; set; }
        private string ReferenceId { get; set; }
        private string ContentAsBase64String { get; set; }

        public Letter(string name, string address, int postalCode, string referenceId, string contentAsBase64String)
        {
            Name = name;
            Address = address;
            PostalCode = postalCode;
            ReferenceId = referenceId;
            ContentAsBase64String = contentAsBase64String;
        }
    }
}

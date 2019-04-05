using System.Collections.Generic;

namespace SnelStart.B2B.V2.Client.Operations
{
    public class BankafschriftBestandResponseError
    {
        public string Description { get; set; }
        public IEnumerable<string> Details { get; set; }
    }
}
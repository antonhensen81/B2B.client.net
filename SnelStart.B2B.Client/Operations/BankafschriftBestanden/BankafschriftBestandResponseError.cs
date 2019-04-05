using System.Collections.Generic;

namespace SnelStart.B2B.Client.Operations
{
    public class BankafschriftBestandResponseError
    {
        public string Description { get; set; }
        public IEnumerable<string> Details { get; set; }
    }
}
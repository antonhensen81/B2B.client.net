using System;

namespace SnelStart.B2B.V2.Client.Operations
{
    public interface IIdentifierModel
    {
        Guid Id { get; }
        Uri Uri { get; }
    }
}
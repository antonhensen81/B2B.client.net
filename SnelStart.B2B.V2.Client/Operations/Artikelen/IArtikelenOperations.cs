using System;

namespace SnelStart.B2B.V2.Client.Operations
{
    public interface IArtikelenOperations : ICrudOperations<ArtikelModel>, IGetAllOperations<ArtikelModel>, IQueryOperations<ArtikelModel>
    {
    }
}

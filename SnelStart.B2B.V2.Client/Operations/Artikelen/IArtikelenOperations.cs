using System;

namespace SnelStart.B2B.Client.Operations
{
    public interface IArtikelenOperations : ICrudOperations<ArtikelModel>, IGetAllOperations<ArtikelModel>, IQueryOperations<ArtikelModel>
    {
    }
}

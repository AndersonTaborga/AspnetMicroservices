using Catalog.API.Entities;
using MongoDB.Driver;
using System.Collections.Generic;

namespace Catalog.API.Data
{
    public interface ICatalogContext
    {
        IMongoCollection<Product> Products { get; }
        
    }
}

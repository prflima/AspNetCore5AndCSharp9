using System;

namespace Catalog.Entities
{
    /* Available in .net 5 the record types are immutable, it is not allowed to change any data 
    received from this type of object, perfect for what we need.*/
    public record Item
    {
        public Guid Id { get; init; }
        public string Name { get; init; }
        public decimal Price { get; init; }
        public DateTimeOffset CreatedDate { get; init; }
    }
}
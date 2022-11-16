using System;
using System.Collections.Generic;
using System.Linq;
using Catalog.Entities;

namespace Catalog.Repositories
{
    public class InMemItemRepository
    {
        private readonly List<Item> items = new()
        {
            new Item{Id = Guid.NewGuid(), Name = "Blue Potion", Price = 9, CreatedDate = DateTimeOffset.UtcNow},
            new Item{Id = Guid.NewGuid(), Name = "Poring Card", Price = 10, CreatedDate = DateTimeOffset.UtcNow},
            new Item{Id = Guid.NewGuid(), Name = "Sword Mastery", Price = 100, CreatedDate = DateTimeOffset.UtcNow}
        };

        public IEnumerable<Item> GetItems()
        {
            return items;
        }

        public Item GetItem(Guid id)
        {
            return items.FirstOrDefault(item => item.Id == id);
        }
    }
}
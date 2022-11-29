using System;
using System.Collections.Generic;
using System.Linq;
using Catalog.Entities;

namespace Catalog.Repositories
{  
    public class InMemItemRepository : IItemRepository
    {
        private readonly List<Item> items = new()
        {
            new Item { Id = Guid.NewGuid(), Name = "Blue Potion", Price = 9, CreatedDate = DateTimeOffset.UtcNow },
            new Item { Id = Guid.NewGuid(), Name = "Poring Card", Price = 10, CreatedDate = DateTimeOffset.UtcNow },
            new Item { Id = Guid.NewGuid(), Name = "Sword Mastery", Price = 100, CreatedDate = DateTimeOffset.UtcNow }
        };

        public IEnumerable<Item> GetItems()
        {
            return items;
        }

        public Item GetItem(Guid id)
        {
            return items.FirstOrDefault(item => item.Id == id);
        }

        public void CreateItem(Item item)
        {
            items.Add(item);
        }

        public void UpdateItem(Item item)
        {
            var index = GetIndexOfItem(item.Id);
            items[index] = item;
        }

        public void DeleteItem(Guid id)
        {
            var index = GetIndexOfItem(id);
            items.RemoveAt(index);
        }

        private int GetIndexOfItem(Guid id)
        {
            return items.FindIndex(it => it.Id == id);
        }
    }
}
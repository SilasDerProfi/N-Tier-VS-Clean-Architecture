using Persistance;

namespace Application
{
    public static class ItemTransactionScript
    {
        public static List<Item> GetAllItems() => Database.QueryItems(i => true)
                                                          .Select(i => new Item(i.id, i.name))
                                                          .ToList();

        internal static Item? GetById(int itemId) => Database.QueryItems(i => i.id == itemId)
                                                             .Select(i => new Item(i.id, i.name))
                                                             .FirstOrDefault();
    }
}

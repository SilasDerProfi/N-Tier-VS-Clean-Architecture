using Adapters;
using Adapters.MappingClasses;
using Domain;

namespace Plugins.Database
{
    internal class Database
    {
        private static readonly List<(int id, string name)> _items;

        static Database() => _items = new()
        {
            (0, "Apfelessig"),
            (1, "LEGO 75192"),
            (2, "Ravioli"),
            (3, "Mini Babybel"),
            (4, "Mineralwasser 0,5 Liter"),
        };

        public static IEnumerable<(int id, string name)> QueryItems(Func<(int id, string name), bool> query) => _items.Where(query);

        public static ItemService GenerateItemService() => new(
            getItemByIdCallback: a => QueryItems(b => b.id == a).Select(b => new Item(b.id, b.name)).FirstOrDefault(),
            getAllItemsCallback: () => QueryItems(a => true).Select(a => new ItemModel(a.id, a.name)).ToList());
    }
}

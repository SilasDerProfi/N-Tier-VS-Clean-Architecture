using Adapters.MappingClasses;
using Application;
using Domain;

namespace Adapters
{
    public class ItemService : IItemService
    {
        private readonly Func<int, Item?> _getItemByIdCallback;
        private readonly Func<List<ItemModel>> _getAllItemsCallback;

        public ItemService(Func<int, Item?> getItemByIdCallback, Func<List<ItemModel>> getAllItemsCallback)
        {
            _getItemByIdCallback = getItemByIdCallback;
            _getAllItemsCallback = getAllItemsCallback;
        }

        public Item? GetItemById(int itemId) => _getItemByIdCallback(itemId);

        public List<ItemModel> GetAllItems() => _getAllItemsCallback();
    }
}

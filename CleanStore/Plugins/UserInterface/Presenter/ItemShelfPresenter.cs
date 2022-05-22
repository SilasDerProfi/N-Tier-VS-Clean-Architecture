using Adapters;
using Adapters.MappingClasses;

namespace Plugins.UserInterface.Presenter
{
    public class ItemShelfPresenter
    {
        private readonly List<ItemModel> _items;

        public ItemShelfPresenter(ItemService itemService) => _items = itemService.GetAllItems();

        public void Show() => _items.ForEach(item => Console.WriteLine(item));
    }
}

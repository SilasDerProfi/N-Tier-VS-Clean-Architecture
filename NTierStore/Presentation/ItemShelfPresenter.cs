using Application;

namespace Presentation
{
    public class ItemShelfPresenter
    {
        private readonly List<Item> _items;

        public ItemShelfPresenter()
        {
            _items = ItemTransactionScript.GetAllItems();
        }

        public void Show() => _items.ForEach(item =>  Console.WriteLine(item));
    }
}

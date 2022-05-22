using Adapters;
using Adapters.MappingClasses;

namespace Plugins.UserInterface.Presenter
{
    public class ShoppingCartPresenter
    {
        private readonly ShoppingCartModel _shoppingCart;

        public ShoppingCartPresenter(ItemService itemService) => _shoppingCart = new(itemService);

        public void Show() => Console.WriteLine(_shoppingCart);

        public void AddItem(int itemId) => _shoppingCart.AddItem(itemId);
        public void RemoveItem(int itemId) => _shoppingCart.RemoveItem(itemId);
    }
}
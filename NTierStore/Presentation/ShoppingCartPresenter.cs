using Application;

namespace Presentation
{
    public class ShoppingCartPresenter
    {
        private readonly ShoppingCart _shoppingCart;

        public ShoppingCartPresenter() => _shoppingCart = new();

        public void Show() => Console.WriteLine(_shoppingCart);

        public void AddItem(int itemId) => _shoppingCart.AddItem(itemId);
        public void RemoveItem(int itemId) => _shoppingCart.RemoveItem(itemId);
    }
}
using Application;

namespace Adapters.MappingClasses
{
    public class ShoppingCartModel
    {
        private readonly ShoppingCartManager _shoppingCartItemManager;

        public ShoppingCartModel(ItemService itemService) => _shoppingCartItemManager = new ShoppingCartManager(itemService);

        public void AddItem(int itemId) => _shoppingCartItemManager.AddItem(itemId);

        public void RemoveItem(int itemId) => _shoppingCartItemManager.RemoveItem(itemId);

        public override string ToString() => string.Join("\r\n", _shoppingCartItemManager.GetAllItems().Select(i => $"{ i.id: D4} | {i.name, -30}{i.amount,5}"));
    }
}

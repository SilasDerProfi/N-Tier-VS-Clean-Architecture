using Domain;

namespace Application
{
    public class ShoppingCartManager
    {
        private readonly IItemService _itemService;
        private readonly ShoppingCart _shoppingCart;

        public ShoppingCartManager(IItemService shoppingCartService)
        {
            _itemService = shoppingCartService;
            _shoppingCart = new();
        }

        private int AmountOfItem(int itemId) => _shoppingCart.Items.FirstOrDefault(i => i.item.Id == itemId).amount;

        public void AddItem(int itemId)
        {
            if (AmountOfItem(itemId) > 0)
            {
                var item = _shoppingCart.Items.FirstOrDefault(i => i.item.Id == itemId);
                _shoppingCart.Items.Remove(item);
                item.amount++;
                _shoppingCart.Items.Add(item);
            }
            else
            {
                var item = _itemService.GetItemById(itemId);
                if (item != null)
                    _shoppingCart.Items.Add((item, 1));
            }
        }

        public void RemoveItem(int itemId)
        {
            var amount = AmountOfItem(itemId);
            var item = _shoppingCart.Items.FirstOrDefault(i => i.item.Id == itemId);
            _shoppingCart.Items.Remove(item);

            if (amount > 1)
            {
                item.amount--;
                _shoppingCart.Items.Add(item);
            }
        }
        public IEnumerable<(int id, string name, int amount)> GetAllItems() => _shoppingCart.Items.Select(i => (i.item.Id, i.item.Name, i.amount));

    }
}
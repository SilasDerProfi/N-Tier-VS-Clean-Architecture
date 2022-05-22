namespace Application
{
    public sealed class ShoppingCart
    {
        public List<(Item item, int amount)> Items { get; } = new();

        public override string ToString() => string.Join("\r\n", Items.Select(i => i.item + $"{i.amount,5}"));

        public void AddItem(int itemId)
        {
            if(AmountOfItem(itemId) > 0)
            {
                var item = Items.FirstOrDefault(i => i.item.Id == itemId);
                Items.Remove(item);
                item.amount++;
                Items.Add(item);
            }
            else
            {
                var item = ItemTransactionScript.GetById(itemId);
                if(item != null)
                    Items.Add((item, 1));
            }
        }

        public void RemoveItem(int itemId)
        {
            var amount = AmountOfItem(itemId);
            var item = Items.FirstOrDefault(i => i.item.Id == itemId);
            Items.Remove(item);

            if (amount > 1)
            {
                item.amount--;
                Items.Add(item);
            }
        }

        private int AmountOfItem(int itemId) => Items.FirstOrDefault(i => i.item.Id == itemId).amount;
    }
}
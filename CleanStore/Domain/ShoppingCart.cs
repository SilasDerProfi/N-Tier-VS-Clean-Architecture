namespace Domain
{
    public sealed class ShoppingCart
    {
        public List<(Item item, int amount)> Items { get; } = new();
    }
}

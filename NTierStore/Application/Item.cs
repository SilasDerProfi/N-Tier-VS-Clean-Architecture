namespace Application
{
    public sealed class Item
    {
        internal Item(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; }

        public string Name { get; }

        public override string ToString() => $"{Id:D4} | {Name,-30}";
    }
}

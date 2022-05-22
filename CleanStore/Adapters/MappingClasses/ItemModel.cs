namespace Adapters.MappingClasses
{
    public class ItemModel
    {
        private readonly int _id;
        private readonly string _name;

        public ItemModel(int id, string name)
        {
            _id = id;
            _name = name;
        }

        public override string ToString() => $"{_id:D4} | {_name,-30}";
    }
}

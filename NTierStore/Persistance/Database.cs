namespace Persistance
{
    public static class Database
    {
        private static readonly List<(int id, string name)> _items;

        static Database() => _items = new()
        {
            (0, "Apfelessig"),
            (1, "LEGO 75192"),
            (2, "Ravioli"),
            (3, "Mini Babybel"),
            (4, "Mineralwasser 0,5 Liter"),
        };


        public static IEnumerable<(int id, string name)> QueryItems(Func<(int id, string name), bool> query) => _items.Where(query);
    }
}
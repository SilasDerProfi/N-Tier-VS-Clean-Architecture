using UserInferface.Presenter;

var itemShelf = new ItemShelfPresenter();
var shoppingCart = new ShoppingCartPresenter();

while (true)
{
    Console.WriteLine("Shelf:");
    itemShelf.Show();

    Console.WriteLine("\r\nShopping cart:");
    shoppingCart.Show();

    Console.WriteLine("\r\n'Add {number}' OR 'Remove {number}':");
    var command = (Console.ReadLine() ?? "").Split(' ');

    if (command[0].Equals("stop", StringComparison.InvariantCultureIgnoreCase))
        break;

    var itemId = int.Parse(command[1]);

    if (command[0].Equals("Add", StringComparison.InvariantCultureIgnoreCase))
        shoppingCart.AddItem(itemId);
    else if (command[0].Equals("Remove", StringComparison.InvariantCultureIgnoreCase))
        shoppingCart.RemoveItem(itemId);

    Console.Clear();
}
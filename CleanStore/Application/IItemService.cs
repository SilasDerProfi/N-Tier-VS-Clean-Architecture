using Domain;

namespace Application
{
    public interface IItemService
    {
        Item? GetItemById(int itemId);
    }
}
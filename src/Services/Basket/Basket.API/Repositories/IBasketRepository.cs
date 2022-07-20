using Basket.API.Entities;

namespace Basket.API.Repositories
{
    public interface IBasketRepository
    {
        Task<ShoppingCart> GetBasket(string user);
        Task<ShoppingCart> UpdateBasket(ShoppingCart cart);

        Task DeleteBasket(string user);
    }
}

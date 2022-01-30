using BasketApiwithRedis.Entities;
using System.Threading.Tasks;

namespace BasketApiwithRedis.Repositories
{
    public interface IBasketRepository
    {
        Task<ShoppingCart> GetBasket(string userName);
        Task<ShoppingCart> UpdateBasket(ShoppingCart basket);
        Task DeleteBasket(string userName);
    }
}

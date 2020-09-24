using METWebShop.Core.Data;

namespace METWebShop.DAL.Interfaces.Repository
{
    public interface IOrderRepository
    {
        Order GetOrderById(int id);
        Order PlaceOrder(Order newOrder);
        Order Delete(int id);

        int Commit();

    }
}

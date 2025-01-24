using Infrastructure.Attribute;
using ZR.Model.Business;

namespace ZR.Repository
{
    /// <summary>
    /// Order4仓储
    /// </summary>
    [AppService(ServiceLifetime = LifeTime.Transient)]
    public class Order4Repository : BaseRepository<Order4>
    {
    }
}
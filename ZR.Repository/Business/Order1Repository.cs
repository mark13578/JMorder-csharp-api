using Infrastructure.Attribute;
using ZR.Model.Business;

namespace ZR.Repository
{
    /// <summary>
    /// 建立訂單仓储
    /// </summary>
    [AppService(ServiceLifetime = LifeTime.Transient)]
    public class Order1Repository : BaseRepository<Order1>
    {
    }
}
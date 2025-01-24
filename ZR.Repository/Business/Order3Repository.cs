using Infrastructure.Attribute;
using ZR.Model.Business;

namespace ZR.Repository
{
    /// <summary>
    /// 檔案上傳仓储
    /// </summary>
    [AppService(ServiceLifetime = LifeTime.Transient)]
    public class Order3Repository : BaseRepository<Order3>
    {
    }
}
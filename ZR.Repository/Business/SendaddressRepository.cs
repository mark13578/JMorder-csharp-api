using Infrastructure.Attribute;
using ZR.Model.Business;

namespace ZR.Repository
{
    /// <summary>
    /// 寄送地址維護仓储
    /// </summary>
    [AppService(ServiceLifetime = LifeTime.Transient)]
    public class SendaddressRepository : BaseRepository<Sendaddress>
    {
    }
}
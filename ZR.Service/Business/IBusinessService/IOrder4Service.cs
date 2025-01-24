using ZR.Model.Business.Dto;
using ZR.Model.Business;

namespace ZR.Service.Business.IBusinessService
{
    /// <summary>
    /// Order4service接口
    /// </summary>
    public interface IOrder4Service : IBaseService<Order4>
    {
        PagedInfo<Order4Dto> GetList(Order4QueryDto parm);

        Order4 GetInfo(int Id);

        List<Order4> GetTreeList(Order4QueryDto parm);

        Order4 AddOrder4(Order4 parm);
        int UpdateOrder4(Order4 parm);


    }
}

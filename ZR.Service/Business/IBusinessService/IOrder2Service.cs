using ZR.Model.Business.Dto;
using ZR.Model.Business;

namespace ZR.Service.Business.IBusinessService
{
    /// <summary>
    /// 建立訂單_建立備註service接口
    /// </summary>
    public interface IOrder2Service : IBaseService<Order2>
    {
        PagedInfo<Order2Dto> GetList(Order2QueryDto parm);

        Order2 GetInfo(int Id);

        List<Order2> GetTreeList(Order2QueryDto parm);

        Order2 AddOrder2(Order2 parm);
        int UpdateOrder2(Order2 parm);


    }
}

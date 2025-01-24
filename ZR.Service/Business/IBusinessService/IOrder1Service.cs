using ZR.Model.Business.Dto;
using ZR.Model.Business;

namespace ZR.Service.Business.IBusinessService
{
    /// <summary>
    /// 建立訂單service接口
    /// </summary>
    public interface IOrder1Service : IBaseService<Order1>
    {
        PagedInfo<Order1Dto> GetList(Order1QueryDto parm);

        Order1 GetInfo(int DocEntry);


        Order1 AddOrder1(Order1 parm);
        int UpdateOrder1(Order1 parm);


    }
}

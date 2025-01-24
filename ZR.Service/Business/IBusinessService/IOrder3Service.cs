using ZR.Model.Business.Dto;
using ZR.Model.Business;

namespace ZR.Service.Business.IBusinessService
{
    /// <summary>
    /// 檔案上傳service接口
    /// </summary>
    public interface IOrder3Service : IBaseService<Order3>
    {
        PagedInfo<Order3Dto> GetList(Order3QueryDto parm);

        Order3 GetInfo(int Id);

        List<Order3> GetTreeList(Order3QueryDto parm);

        Order3 AddOrder3(Order3 parm);
        int UpdateOrder3(Order3 parm);


    }
}

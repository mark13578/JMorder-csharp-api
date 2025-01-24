using ZR.Model.Business.Dto;
using ZR.Model.Business;

namespace ZR.Service.Business.IBusinessService
{
    /// <summary>
    /// 寄送地址維護service接口
    /// </summary>
    public interface ISendaddressService : IBaseService<Sendaddress>
    {
        PagedInfo<SendaddressDto> GetList(SendaddressQueryDto parm);

        Sendaddress GetInfo(int Id);


        Sendaddress AddSendaddress(Sendaddress parm);
        int UpdateSendaddress(Sendaddress parm);


    }
}

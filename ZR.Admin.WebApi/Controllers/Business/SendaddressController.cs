using Microsoft.AspNetCore.Mvc;
using ZR.Model.Business.Dto;
using ZR.Model.Business;
using ZR.Service.Business.IBusinessService;
using ZR.Admin.WebApi.Filters;

//创建时间：2024-12-24
namespace ZR.Admin.WebApi.Controllers.Business
{
    /// <summary>
    /// 寄送地址維護
    /// </summary>
    [Verify]
    [Route("business/Sendaddress")]
    public class SendaddressController : BaseController
    {
        /// <summary>
        /// 寄送地址維護接口
        /// </summary>
        private readonly ISendaddressService _SendaddressService;

        public SendaddressController(ISendaddressService SendaddressService)
        {
            _SendaddressService = SendaddressService;
        }

        /// <summary>
        /// 查询寄送地址維護列表
        /// </summary>
        /// <param name="parm"></param>
        /// <returns></returns>
        [HttpGet("list")]
        [ActionPermissionFilter(Permission = "sendaddress:list")]
        public IActionResult QuerySendaddress([FromQuery] SendaddressQueryDto parm)
        {
            var response = _SendaddressService.GetList(parm);
            return SUCCESS(response);
        }


        /// <summary>
        /// 查询寄送地址維護详情
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        [HttpGet("{Id}")]
        [ActionPermissionFilter(Permission = "sendaddress:query")]
        public IActionResult GetSendaddress(int Id)
        {
            var response = _SendaddressService.GetInfo(Id);
            
            var info = response.Adapt<SendaddressDto>();
            return SUCCESS(info);
        }

        /// <summary>
        /// 添加寄送地址維護
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        [ActionPermissionFilter(Permission = "sendaddress:add")]
        [Log(Title = "寄送地址維護", BusinessType = BusinessType.INSERT)]
        public IActionResult AddSendaddress([FromBody] SendaddressDto parm)
        {
            var modal = parm.Adapt<Sendaddress>().ToCreate(HttpContext);

            var response = _SendaddressService.AddSendaddress(modal);

            return SUCCESS(response);
        }

        /// <summary>
        /// 更新寄送地址維護
        /// </summary>
        /// <returns></returns>
        [HttpPut]
        [ActionPermissionFilter(Permission = "sendaddress:edit")]
        [Log(Title = "寄送地址維護", BusinessType = BusinessType.UPDATE)]
        public IActionResult UpdateSendaddress([FromBody] SendaddressDto parm)
        {
            var modal = parm.Adapt<Sendaddress>().ToUpdate(HttpContext);
            var response = _SendaddressService.UpdateSendaddress(modal);

            return ToResponse(response);
        }

        /// <summary>
        /// 删除寄送地址維護
        /// </summary>
        /// <returns></returns>
        [HttpPost("delete/{ids}")]
        [ActionPermissionFilter(Permission = "sendaddress:delete")]
        [Log(Title = "寄送地址維護", BusinessType = BusinessType.DELETE)]
        public IActionResult DeleteSendaddress([FromRoute]string ids)
        {
            var idArr = Tools.SplitAndConvert<int>(ids);

            return ToResponse(_SendaddressService.Delete(idArr, "删除寄送地址維護"));
        }

    }
}
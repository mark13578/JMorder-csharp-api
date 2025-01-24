using Microsoft.AspNetCore.Mvc;
using ZR.Model.Business.Dto;
using ZR.Model.Business;
using ZR.Service.Business.IBusinessService;
using ZR.Admin.WebApi.Filters;

//创建时间：2024-12-19
namespace ZR.Admin.WebApi.Controllers.Business
{
    /// <summary>
    /// 建立訂單
    /// </summary>
    [Verify]
    [Route("business/CreateOrder")]
    public class Order1Controller : BaseController
    {
        /// <summary>
        /// 建立訂單接口
        /// </summary>
        private readonly IOrder1Service _Order1Service;

        public Order1Controller(IOrder1Service Order1Service)
        {
            _Order1Service = Order1Service;
        }

        /// <summary>
        /// 查询建立訂單列表
        /// </summary>
        /// <param name="parm"></param>
        /// <returns></returns>
        [HttpGet("list")]
        [ActionPermissionFilter(Permission = "order1:list")]
        public IActionResult QueryOrder1([FromQuery] Order1QueryDto parm)
        {
            var response = _Order1Service.GetList(parm);
            return SUCCESS(response);
        }


        /// <summary>
        /// 查询建立訂單详情
        /// </summary>
        /// <param name="DocEntry"></param>
        /// <returns></returns>
        [HttpGet("{DocEntry}")]
        [ActionPermissionFilter(Permission = "order1:query")]
        public IActionResult GetOrder1(int DocEntry)
        {
            var response = _Order1Service.GetInfo(DocEntry);
            
            var info = response.Adapt<Order1Dto>();
            return SUCCESS(info);
        }

        /// <summary>
        /// 添加建立訂單
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        [ActionPermissionFilter(Permission = "order1:add")]
        [Log(Title = "建立訂單", BusinessType = BusinessType.INSERT)]
        public IActionResult AddOrder1([FromBody] Order1Dto parm)
        {
            var modal = parm.Adapt<Order1>().ToCreate(HttpContext);

            var response = _Order1Service.AddOrder1(modal);

            return SUCCESS(response);
        }

        /// <summary>
        /// 更新建立訂單
        /// </summary>
        /// <returns></returns>
        [HttpPut]
        [ActionPermissionFilter(Permission = "order1:edit")]
        [Log(Title = "建立訂單", BusinessType = BusinessType.UPDATE)]
        public IActionResult UpdateOrder1([FromBody] Order1Dto parm)
        {
            var modal = parm.Adapt<Order1>().ToUpdate(HttpContext);
            var response = _Order1Service.UpdateOrder1(modal);

            return ToResponse(response);
        }

        /// <summary>
        /// 删除建立訂單
        /// </summary>
        /// <returns></returns>
        [HttpPost("delete/{ids}")]
        [ActionPermissionFilter(Permission = "order1:delete")]
        [Log(Title = "建立訂單", BusinessType = BusinessType.DELETE)]
        public IActionResult DeleteOrder1([FromRoute]string ids)
        {
            var idArr = Tools.SplitAndConvert<int>(ids);

            return ToResponse(_Order1Service.Delete(idArr, "删除建立訂單"));
        }

    }
}
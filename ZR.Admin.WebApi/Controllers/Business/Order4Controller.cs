using Microsoft.AspNetCore.Mvc;
using ZR.Model.Business.Dto;
using ZR.Model.Business;
using ZR.Service.Business.IBusinessService;
using ZR.Admin.WebApi.Filters;

//创建时间：2024-12-19
namespace ZR.Admin.WebApi.Controllers.Business
{
    /// <summary>
    /// Order4
    /// </summary>
    [Verify]
    [Route("business/OrderAddress")]
    public class Order4Controller : BaseController
    {
        /// <summary>
        /// Order4接口
        /// </summary>
        private readonly IOrder4Service _Order4Service;

        public Order4Controller(IOrder4Service Order4Service)
        {
            _Order4Service = Order4Service;
        }

        /// <summary>
        /// 查询Order4列表
        /// </summary>
        /// <param name="parm"></param>
        /// <returns></returns>
        [HttpGet("list")]
        [ActionPermissionFilter(Permission = "order4:list")]
        public IActionResult QueryOrder4([FromQuery] Order4QueryDto parm)
        {
            var response = _Order4Service.GetList(parm);
            return SUCCESS(response);
        }

        /// <summary>
        /// 查询Order4列表树
        /// </summary>
        /// <param name="parm"></param>
        /// <returns></returns>
        [HttpGet("treeList")]
        [ActionPermissionFilter(Permission = "order4:list")]
        public IActionResult QueryTreeOrder4([FromQuery] Order4QueryDto parm)
        {
            var response = _Order4Service.GetTreeList(parm);
            return SUCCESS(response);
        }

        /// <summary>
        /// 查询Order4详情
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        [HttpGet("{Id}")]
        [ActionPermissionFilter(Permission = "order4:query")]
        public IActionResult GetOrder4(int Id)
        {
            var response = _Order4Service.GetInfo(Id);
            
            var info = response.Adapt<Order4Dto>();
            return SUCCESS(info);
        }

        /// <summary>
        /// 添加Order4
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        [ActionPermissionFilter(Permission = "order4:add")]
        [Log(Title = "Order4", BusinessType = BusinessType.INSERT)]
        public IActionResult AddOrder4([FromBody] Order4Dto parm)
        {
            var modal = parm.Adapt<Order4>().ToCreate(HttpContext);

            var response = _Order4Service.AddOrder4(modal);

            return SUCCESS(response);
        }

        /// <summary>
        /// 更新Order4
        /// </summary>
        /// <returns></returns>
        [HttpPut]
        [ActionPermissionFilter(Permission = "order4:edit")]
        [Log(Title = "Order4", BusinessType = BusinessType.UPDATE)]
        public IActionResult UpdateOrder4([FromBody] Order4Dto parm)
        {
            var modal = parm.Adapt<Order4>().ToUpdate(HttpContext);
            var response = _Order4Service.UpdateOrder4(modal);

            return ToResponse(response);
        }

        /// <summary>
        /// 删除Order4
        /// </summary>
        /// <returns></returns>
        [HttpPost("delete/{ids}")]
        [ActionPermissionFilter(Permission = "order4:delete")]
        [Log(Title = "Order4", BusinessType = BusinessType.DELETE)]
        public IActionResult DeleteOrder4([FromRoute]string ids)
        {
            var idArr = Tools.SplitAndConvert<int>(ids);

            return ToResponse(_Order4Service.Delete(idArr, "删除Order4"));
        }

    }
}
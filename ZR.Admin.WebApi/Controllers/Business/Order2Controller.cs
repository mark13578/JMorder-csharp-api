using Microsoft.AspNetCore.Mvc;
using ZR.Model.Business.Dto;
using ZR.Model.Business;
using ZR.Service.Business.IBusinessService;
using ZR.Admin.WebApi.Filters;

//创建时间：2024-12-19
namespace ZR.Admin.WebApi.Controllers.Business
{
    /// <summary>
    /// 建立訂單_建立備註
    /// </summary>
    [Verify]
    [Route("business/OrderComments")]
    public class Order2Controller : BaseController
    {
        /// <summary>
        /// 建立訂單_建立備註接口
        /// </summary>
        private readonly IOrder2Service _Order2Service;

        public Order2Controller(IOrder2Service Order2Service)
        {
            _Order2Service = Order2Service;
        }

        /// <summary>
        /// 查询建立訂單_建立備註列表
        /// </summary>
        /// <param name="parm"></param>
        /// <returns></returns>
        [HttpGet("list")]
        [ActionPermissionFilter(Permission = "order2:list")]
        public IActionResult QueryOrder2([FromQuery] Order2QueryDto parm)
        {
            var response = _Order2Service.GetList(parm);
            return SUCCESS(response);
        }

        /// <summary>
        /// 查询建立訂單_建立備註列表树
        /// </summary>
        /// <param name="parm"></param>
        /// <returns></returns>
        [HttpGet("treeList")]
        [ActionPermissionFilter(Permission = "order2:list")]
        public IActionResult QueryTreeOrder2([FromQuery] Order2QueryDto parm)
        {
            var response = _Order2Service.GetTreeList(parm);
            return SUCCESS(response);
        }

        /// <summary>
        /// 查询建立訂單_建立備註详情
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        [HttpGet("{Id}")]
        [ActionPermissionFilter(Permission = "order2:query")]
        public IActionResult GetOrder2(int Id)
        {
            var response = _Order2Service.GetInfo(Id);
            
            var info = response.Adapt<Order2Dto>();
            return SUCCESS(info);
        }

        /// <summary>
        /// 添加建立訂單_建立備註
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        [ActionPermissionFilter(Permission = "order2:add")]
        [Log(Title = "建立訂單_建立備註", BusinessType = BusinessType.INSERT)]
        public IActionResult AddOrder2([FromBody] Order2Dto parm)
        {
            var modal = parm.Adapt<Order2>().ToCreate(HttpContext);

            var response = _Order2Service.AddOrder2(modal);

            return SUCCESS(response);
        }

        /// <summary>
        /// 更新建立訂單_建立備註
        /// </summary>
        /// <returns></returns>
        [HttpPut]
        [ActionPermissionFilter(Permission = "order2:edit")]
        [Log(Title = "建立訂單_建立備註", BusinessType = BusinessType.UPDATE)]
        public IActionResult UpdateOrder2([FromBody] Order2Dto parm)
        {
            var modal = parm.Adapt<Order2>().ToUpdate(HttpContext);
            var response = _Order2Service.UpdateOrder2(modal);

            return ToResponse(response);
        }

        /// <summary>
        /// 删除建立訂單_建立備註
        /// </summary>
        /// <returns></returns>
        [HttpPost("delete/{ids}")]
        [ActionPermissionFilter(Permission = "order2:delete")]
        [Log(Title = "建立訂單_建立備註", BusinessType = BusinessType.DELETE)]
        public IActionResult DeleteOrder2([FromRoute]string ids)
        {
            var idArr = Tools.SplitAndConvert<int>(ids);

            return ToResponse(_Order2Service.Delete(idArr, "删除建立訂單_建立備註"));
        }

    }
}
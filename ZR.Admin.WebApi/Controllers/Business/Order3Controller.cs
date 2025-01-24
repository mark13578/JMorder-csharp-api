using Microsoft.AspNetCore.Mvc;
using ZR.Model.Business.Dto;
using ZR.Model.Business;
using ZR.Service.Business.IBusinessService;
using ZR.Admin.WebApi.Filters;

//创建时间：2024-12-19
namespace ZR.Admin.WebApi.Controllers.Business
{
    /// <summary>
    /// 檔案上傳
    /// </summary>
    [Verify]
    [Route("business/OrderFileUpload")]
    public class Order3Controller : BaseController
    {
        /// <summary>
        /// 檔案上傳接口
        /// </summary>
        private readonly IOrder3Service _Order3Service;

        public Order3Controller(IOrder3Service Order3Service)
        {
            _Order3Service = Order3Service;
        }

        /// <summary>
        /// 查询檔案上傳列表
        /// </summary>
        /// <param name="parm"></param>
        /// <returns></returns>
        [HttpGet("list")]
        [ActionPermissionFilter(Permission = "order3:list")]
        public IActionResult QueryOrder3([FromQuery] Order3QueryDto parm)
        {
            var response = _Order3Service.GetList(parm);
            return SUCCESS(response);
        }

        /// <summary>
        /// 查询檔案上傳列表树
        /// </summary>
        /// <param name="parm"></param>
        /// <returns></returns>
        [HttpGet("treeList")]
        [ActionPermissionFilter(Permission = "order3:list")]
        public IActionResult QueryTreeOrder3([FromQuery] Order3QueryDto parm)
        {
            var response = _Order3Service.GetTreeList(parm);
            return SUCCESS(response);
        }

        /// <summary>
        /// 查询檔案上傳详情
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        [HttpGet("{Id}")]
        [ActionPermissionFilter(Permission = "order3:query")]
        public IActionResult GetOrder3(int Id)
        {
            var response = _Order3Service.GetInfo(Id);
            
            var info = response.Adapt<Order3Dto>();
            return SUCCESS(info);
        }

        /// <summary>
        /// 添加檔案上傳
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        [ActionPermissionFilter(Permission = "order3:add")]
        [Log(Title = "檔案上傳", BusinessType = BusinessType.INSERT)]
        public IActionResult AddOrder3([FromBody] Order3Dto parm)
        {
            var modal = parm.Adapt<Order3>().ToCreate(HttpContext);

            var response = _Order3Service.AddOrder3(modal);

            return SUCCESS(response);
        }

        /// <summary>
        /// 更新檔案上傳
        /// </summary>
        /// <returns></returns>
        [HttpPut]
        [ActionPermissionFilter(Permission = "order3:edit")]
        [Log(Title = "檔案上傳", BusinessType = BusinessType.UPDATE)]
        public IActionResult UpdateOrder3([FromBody] Order3Dto parm)
        {
            var modal = parm.Adapt<Order3>().ToUpdate(HttpContext);
            var response = _Order3Service.UpdateOrder3(modal);

            return ToResponse(response);
        }

        /// <summary>
        /// 删除檔案上傳
        /// </summary>
        /// <returns></returns>
        [HttpPost("delete/{ids}")]
        [ActionPermissionFilter(Permission = "order3:delete")]
        [Log(Title = "檔案上傳", BusinessType = BusinessType.DELETE)]
        public IActionResult DeleteOrder3([FromRoute]string ids)
        {
            var idArr = Tools.SplitAndConvert<int>(ids);

            return ToResponse(_Order3Service.Delete(idArr, "删除檔案上傳"));
        }

    }
}
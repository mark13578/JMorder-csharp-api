using Infrastructure.Attribute;
using Infrastructure.Extensions;
using ZR.Model.Business.Dto;
using ZR.Model.Business;
using ZR.Repository;
using ZR.Service.Business.IBusinessService;
using System.Collections.Generic;
using Microsoft.Extensions.Logging.Abstractions;

namespace ZR.Service.Business
{
    /// <summary>
    /// 建立訂單_建立備註Service业务层处理
    /// </summary>
    [AppService(ServiceType = typeof(IOrder2Service), ServiceLifetime = LifeTime.Transient)]
    public class Order2Service : BaseService<Order2>, IOrder2Service
    {
        /// <summary>
        /// 查询建立訂單_建立備註列表
        /// </summary>
        /// <param name="parm"></param>
        /// <returns></returns>
        public PagedInfo<Order2Dto> GetList(Order2QueryDto parm)
        {
            var predicate = QueryExp(parm);

            var response = Queryable()
                //.OrderBy("DocEntry asc")
                .Where(predicate.ToExpression())
                .ToPage<Order2, Order2Dto>(parm);

            return response;
        }

        /// <summary>
        /// 查询建立訂單_建立備註树列表
        /// </summary>
        /// <param name="parm"></param>
        /// <returns></returns>
        public List<Order2> GetTreeList(Order2QueryDto parm)
        {
            var predicate = Expressionable.Create<Order2>();


            var response = Queryable()
                .Where(predicate.ToExpression())
                .ToTree(it => it.Children, it => it.DocEntry, 0);

            return response;
        }

        /// <summary>
        /// 获取详情
        /// </summary>
        /// <param name="DocEntry"></param>
        /// <returns></returns>
        public Order2 GetInfo(int DocEntry)
        {
            var response = Queryable()
                .Where(x => x.DocEntry == DocEntry)
                .First();

            return response;
        }

        /// <summary>
        /// 添加建立訂單_建立備註
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public Order2 AddOrder2(Order2 model)
        {
            return Insertable(model).ExecuteReturnEntity();
        }

        /// <summary>
        /// 修改建立訂單_建立備註
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public int UpdateOrder2(Order2 model)
        {
            return Update(model, true, "修改建立訂單_建立備註");
        }

        /// <summary>
        /// 查询导出表达式
        /// </summary>
        /// <param name="parm"></param>
        /// <returns></returns>
        private static Expressionable<Order2> QueryExp(Order2QueryDto parm)
        {
            var predicate = Expressionable.Create<Order2>();

            return predicate;
        }
    }
}
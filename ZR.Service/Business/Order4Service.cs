using Infrastructure.Attribute;
using Infrastructure.Extensions;
using ZR.Model.Business.Dto;
using ZR.Model.Business;
using ZR.Repository;
using ZR.Service.Business.IBusinessService;
using System.Collections.Generic;

namespace ZR.Service.Business
{
    /// <summary>
    /// Order4Service业务层处理
    /// </summary>
    [AppService(ServiceType = typeof(IOrder4Service), ServiceLifetime = LifeTime.Transient)]
    public class Order4Service : BaseService<Order4>, IOrder4Service
    {
        /// <summary>
        /// 查询Order4列表
        /// </summary>
        /// <param name="parm"></param>
        /// <returns></returns>
        public PagedInfo<Order4Dto> GetList(Order4QueryDto parm)
        {
            var predicate = QueryExp(parm);

            var response = Queryable()
                //.OrderBy("Linenum asc")
                .Where(predicate.ToExpression())
                .ToPage<Order4, Order4Dto>(parm);

            return response;
        }

        /// <summary>
        /// 查询Order4树列表
        /// </summary>
        /// <param name="parm"></param>
        /// <returns></returns>
        public List<Order4> GetTreeList(Order4QueryDto parm)
        {
            var predicate = Expressionable.Create<Order4>();


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
        public Order4 GetInfo(int DocEntry)
        {
            var response = Queryable()
                .Where(x => x.DocEntry == DocEntry)
                .First();

            return response;
        }

        /// <summary>
        /// 添加Order4
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public Order4 AddOrder4(Order4 model)
        {
            return Insertable(model).ExecuteReturnEntity();
        }

        /// <summary>
        /// 修改Order4
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public int UpdateOrder4(Order4 model)
        {
            return Update(model, true, "修改Order4");
        }

        /// <summary>
        /// 查询导出表达式
        /// </summary>
        /// <param name="parm"></param>
        /// <returns></returns>
        private static Expressionable<Order4> QueryExp(Order4QueryDto parm)
        {
            var predicate = Expressionable.Create<Order4>();

            return predicate;
        }
    }
}
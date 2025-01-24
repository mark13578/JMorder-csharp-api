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
    /// 檔案上傳Service业务层处理
    /// </summary>
    [AppService(ServiceType = typeof(IOrder3Service), ServiceLifetime = LifeTime.Transient)]
    public class Order3Service : BaseService<Order3>, IOrder3Service
    {
        /// <summary>
        /// 查询檔案上傳列表
        /// </summary>
        /// <param name="parm"></param>
        /// <returns></returns>
        public PagedInfo<Order3Dto> GetList(Order3QueryDto parm)
        {
            var predicate = QueryExp(parm);

            var response = Queryable()
                .Where(predicate.ToExpression())
                .ToPage<Order3, Order3Dto>(parm);

            return response;
        }

        /// <summary>
        /// 查询檔案上傳树列表
        /// </summary>
        /// <param name="parm"></param>
        /// <returns></returns>
        public List<Order3> GetTreeList(Order3QueryDto parm)
        {
            var predicate = Expressionable.Create<Order3>();

            predicate = predicate.AndIF(!string.IsNullOrEmpty(parm.FileName), it => it.FileName == parm.FileName);

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
        public Order3 GetInfo(int DocEntry)
        {
            var response = Queryable()
                .Where(x => x.DocEntry == DocEntry)
                .First();

            return response;
        }

        /// <summary>
        /// 添加檔案上傳
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public Order3 AddOrder3(Order3 model)
        {
            return Insertable(model).ExecuteReturnEntity();
        }

        /// <summary>
        /// 修改檔案上傳
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public int UpdateOrder3(Order3 model)
        {
            return Update(model, true, "修改檔案上傳");
        }

        /// <summary>
        /// 查询导出表达式
        /// </summary>
        /// <param name="parm"></param>
        /// <returns></returns>
        private static Expressionable<Order3> QueryExp(Order3QueryDto parm)
        {
            var predicate = Expressionable.Create<Order3>();

            predicate = predicate.AndIF(!string.IsNullOrEmpty(parm.FileName), it => it.FileName == parm.FileName);
            return predicate;
        }
    }
}
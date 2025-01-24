using Infrastructure.Attribute;
using Infrastructure.Extensions;
using ZR.Model.Business.Dto;
using ZR.Model.Business;
using ZR.Repository;
using ZR.Service.Business.IBusinessService;

namespace ZR.Service.Business
{
    /// <summary>
    /// 建立訂單Service业务层处理
    /// </summary>
    [AppService(ServiceType = typeof(IOrder1Service), ServiceLifetime = LifeTime.Transient)]
    public class Order1Service : BaseService<Order1>, IOrder1Service
    {
        /// <summary>
        /// 查询建立訂單列表
        /// </summary>
        /// <param name="parm"></param>
        /// <returns></returns>
        public PagedInfo<Order1Dto> GetList(Order1QueryDto parm)
        {
            var predicate = QueryExp(parm);

            var response = Queryable()
                //.Includes(x => x.Order2Nav) //填充子对象
                //.OrderBy("DocNum asc")
                .Where(predicate.ToExpression())
                .ToPage<Order1, Order1Dto>(parm);

            return response;
        }


        /// <summary>
        /// 获取详情
        /// </summary>
        /// <param name="DocEntry"></param>
        /// <returns></returns>
        public Order1 GetInfo(int DocEntry)
        {
            var response = Queryable()
                .Includes(x => x.Order2Nav) //填充子对象
                .Where(x => x.DocEntry == DocEntry)
                .First();

            return response;
        }

        /// <summary>
        /// 添加建立訂單
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public Order1 AddOrder1(Order1 model)
        {
            return Context.InsertNav(model).Include(s1 => s1.Order2Nav).ExecuteReturnEntity();
        }

        /// <summary>
        /// 修改建立訂單
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public int UpdateOrder1(Order1 model)
        {
            return Context.UpdateNav(model).Include(z1 => z1.Order2Nav).ExecuteCommand() ? 1 : 0;
        }

        /// <summary>
        /// 查询导出表达式
        /// </summary>
        /// <param name="parm"></param>
        /// <returns></returns>
        private static Expressionable<Order1> QueryExp(Order1QueryDto parm)
        {
            var predicate = Expressionable.Create<Order1>();

            predicate = predicate.AndIF(!string.IsNullOrEmpty(parm.DocNum), it => it.DocNum == parm.DocNum);
            predicate = predicate.AndIF(parm.BeginCreateTime == null, it => it.CreateTime >= DateTime.Now.ToShortDateString().ParseToDateTime());
            predicate = predicate.AndIF(parm.BeginCreateTime != null, it => it.CreateTime >= parm.BeginCreateTime);
            predicate = predicate.AndIF(parm.EndCreateTime != null, it => it.CreateTime <= parm.EndCreateTime);
            predicate = predicate.AndIF(!string.IsNullOrEmpty(parm.CustomerName), it => it.CustomerName == parm.CustomerName);
            predicate = predicate.AndIF(!string.IsNullOrEmpty(parm.Casename), it => it.Casename == parm.Casename);
            return predicate;
        }
    }
}
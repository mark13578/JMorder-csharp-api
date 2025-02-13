using Infrastructure.Attribute;
using Infrastructure.Extensions;
using ZR.Model.Business.Dto;
using ZR.Model.Business;
using ZR.Repository;
using ZR.Service.Business.IBusinessService;

namespace ZR.Service.Business
{
    /// <summary>
    /// 建立工單Service业务层处理
    /// </summary>
    [AppService(ServiceType = typeof(IOrder1Service), ServiceLifetime = LifeTime.Transient)]
    public class Order1Service : BaseService<Order1>, IOrder1Service
    {
        /// <summary>
        /// 查询建立工單列表
        /// </summary>
        /// <param name="parm"></param>
        /// <returns></returns>
        public PagedInfo<Order1Dto> GetList(Order1QueryDto parm)
        {
            var predicate = QueryExp(parm);

            var response = Queryable()
                //.Includes(x => x.Order2Nav) //填充子对象
                .OrderBy("DocEntry asc")
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
        /// 添加建立工單
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public Order1 AddOrder1(Order1 model)
        {
            return Context.InsertNav(model).Include(s1 => s1.Order2Nav).ExecuteReturnEntity();
        }

        /// <summary>
        /// 修改建立工單
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public int UpdateOrder1(Order1 model)
        {
            return Context.UpdateNav(model).Include(z1 => z1.Order2Nav).ExecuteCommand() ? 1 : 0;
        }

        /// <summary>
        /// 导出建立工單
        /// </summary>
        /// <param name="parm"></param>
        /// <returns></returns>
        public PagedInfo<Order1Dto> ExportList(Order1QueryDto parm)
        {
            var predicate = QueryExp(parm);

            var response = Queryable()
                .Where(predicate.ToExpression())
                .Select((it) => new Order1Dto()
                {
                    CasetypeLabel = it.Casetype.GetConfigValue<Model.System.SysDictData>("casetype"),
                    CaseitemLabel = it.Caseitem.GetConfigValue<Model.System.SysDictData>("caseitem"),
                    PrintLabel = it.Print.GetConfigValue<Model.System.SysDictData>("print"),
                    Paper1Label = it.Paper1.GetConfigValue<Model.System.SysDictData>("paper1"),
                    Paper2Label = it.Paper2.GetConfigValue<Model.System.SysDictData>("paper2"),
                    Paper3Label = it.Paper3.GetConfigValue<Model.System.SysDictData>("paper3"),
                    Paper4Label = it.Paper4.GetConfigValue<Model.System.SysDictData>("paper4"),
                    UnitLabel = it.Unit.GetConfigValue<Model.System.SysDictData>("unit"),
                    TearLabel = it.Tear.GetConfigValue<Model.System.SysDictData>("tear"),
                    PastyDirectionLabel = it.PastyDirection.GetConfigValue<Model.System.SysDictData>("pasty"),
                    CoverLabel = it.Cover.GetConfigValue<Model.System.SysDictData>("cover"),
                    HoleLabel = it.Hole.GetConfigValue<Model.System.SysDictData>("hole"),
                    NailLabel = it.Nail.GetConfigValue<Model.System.SysDictData>("nail"),
                    ThickplateLabel = it.Thickplate.GetConfigValue<Model.System.SysDictData>("thickplate"),
                }, true)
                .ToPage(parm);

            return response;
        }

        /// <summary>
        /// 查询导出表达式
        /// </summary>
        /// <param name="parm"></param>
        /// <returns></returns>
        private static Expressionable<Order1> QueryExp(Order1QueryDto parm)
        {
            var predicate = Expressionable.Create<Order1>();

            return predicate;
        }
    }
}
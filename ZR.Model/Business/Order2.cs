
namespace ZR.Model.Business
{
    /// <summary>
    /// 建立訂單_建立備註
    /// </summary>
    [SugarTable("order_2")]
    public class Order2
    {
        /// <summary>
        /// 流水號 
        /// </summary>
        public int? DocEntry { get; set; }

        /// <summary>
        /// 備註 
        /// </summary>
        public string Comment { get; set; }

        [SugarColumn(IsIgnore = true)]
        public List<Order2> Children { get; set; }
    }
}
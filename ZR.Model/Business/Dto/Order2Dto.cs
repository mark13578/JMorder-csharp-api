
namespace ZR.Model.Business.Dto
{
    /// <summary>
    /// 建立訂單_建立備註查询对象
    /// </summary>
    public class Order2QueryDto : PagerInfo 
    {
    }

    /// <summary>
    /// 建立訂單_建立備註输入输出对象
    /// </summary>
    public class Order2Dto
    {
        public int? DocEntry { get; set; }

        public string Comment { get; set; }



    }
}
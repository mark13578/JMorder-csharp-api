
namespace ZR.Model.Business.Dto
{
    /// <summary>
    /// Order4查询对象
    /// </summary>
    public class Order4QueryDto : PagerInfo 
    {
    }

    /// <summary>
    /// Order4输入输出对象
    /// </summary>
    public class Order4Dto
    {
        public string DocEntry { get; set; }

        public int? Linenum { get; set; }

        public string Recipient { get; set; }

        public string Contacts { get; set; }

        public string Phone { get; set; }

        public string Address { get; set; }

        public string Mobile { get; set; }

        public string SendComment { get; set; }

        public int? Agency { get; set; }



    }
}
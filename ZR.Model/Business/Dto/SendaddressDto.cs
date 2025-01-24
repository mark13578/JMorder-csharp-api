
namespace ZR.Model.Business.Dto
{
    /// <summary>
    /// 寄送地址維護查询对象
    /// </summary>
    public class SendaddressQueryDto : PagerInfo 
    {
        public string Recipient { get; set; }
        public string Contacts { get; set; }
        public string Phone { get; set; }
    }

    /// <summary>
    /// 寄送地址維護输入输出对象
    /// </summary>
    public class SendaddressDto
    {
        public string DocEntry { get; set; }
        public int? Linenum { get; set; }

        public string CustomerID { get; set; }

        public string Recipient { get; set; }

        public string Contacts { get; set; }

        public string Phone { get; set; }

        public string Address { get; set; }

        public string Mobile { get; set; }

        public string SendComment { get; set; }





    }
}
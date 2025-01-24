
namespace ZR.Model.Business
{
    /// <summary>
    /// 寄送地址維護
    /// </summary>
    [SugarTable("sendaddress")]
    public class Sendaddress
    {
        /// <summary>
        /// 列編號 
        /// </summary>
        public int? Linenum { get; set; }

        ///// <summary>
        ///// 客戶編號 
        ///// </summary>
        //public string CustomerID { get; set; }

        /// <summary>
        /// 寄送公司行號 
        /// </summary>
        public string Recipient { get; set; }

        /// <summary>
        /// 收件者 
        /// </summary>
        public string Contacts { get; set; }

        /// <summary>
        /// 連絡電話 
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// 收件地址 
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// 手機號碼 
        /// </summary>
        public string Mobile { get; set; }

        /// <summary>
        /// 備註 
        /// </summary>
        public string SendComment { get; set; }


        ///// <summary>
        ///// Id 
        ///// </summary>
        //[SugarColumn(IsPrimaryKey = true, IsIdentity = false)]
        //public int Id { get; set; }

    }
}
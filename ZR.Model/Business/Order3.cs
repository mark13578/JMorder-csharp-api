
namespace ZR.Model.Business
{
    /// <summary>
    /// 檔案上傳
    /// </summary>
    [SugarTable("order_3")]
    public class Order3
    {
        /// <summary>
        /// 流水號 
        /// </summary>
        public int? DocEntry { get; set; }

        /// <summary>
        /// 列編號 
        /// </summary>
        public int? Linenum { get; set; }

        /// <summary>
        /// 上傳格式 
        /// </summary>
        public string FileType { get; set; }

        /// <summary>
        /// 上傳名稱 
        /// </summary>
        public string FileName { get; set; }

        /// <summary>
        /// 檔案大小 
        /// </summary>
        public int? FileSize { get; set; }

        /// <summary>
        /// 上傳來源 
        /// </summary>
        public string FileSource { get; set; }

        /// <summary>
        /// 上傳時間 
        /// </summary>
        public DateTime? UploadTimestamp { get; set; }

        [SugarColumn(IsIgnore = true)]
        public List<Order3> Children { get; set; }
    }
}
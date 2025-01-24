
namespace ZR.Model.Business.Dto
{
    /// <summary>
    /// 檔案上傳查询对象
    /// </summary>
    public class Order3QueryDto : PagerInfo 
    {
        public string FileName { get; set; }
    }

    /// <summary>
    /// 檔案上傳输入输出对象
    /// </summary>
    public class Order3Dto
    {
        public int? DocEntry { get; set; }

        public int? Linenum { get; set; }

        public string FileType { get; set; }

        public string FileName { get; set; }

        public int? FileSize { get; set; }

        public string FileSource { get; set; }

        public DateTime? UploadTimestamp { get; set; }



        [ExcelColumn(Name = "上傳格式")]
        public string FileTypeLabel { get; set; }
    }
}
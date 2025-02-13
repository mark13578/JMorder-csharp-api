using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZR.Model.Business
{
    public class Order
    {
        public int DocEntry { get; set; }
        public string DocNum { get; set; }
        public DateTime DocDate { get; set; }
        public DateTime CreateTime { get; set; }
        public long UserId { get; set; }
        public string CustomerContact { get; set; }
        public string CustomerPhone { get; set; }
        public string Casename { get; set; }
        public string Casetype { get; set; }
        public string Print { get; set; }
        public int Quantity { get; set; }
        public string Unit { get; set; }
        public List<Order2> OrderNotes { get; set; }
        public List<Order3> OrderFiles { get; set; }
        public List<Order4> OrderShipments { get; set; }
    }

    public class Order2
    {
        public int DocEntry { get; set; }
        public string Comment { get; set; }
    }

    public class Order3
    {
        public int DocEntry { get; set; }
        public int Linenum { get; set; }
        public string FileType { get; set; }
        public string FileName { get; set; }
        public int FileSize { get; set; }
        public string FileSource { get; set; }
        public DateTime UploadTimestamp { get; set; }
    }

    public class Order4
    {
        public int DocEntry { get; set; }
        public int Linenum { get; set; }
        public string Recipient { get; set; }
        public string Contacts { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Mobile { get; set; }
        public string SendComment { get; set; }
        public int Agency { get; set; }
    }
}

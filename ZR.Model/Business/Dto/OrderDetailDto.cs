using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZR.Model.Business.Dto
{
    public class OrderDetailDto
    {
        public int DocEntry { get; set; }
        public string Casename { get; set; }
        public string Casetype { get; set; }
        public string Print { get; set; }
        public int Quantity { get; set; }

        public string UserId { get; set; }

        public string RoleId { get; set; }
    }
}

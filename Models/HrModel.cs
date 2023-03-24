using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace kgbvjh.Models
{
    public class HrModel
    {
        public int Id { get; set; }
        public string F01 { get; set; }
        public string F02 { get; set; }
        public string F03 { get; set; }
        public string F04 { get; set; }
        public string F06 { get; set; }
        public string F07 { get; set; }
        public string F08 { get; set; }
        public string F09 { get; set; }
        public string F10 { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public string createdby { get; set; }
        public Nullable<System.DateTime> createddate { get; set; }
        public string updatedby { get; set; }
        public Nullable<System.DateTime> updateddate { get; set; }

    }
}